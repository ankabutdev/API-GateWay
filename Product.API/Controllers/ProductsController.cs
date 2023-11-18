using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Product.API.Models;
using User.API.Models;

namespace User.API.Controllers;

[Route("api/products/")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMongoCollection<ProductModel> _productsCollection;
    private readonly IMongoCollection<CounterModel> _counterCollection;

    public ProductsController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("MongoDbConnection");
        var databaseName = "ProductGateWayDb";

        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);

        _productsCollection = database.GetCollection<ProductModel>("products");
        _counterCollection = database.GetCollection<CounterModel>("counters");
    }


    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var products = await _productsCollection.Find(_ => true).ToListAsync();
        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(ProductDto productDto)
    {
        var counter = await _counterCollection.FindOneAndUpdateAsync(
            Builders<CounterModel>.Filter.Eq(c => c.Id, "productCounter"),
            Builders<CounterModel>.Update.Inc(c => c.Value, 1),
            new FindOneAndUpdateOptions<CounterModel, CounterModel>
            {
                IsUpsert = true,
                ReturnDocument = ReturnDocument.After
            });

        var productModel = new ProductModel
        {
            Id = counter.Value,
            Name = productDto.Name,
            Description = productDto.Description,
            Price = productDto.Price
        };

        await _productsCollection.InsertOneAsync(productModel);

        return Ok(productModel);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, ProductDto productDto)
    {
        var filter = Builders<ProductModel>.Filter.Eq(p => p.Id, id);
        var update = Builders<ProductModel>.Update
            .Set(p => p.Name, productDto.Name)
            .Set(p => p.Description, productDto.Description)
            .Set(p => p.Price, productDto.Price);

        var result = await _productsCollection.UpdateOneAsync(filter, update);

        if (result.ModifiedCount == 0)
        {
            return NotFound();
        }

        return Ok(productDto);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _productsCollection.DeleteOneAsync(p => p.Id == id);

        if (result.DeletedCount == 0)
        {
            return NotFound();
        }

        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var product = await _productsCollection.Find(p => p.Id == id).FirstOrDefaultAsync();

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }
}
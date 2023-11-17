using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace User.API.Models;

public class ProductModel
{
    [BsonId]
    [BsonRepresentation(BsonType.Int32)]
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

}

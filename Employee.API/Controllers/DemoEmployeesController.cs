using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using User.API.Models;

namespace Employee.API.Controllers;

[Route("api/demoemoloyees/")]
[ApiController]
public class DemoEmployeesController : ControllerBase
{
    private readonly IDistributedCache _cache;

    public DemoEmployeesController(IDistributedCache cache)
    {
        _cache = cache ?? throw new ArgumentNullException(nameof(cache));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var cacheKey = "AllEmployees";

        var cachedData = await _cache.GetStringAsync(cacheKey);

        if (cachedData is null)
        {
            var employeesFromDb = EmployeeModel.Employees;

            var cacheOptions = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1),
                SlidingExpiration = TimeSpan.FromSeconds(20)
            };

            await _cache.SetStringAsync(cacheKey, JsonConvert.SerializeObject(employeesFromDb), cacheOptions);

            return Ok(employeesFromDb);
        }

        //await _cache.SetStringAsync(cacheKey, cachedData.ToString());

        return Ok(cachedData);


    }
}
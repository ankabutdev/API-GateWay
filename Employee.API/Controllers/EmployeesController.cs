using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using User.API.Models;

namespace User.API.Controllers;

[Route("api/employees/")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly IDistributedCache _cache;

    public EmployeesController(IDistributedCache cache)
    {
        _cache = cache ?? throw new ArgumentNullException(nameof(cache));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var cachedData = await _cache.GetStringAsync("AllEmployees");

        if (cachedData != null)
        {
            var employees = JsonConvert.DeserializeObject<EmployeeModel[]>(cachedData);
            return Ok(employees);
        }

        var employeesFromDb = EmployeeModel.Employees;

        var cacheOptions = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1),
            SlidingExpiration = TimeSpan.FromSeconds(20)
        };

        await _cache.SetStringAsync("AllEmployees", JsonConvert.SerializeObject(employeesFromDb), cacheOptions);

        return Ok(employeesFromDb);
    }
}

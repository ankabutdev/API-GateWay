using Microsoft.AspNetCore.Mvc;
using User.API.Data;
using User.API.Models;

namespace User.API.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController(UserDbContext DbContext) : ControllerBase
{
    private readonly UserDbContext _dbContext = DbContext;

    public async Task<IActionResult> GetAllAsync()
    {
        return Ok();
    }

    public async Task<IActionResult> CreateAsync(UserModel user)
    {
        return Ok();
    }

    public async Task<IActionResult> UpdateAsync(UserModel user)
    {
        return Ok();
    }

    public async Task<IActionResult> DeleteAsync(int id)
    {
        return Ok();
    }

    public async Task<IActionResult> GetUserById(int id)
    {
        return Ok();
    }
}

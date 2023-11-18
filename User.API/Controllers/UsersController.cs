using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User.API.Data;
using User.API.Models;

namespace User.API.Controllers;

[Route("api/users/")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly UserDbContext _dbContext;

    public UsersController(UserDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await _dbContext.Users.ToListAsync();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(UserDto userDto)
    {
        var userModel = new UserModel
        {
            FirstName = userDto.FirstName,
            LastName = userDto.LastName,
            Email = userDto.Email,
            Password = userDto.Password
        };

        _dbContext.Users.Add(userModel);
        await _dbContext.SaveChangesAsync();

        return Ok(userModel);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, UserDto userDto)
    {
        var userModel = await _dbContext.Users.FindAsync(id);

        if (userModel == null)
        {
            return NotFound();
        }

        userModel.FirstName = userDto.FirstName;
        userModel.LastName = userDto.LastName;
        userModel.Email = userDto.Email;
        userModel.Password = userDto.Password;

        _dbContext.Entry(userModel).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();

        return Ok(userModel);
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var user = await _dbContext.Users.FindAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var user = await _dbContext.Users.FindAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }
}

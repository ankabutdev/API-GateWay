using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User.API.Data;
using User.API.Models;

namespace User.API.Controllers;

[Route("api/students/")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly StudentDbContext _dbContext;

    public StudentsController(StudentDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await _dbContext.Students.ToListAsync();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(StudentDto userDto)
    {
        var userModel = new StudentModel
        {
            FirstName = userDto.FirstName,
            LastName = userDto.LastName,
            Email = userDto.Email,
            Password = userDto.Password
        };

        await _dbContext.Students.AddAsync(userModel);
        await _dbContext.SaveChangesAsync();

        return Ok(userModel);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, StudentDto userDto)
    {
        var userModel = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);

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
        var user = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);

        if (user == null)
        {
            return NotFound();
        }

        _dbContext.Students.Remove(user);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var user = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);

        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }
}

using EfHierarchyTPC;
using Microsoft.AspNetCore.Mvc;

namespace EfHierarchyTPC.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly AppDbContext _context;

    public PersonController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("student")]
    public IActionResult GetStudents()
    {
        var students = _context.Students.ToList();
        return Ok(students);
    }

    [HttpGet("teacher")]
    public IActionResult GetTeachers()
    {
        var teachers = _context.Teachers.ToList();
        return Ok(teachers);
    }
}
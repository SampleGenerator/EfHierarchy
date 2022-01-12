using EfHierarchyTPH.Models;
using Microsoft.AspNetCore.Mvc;

namespace EfHierarchyTPH.Controllers;

[ApiController]
[Route("[controller]")]
public class ContractController : ControllerBase
{
    private readonly AppDbContext _context;

    public ContractController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("mobile")]
    public IActionResult GetMobiles()
    {
        var mobileContracts = _context.MobileContracts.ToList();
        return Ok(mobileContracts);
    }

    [HttpGet("tv")]
    public IActionResult GetTvs()
    {
        var tvContracts = _context.TvContracts.ToList();
        return Ok(tvContracts);
    }

    [HttpPost("mobile")]
    public IActionResult CreateMobileContract([FromBody] MobileContract contract)
    {
        var mobileContract = _context.MobileContracts.Add(contract);
        _context.SaveChanges();
        return Ok(mobileContract.Entity);
    }

    [HttpPost("tv")]
    public IActionResult CreateTvContract([FromBody] TvContract contract)
    {
        var mobileContract = _context.TvContracts.Add(contract);
        _context.SaveChanges();
        return Ok(mobileContract.Entity);
    }
}
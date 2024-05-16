using FinsharkAPI.Data;

using Microsoft.AspNetCore.Mvc;

namespace FinsharkAPI.Controllers;

[Route("finshark/stock")]
[ApiController]
public class StockController : Controller
{
    private readonly ApplicationDBContext _dbContext;
    public StockController(ApplicationDBContext context)
    {
        _dbContext = context;
    }

    [HttpGet] //or [HttpRead]
    public IActionResult GetAll()
    {
        var stocks = _dbContext.Stocks.ToList();
        return Ok(stocks);
    }
    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var stocks = _dbContext.Stocks.Find(id);
        if (stocks == null)
        {
            return NotFound();
        }
        return Ok(stocks);
    }
}

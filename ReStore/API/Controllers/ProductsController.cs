using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : BaseApiController
{
    private readonly StoreContext _storeContext;
    public ProductsController(StoreContext context)
    {
        _storeContext = context;
    }
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        return await _storeContext.Products.ToListAsync();
    }
    [HttpGet("{id}")]   // api/products/4
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await _storeContext.Products.FindAsync(id);
        if (product == null) return NotFound();
        return product;

    }
}

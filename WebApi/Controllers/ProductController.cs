using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> Create(Product model)
        {
            _context.Products.Add(model);
            await _context.SaveChangesAsync();

            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Product>>> GetById(int id)
        {
            var model = await _context.Products.FindAsync(id);
            if (model == null) return NotFound(model);

            return Ok(model);
        }

        [HttpPut]
        public async Task<ActionResult<List<Product>>> Update(Product model)
        {
            _context.Products.Update(model);
            await _context.SaveChangesAsync();

            return Ok(await _context.Products.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Product>>> Delete(int id)
        {
            var model = await _context.Products.FindAsync(id);
            if (model == null) return NotFound(model);
            _context.Products.Remove(model);
            await _context.SaveChangesAsync();

            return Ok(await _context.Products.ToListAsync());
        }
    }
}

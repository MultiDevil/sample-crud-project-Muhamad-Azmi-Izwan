using CrudApp.Data;
using CrudApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.Controllers
{
    //Controller class
    //Controller route
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDb _context;

        public ProductController(ProductDb context)
        {
            _context = context;
        }

        // Example to get every data in Product "GET: api/product"
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetData()
        {
            return await _context.Products.ToListAsync();
        }

        // Example to get specific data in Product based on id "GET: api/product/5"
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetSpecificData(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // Example to insert new data based on the body of the json input "POST: api/product"
        [HttpPost]
        public async Task<ActionResult<Product>> InsertData(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSpecificData), new { id = product.Id }, product);
        }

        // Example to update the data in Product based on id and the data that need to be change in json body including id "PUT: api/product/5"
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateData(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // Example to delete data based on their id "DELETE: api/product/5"
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteData(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
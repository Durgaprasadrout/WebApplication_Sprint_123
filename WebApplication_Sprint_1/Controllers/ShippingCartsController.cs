using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_Sprint_1.Models;

namespace WebApplication_Sprint_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingCartsController : ControllerBase
    {
        private readonly ProductContex _context;

        public ShippingCartsController(ProductContex context)
        {
            _context = context;
        }

        // GET: api/ShippingCarts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShippingCart>>> GetShippingCarts()
        {
            return await _context.ShippingCarts.ToListAsync();
        }

        // GET: api/ShippingCarts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShippingCart>> GetShippingCart(int id)
        {
            var shippingCart = await _context.ShippingCarts.FindAsync(id);

            if (shippingCart == null)
            {
                return NotFound();
            }

            return shippingCart;
        }

        // PUT: api/ShippingCarts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShippingCart(int id, ShippingCart shippingCart)
        {
            if (id != shippingCart.Id)
            {
                return BadRequest();
            }

            _context.Entry(shippingCart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShippingCartExists(id))
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

        // POST: api/ShippingCarts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShippingCart>> PostShippingCart(ShippingCart shippingCart)
        {
            _context.ShippingCarts.Add(shippingCart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShippingCart", new { id = shippingCart.Id }, shippingCart);
        }

        // DELETE: api/ShippingCarts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShippingCart(int id)
        {
            var shippingCart = await _context.ShippingCarts.FindAsync(id);
            if (shippingCart == null)
            {
                return NotFound();
            }

            _context.ShippingCarts.Remove(shippingCart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShippingCartExists(int id)
        {
            return _context.ShippingCarts.Any(e => e.Id == id);
        }
    }
}

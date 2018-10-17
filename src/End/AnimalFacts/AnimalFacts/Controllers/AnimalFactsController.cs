using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalFacts.Contexts;
using AnimalFacts.Models;

namespace AnimalFacts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AnimalFactsController : ControllerBase
    {
        private readonly AnimalContext _context;

        public AnimalFactsController(AnimalContext context)
        {
            _context = context;
        }

        // GET: api/AnimalFacts
        [HttpGet]
        public IEnumerable<AnimalFact> GetAnimalFacts()
        {
            return _context.AnimalFacts;
        }

        // GET: api/AnimalFacts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnimalFact([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var animalFact = await _context.AnimalFacts.FindAsync(id);

            if (animalFact == null)
            {
                return NotFound();
            }

            return Ok(animalFact);
        }

        // PUT: api/AnimalFacts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimalFact([FromRoute] int id, [FromBody] AnimalFact animalFact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != animalFact.Id)
            {
                return BadRequest();
            }

            _context.Entry(animalFact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalFactExists(id))
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

        // POST: api/AnimalFacts
        [HttpPost]
        public async Task<IActionResult> PostAnimalFact([FromBody] AnimalFact animalFact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.AnimalFacts.Add(animalFact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnimalFact", new { id = animalFact.Id }, animalFact);
        }

        // DELETE: api/AnimalFacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimalFact([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var animalFact = await _context.AnimalFacts.FindAsync(id);
            if (animalFact == null)
            {
                return NotFound();
            }

            _context.AnimalFacts.Remove(animalFact);
            await _context.SaveChangesAsync();

            return Ok(animalFact);
        }

        private bool AnimalFactExists(int id)
        {
            return _context.AnimalFacts.Any(e => e.Id == id);
        }
    }
}
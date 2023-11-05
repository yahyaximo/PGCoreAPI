using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XsisPG.Data;
using XsisPG.Models;

namespace XsisPG.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
        { 
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<Movie>> Get()
        {
            return await _context.Movies.OrderBy(c=>c.Id).ToListAsync();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var res= await _context.Movies.FindAsync(id);
            return res == null? NotFound() : Ok(res);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new {movie.Id},movie);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id ,Movie movie) 
        {
            if (id != movie.Id) return BadRequest();
            _context.Entry(movie).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id) 
        {
            var res = await _context.Movies.FindAsync(id);
            if (res == null) return NotFound();
            _context.Movies.Remove(res);

            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

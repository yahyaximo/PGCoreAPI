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
        private readonly MovieDbContext _context; //add field

        public MoviesController(MovieDbContext context) //add filed _context
        { 
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<Movie>> Get()
        {
            return await _context.Movies.OrderBy(c=>c.Id).ToListAsync(); //lookup all data (select*) then order data by column id, you can change later eg:create date etc
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var res= await _context.Movies.FindAsync(id); //lookup data
            return res == null? NotFound() : Ok(res); // if found data or not null then return result
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(Movie movie)
        {
            await _context.Movies.AddAsync(movie); //adding data from req to data context
            await _context.SaveChangesAsync(); //save to data context commit to db
            return CreatedAtAction(nameof(GetById), new {movie.Id},movie); //if success return to action GetById passing id from just saved data
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id ,Movie movie) 
        {
            if (id != movie.Id) return BadRequest(); //check existing data first, if not match return Bad Request status codes.
            _context.Entry(movie).State = EntityState.Modified; //change stat entity context to modified 

            await _context.SaveChangesAsync(); //save commit 
            return NoContent();

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id) 
        {
            var res = await _context.Movies.FindAsync(id); //lookup to database first, by id was passing,
            if (res == null) return NotFound(); //condition if lookup not foundor nulll then return NotFound() status  and exit func method
            _context.Movies.Remove(res); //delete and commit using parameter "id"

            await _context.SaveChangesAsync(); //save and commit
            return NoContent(); //return No Content status
        }
    }
}

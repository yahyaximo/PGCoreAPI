using Microsoft.EntityFrameworkCore;
using XsisPG.Models;

namespace XsisPG.Data
{
    public class MovieDbContext : DbContext
    {
        //const dbcontext  option
        public MovieDbContext(DbContextOptions<MovieDbContext> options) 
            :base (options)
        {
        }

        public DbSet <Movie> Movies { get; set; } //db set model into Movies inst
    }

}

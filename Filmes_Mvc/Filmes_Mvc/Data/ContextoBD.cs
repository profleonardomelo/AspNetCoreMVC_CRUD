using Microsoft.EntityFrameworkCore;
using Filmes_Mvc.Models;

namespace Filmes_Mvc.Data
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options)
            : base(options)
        {

        }

        public DbSet<Filme> Filme { get; set; } = default!;
    }
}

using dotnet_magic_reads.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_magic_reads.Data
{
    public class FabContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public FabContext(DbContextOptions<FabContext> options) : base(options) { }
    }
}

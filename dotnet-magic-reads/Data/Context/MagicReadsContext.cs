using dotnet_magic_reads.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_magic_reads.Data.Context
{
    public class MagicReadsContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public MagicReadsContext(DbContextOptions<MagicReadsContext> options) : base(options) { }
    }
}

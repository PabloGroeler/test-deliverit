using Microsoft.EntityFrameworkCore;
using test_deliverit.src.Core.Domain.Entities;

namespace test_deliverit.src.Core.Data.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
        public DbSet<ContaPagarEntity> ContasPagar { get; set; }
    }
}
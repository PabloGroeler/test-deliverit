using Microsoft.EntityFrameworkCore;
using test_deliverit.Core.Domain.Entities;

namespace test_deliverit.Core.Data.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<ContaPagarEntity> TodoItems { get; set; }
    }
}
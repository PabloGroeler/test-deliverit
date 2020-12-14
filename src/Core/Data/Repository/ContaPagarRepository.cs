using Microsoft.EntityFrameworkCore;
using test_deliverit.src.Core.Domain.Entities;
using test_deliverit.src.Core.Domain.Interfaces.Repository;

namespace test_deliverit.src.Core.Data.Repository
{
    public class ContaPagarRepository : BaseRepository<ContaPagarEntity>, IContaPagarRepository
    {
        private DbSet<ContaPagarEntity> _dataset;
        public ContaPagarRepository(Context.Context context) : base(context)
        {
            _dataset = context.Set<ContaPagarEntity>();
        }
    }
}
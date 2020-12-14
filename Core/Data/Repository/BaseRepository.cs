using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test_deliverit.Core.Data.Context;
using test_deliverit.Core.Domain.Entities;

namespace test_deliverit.Core.Domain.Interfaces.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly Context _context;
        private DbSet<T> _dataset;
        public BaseRepository(Context context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result == null)
                    return false;

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }

                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }

            return item;
        }

        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }

        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null)
                    return null;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }

            return item;
        }

    }
}
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private DbContext _dbContext;
        private DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<T>();
        }

        public async void Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async void Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            { 
                _dbSet.Remove(entity);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async void SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}

using SMSDataLayer.Contexts;
using System.Linq.Expressions;

namespace SMSWebAPI.Repos {
    public class BaseRepository<T> : IRepository<T> where T : class {
        protected readonly SchoolContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(SchoolContext context) {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity) {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity) {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public T Get(int id) => _dbSet.Find(id)!;

        public List<T> GetAll() => _dbSet.ToList();

        public void UpdateFields(T entity, params Expression<Func<T, object>>[] updatedProperties) {
            _dbSet.Attach(entity);
            var entry = _context.Entry(entity);
            foreach (var property in updatedProperties) {
                entry.Property(property).IsModified = true;
            }
            _context.SaveChanges();
        }
    }
}

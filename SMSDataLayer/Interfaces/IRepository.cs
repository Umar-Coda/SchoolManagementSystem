using System.Linq.Expressions;

namespace SMSDataLayer.Interfaces {
    public interface IRepository<T> where T : class {
        public void Add(T entity);
        public void Delete(T entity);
        public T Get(int id);
        public List<T> GetAll();
        public void UpdateFields(T entity, params Expression<Func<T, object>>[] updatedProperties);
    }
}

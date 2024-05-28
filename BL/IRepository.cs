using System.Linq.Expressions;

namespace BL;

public interface IRepository<T> where T : class
{
    List<T> GetAll();
    List<T> GetAll(Expression<Func<T, bool>> expression);
    T Get(Expression<Func<T, bool>> expression);
    int Add(T entity);
    int Update(T entity);
    int Remove(T entity);
    
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllByAsync();
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{ // Veritabanına yapılacak temel sorgular burada oluşturulur.
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        // Daha fazla performans için / sorgular direkt veritabanına gitmez / order by gibi işlemler için kullanılır
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}

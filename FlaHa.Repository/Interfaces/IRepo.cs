using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlaHa.Repository.Interfaces
{
    public interface IRepo<T> where T:class 
    {
        Task Add(T Entity);
        Task<T> GetByID(Guid ID);
        void Update(T entity);
        void Delete(T entity);
        Task<IList<T>> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}

using FlaHa.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlaHaa.Data
{
    class Repo<T> : IRepo<T> where T : class,IEntity
    {

        DbSet<T> Table { get; set; }
        public Repo(FlaHaaContext context)
        {
            Table = context.Set<T>();
        }
        public async Task Add(T Entity)
        {
            await Table.AddAsync(Entity);
        }

        public void Delete(T entity)
        {
           Table.Remove(entity);
        }

        public async Task<IList<T>> GetAll()
        {
            return await Table.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByID(Guid ID)
        {
            return await Table.SingleAsync(x=>x.Id == ID);
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }
    }
}

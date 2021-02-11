using System;
using System.Collections.Generic;
using System.Text;
using
using FlaHa.Repository.Interfaces;
using System.Threading.Tasks;

namespace FlaHaa.Data
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class, IEntity
    {
        private readonly FlaHaaContext context;
        public UnitOfWork(FlaHaaContext context)
        {
            this.context = context;
            repo = new Repo<T>(context);
        }
        public IRepo<T> repo { get; }

        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}

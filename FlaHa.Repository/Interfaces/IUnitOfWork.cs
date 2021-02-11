using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlaHa.Repository.Interfaces
{
    public interface IUnitOfWork <T>:IDisposable where T: class 
    {
        IRepo<T> repo { get; }
        Task Commit();
    }
}

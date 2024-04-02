using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Repository.Interface
{
    public interface IUnitOfWork
    {
        //Access to All Functions
        IGenericRepository<T> GenericRepository<T>() where T : class;
        void Save();

    }
}

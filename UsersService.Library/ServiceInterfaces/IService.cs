using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.ServiceInterfaces
{
    public interface IService<T> where T : class
    {
        Task<T> Create(T model);

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(object id);

        Task<T> Update(T model);

        void Delete(object id);

    }
}

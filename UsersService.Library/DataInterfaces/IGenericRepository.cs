using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.DataInterfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task Create(T entity);

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(object id);

        void Update(T entity);

        void Delete(object id);

        T GetByIdentifier(object identifier);

        //IEnumerable<T> GetAllByCategory(object category);

    }
}

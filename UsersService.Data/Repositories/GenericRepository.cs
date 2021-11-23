using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.DataInterfaces;
using UsersService.Library.ErrorHandling;
using UsersService.Library.GlobalInterfaces;

namespace UsersService.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity, new()
    {
        #region Fields
        private readonly UserDbContext _dbContext;
        private DbSet<T> table;
        #endregion

        #region Constructors
        public GenericRepository(UserDbContext dbContext)
        {
            _dbContext = dbContext;
            table = _dbContext.Set<T>();
        }
        #endregion

        #region Methods
        public async Task Create(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                await table.AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Entity was not created in database.", ex);
            }
            
        }

        public void Delete(object id)
        {
            try
            {
                T existingItem = table.Find(id);
                if (existingItem != null)
                {
                    table.Remove(existingItem);
                }
                else
                {
                    throw new Exception("The entity you are trying to remove does not exist.");
                }
               
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Entity was not deleted from database.", ex);
            }
            
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await table.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Entities were not retrieved from database.", ex);
            }
           
        }

        public async Task<T> GetById(object id)
        {
            try
            {
                return await table.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Entity was not retreived from database.", ex);
            }
            
        }

        public T GetByIdentifier(object identifier)
        {
            try
            {
                return table.FirstOrDefault<T>(x => x.Identifier == identifier.ToString());
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Entity was not retreived from database.", ex);
            }
            
        }

        //public IEnumerable<T> GetAllByCategory(object category)
        //{
        //    try
        //    {
        //        return table.Where<T>(x => x.UserCategory == Int32.Parse(category.ToString()));
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new RepositoryException("Entity was not retreived from database.", ex);
        //    }

        //}


        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                table.Attach(entity);
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Entity was not updated in database.", ex);
            }
        }

        

        #endregion

    }
}

using MessagingCRM.Business.Intelligence.Interfaces;
using MessagingCRM.DataStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MessagingCRM.Business.Intelligence
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly MessagingCRMEntities dbContext;

        public GenericRepository(MessagingCRMEntities _dbContext)
        {
            dbContext = _dbContext;
        }

        public TEntity FindById(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity>FindByExpression(Expression<Func<TEntity,bool>> predicate)
        {
            return dbContext.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity) 
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            dbContext.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            dbContext.Set<TEntity>().RemoveRange(entities);
        }

    }
}

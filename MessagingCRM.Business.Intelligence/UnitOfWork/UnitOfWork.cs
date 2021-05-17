using MessagingCRM.Business.Intelligence;
using MessagingCRM.Business.Intelligence.Interfaces.IEntities;
using MessagingCRM.Business.Intelligence.Interfaces.IRepositoryWork;
using MessagingCRM.DataStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingCRM.Business.Intelligence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MessagingCRMEntities _dbContext;

        public UnitOfWork(MessagingCRMEntities dbContext)
        {
            _dbContext = dbContext;
            Members = new MemberRepository(_dbContext);

        }

        public IMemberRepository Members { get; private set; }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}

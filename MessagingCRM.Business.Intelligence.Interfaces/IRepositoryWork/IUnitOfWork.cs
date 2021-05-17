using MessagingCRM.Business.Intelligence.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingCRM.Business.Intelligence.Interfaces.IRepositoryWork
{
    public interface IUnitOfWork: IDisposable
    {
        IMemberRepository Members { get; }
        int SaveChanges();
       
    }
}

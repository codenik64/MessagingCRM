using MessagingCRM.Business.Intelligence.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingCRM.Business.Intelligence.Interfaces.IEntities
{
    public interface IMemberRepository: IGenericRepository<Members>
    {
        IEnumerable<Members> GetAllMembersActive();
    }
}

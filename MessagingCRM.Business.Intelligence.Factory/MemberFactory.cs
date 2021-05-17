using MessagingCRM.Business.Intelligence.Interfaces.IEntities;
using MessagingCRM.DataStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingCRM.Business.Intelligence.Factory
{
    public class MemberFactory
    {
       
        public IMemberRepository CreateMemberRepository()
        {
            using (var dbContext = new MessagingCRMEntities();)
            {
                return new MemberRepository(dbContext);
            }
           
        }
    }
}

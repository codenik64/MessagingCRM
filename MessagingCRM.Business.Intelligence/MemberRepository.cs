using System;
using MessagingCRM.Business.Intelligence.Models.EntityModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagingCRM.DataStore.Entities;
using MessagingCRM.Business.Intelligence.Interfaces.IEntities;



namespace MessagingCRM.Business.Intelligence
{
    public class MemberRepository : GenericRepository<Members>,IMemberRepository
    {

        public MemberRepository(MessagingCRMEntities dbContext) : base(dbContext)
        {
        }

        public MessagingCRMEntities MessagingCRMEntities
        {
            get { return dbContext as MessagingCRMEntities;}
        }

      
        public IEnumerable<Members> GetAllMembersActive()
        {
            return MessagingCRMEntities.Members.Where(x => x.IsActive == true).ToList();
        }

    }
}

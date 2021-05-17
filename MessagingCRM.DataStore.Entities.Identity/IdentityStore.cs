using MessagingCRM.Business.Intelligence.Models.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingCRM.DataStore.Entities.Identity
{
    public static class IdentityStore
    {
        public static void AddIdentityUser(string EmailAddress, string MemberPassword)
        {
            try
            {
                #region Declare Manager
                var IdentityManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MessagingStoreDbContext()));
                #endregion

                var UserAccount = EmailAddress;
                var ExistingUser = IdentityManager.FindByName(UserAccount);
                if (ExistingUser == null)
                {
                    #region instance of AspNetUser
                    var Member = new ApplicationUser();

                    Member.Email = EmailAddress;
                    Member.UserName = EmailAddress;
                    string Password = MemberPassword;
                    #endregion

                    var IdentityUser = IdentityManager.Create(Member, Password);

                }
            }
            catch (Exception identityException)

            {
                var Exception = identityException.Message;
                string CustomError = "the user being  created already exists in the database";
                Exception = CustomError.ToString();


            }
        }
        public static void CreateUserPermission(string UserRole, string GlobalId)
        {

            using (MessagingCRMEntities dbContext = new MessagingCRMEntities())
            {
                AspNetRole permission = new AspNetRole
                {
                    Id = GlobalId.ToString(),
                    Name = UserRole
                };

                dbContext.AspNetRoles.Add(permission);
                dbContext.SaveChanges();
            }
        }
        public static void AddUserToRole(string UserGuid, string RoleGuid)
        {
            using (MessagingCRMEntities dbContext = new MessagingCRMEntities())
            {
                var IdentityManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MessagingStoreDbContext()));
                IdentityManager.AddToRole(UserGuid, RoleGuid);

            }
        }
    }
}

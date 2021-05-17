using MessagingCRM.Business.Intelligence.Models.Identity;
using MessagingCRM.Business.Intelligence.Models.Errors;
using MessagingCRM.Business.Intelligence.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MessagingCRM.DataStore.Entities
{
    public partial class MessagingCRMEntities : DbContext
    {
        public MessagingCRMEntities() : base("name=MessagingCRMEntities")
        {
        }

        public static MessagingCRMEntities Create()
        {
            return new MessagingCRMEntities();
        }

        public DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<Permissions> Permissions { get; set; }

        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<Members> Members { get; set; }


    }
}

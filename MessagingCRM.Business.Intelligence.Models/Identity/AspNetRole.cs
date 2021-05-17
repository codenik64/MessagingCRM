using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingCRM.Business.Intelligence.Models.Identity
{
    public class AspNetRole
    {
       
        public AspNetRole()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
        }

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}

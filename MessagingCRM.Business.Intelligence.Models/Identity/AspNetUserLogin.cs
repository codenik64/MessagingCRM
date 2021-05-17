﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingCRM.Business.Intelligence.Models.Identity
{
    public class AspNetUserLogin
    {
        [Key, Column(Order = 0)]
        public string LoginProvider { get; set; }
        [Key, Column(Order = 1)]
        public string ProviderKey { get; set; }
        [Key, Column(Order = 2)]
        public string UserId { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }
}

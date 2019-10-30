using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class User : IdentityUser
    {       
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Type { get; set; }
        public string UserStatus { get; set; }
        // public int Year { get; set; }

        public virtual ImageUser ImageUser { get; set; }
        public virtual UserCabinet UserCabinet { get; set; }
    }
}

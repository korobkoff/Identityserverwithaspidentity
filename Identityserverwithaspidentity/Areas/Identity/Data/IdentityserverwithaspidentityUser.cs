using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Identityserverwithaspidentity.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the IdentityserverwithaspidentityUser class
    public class IdentityserverwithaspidentityUser : IdentityUser
    {
        [PersonalData]
        public string GivenName { get; set; }

        [PersonalData]
        public string Surname { get; set; }
        //public string FamilyName { get; set; }
    }
}

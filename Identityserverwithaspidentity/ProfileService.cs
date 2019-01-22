using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityServer4.Services;
using IdentityServer4.Models;
//using IdentityAuthority.Models;
using Microsoft.AspNetCore.Identity;
using Identityserverwithaspidentity.Areas.Identity.Data;
using System.Security.Claims;
using IdentityModel;

namespace Identityserverwithaspidentity
{
    public class ProfileService : IProfileService
    {
        protected UserManager<IdentityserverwithaspidentityUser> _userManager;

        public ProfileService(UserManager<IdentityserverwithaspidentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            //>Processing
            var user = await _userManager.GetUserAsync(context.Subject);

            var claims = new List<Claim>
        {
            new Claim(JwtClaimTypes.Email, user.Email),
            new Claim(JwtClaimTypes.GivenName, user.GivenName),
            new Claim(JwtClaimTypes.FamilyName, user.Surname),
            new Claim(JwtClaimTypes.Name, user.GivenName),
            //new Claim(JwtClaimTypes.Role, user.Role),

            //new Claim(JwtClaimTypes.Email, "test@test.com"),
            //new Claim(JwtClaimTypes.GivenName, "Test"),
            //new Claim(JwtClaimTypes.FamilyName, "User"),
            //new Claim(JwtClaimTypes.Name, "Test User"),
            new Claim(JwtClaimTypes.Role, "Standard User"),

        };

            context.IssuedClaims.AddRange(claims);
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            //>Processing
            var user = await _userManager.GetUserAsync(context.Subject);

            //context.IsActive = (user != null) && user.IsActive;
        }
    }
}

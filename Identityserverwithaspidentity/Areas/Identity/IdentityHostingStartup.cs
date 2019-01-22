using System;
using Identityserverwithaspidentity.Areas.Identity.Data;
using Identityserverwithaspidentity.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Identityserverwithaspidentity.Areas.Identity.IdentityHostingStartup))]
namespace Identityserverwithaspidentity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityserverwithaspidentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityserverwithaspidentityContextConnection")));

                //services.AddDefaultIdentity<IdentityserverwithaspidentityUser>()
                    //.AddEntityFrameworkStores<IdentityserverwithaspidentityContext>();
            });
        }
    }
}
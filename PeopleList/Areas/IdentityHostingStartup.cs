using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PeopleIndex.Models;

[assembly: HostingStartup(typeof(PeopleIndex.Areas.Identity.IdentityHostingStartup))]
namespace PeopleIndex.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AppDBContextConnection")));

               // services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
               //     .AddEntityFrameworkStores<AppDBContext>();

            });
        }
    }
}
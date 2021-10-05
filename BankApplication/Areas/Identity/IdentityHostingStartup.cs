using System;
using BankApplication.Areas.Identity.Data;
using BankApplication.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BankApplication.Areas.Identity.IdentityHostingStartup))]
namespace BankApplication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BankDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("BankDbContextConnection")));

                services.AddDefaultIdentity<BankApplicationUser>(
                    options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<BankDbContext>();
            });
        }
    }
}
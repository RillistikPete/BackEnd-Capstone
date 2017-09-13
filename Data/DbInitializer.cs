using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BECaptsone.Data;
using BECaptsone.Models;

namespace Bangazon.Data
{
    public static class DbInitializer
    {
        public async static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var userstore = new UserStore<ApplicationUser>(context);

                if (!context.Roles.Any(r => r.Name == "Doctor"))
                {
                    var role = new IdentityRole { Name = "Doctor", NormalizedName = "Doctor" };
                    await roleStore.CreateAsync(role);
                }
                if (!context.Roles.Any(r => r.Name == "Patient"))
                {
                    var role = new IdentityRole { Name = "Patient", NormalizedName = "Patient" };
                    await roleStore.CreateAsync(role);
                }
            }
        }
    }
}
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.Identity;

namespace Twitter.DataAccess
{
    public  class DatabaseContextSeed
    {
        public static async Task SeedDatabaseAsync(DatabaseContext context, UserManager<ApplicationUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new ApplicationUser { UserName = "admin", Email = "admin@admin.com", EmailConfirmed = true };
                await userManager.CreateAsync(user, "Admin123.?");
            }
            await context.SaveChangesAsync();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using SimpleSklad.Models;

namespace SimpleSklad
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByEmailAsync("tomas.starenko@autmes.cz").Result == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = "tomas.starenko@autmes.cz",
                    Email = "tomas.starenko@autmes.cz"
                };

                IdentityResult result = userManager.CreateAsync(user, "asd123$A").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}

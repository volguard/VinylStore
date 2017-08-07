using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using VinylStore.Models;

[assembly: OwinStartupAttribute(typeof(VinylStore.Startup))]
namespace VinylStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ConfigureRolesAndUsers();
        }

        //W tej metodzie będziemy sprawdzać i tworzyć podstawowe role Użytkownika i Administratora.
        private void ConfigureRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //Na początku tworzę pierwsze konto oraz rolę administratora(tj.: szefa wypożyczalni winyli).
            if (!roleManager.RoleExists("BusinessOwner"))
            {
                //Tworzymy rolę administratora
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "BusinessOwner";
                roleManager.Create(role);

                //Tutaj utworzymy "Boskiego użytkownika", który będzie sprawował niepodzielną władzę nad witryną/aplikacją.
                var User = new ApplicationUser();
                User.UserName = "Paweł Kurzyński";
                User.Email = "mariolajankurz@gmail.com";

                string userPWD = "wryjopoaPKL789456123";

                var chkUser = UserManager.Create(User, userPWD);

                //Przypisz podstawowego użytkownika, zwanego "Boskim", do roli właściciela biznesu
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(User.Id, "BusinessOwner");
                }
            }
            // Tworzenie roli zarządcy   
            if (!roleManager.RoleExists("Manager"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Manager";
                roleManager.Create(role);

            }

            // tworzenie roli pracownika  
            if (!roleManager.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);

            }
        }
    }
}

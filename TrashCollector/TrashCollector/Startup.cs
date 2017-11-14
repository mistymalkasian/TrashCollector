using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TrashCollector.Models;

[assembly: OwinStartupAttribute(typeof(TrashCollector.Startup))]
namespace TrashCollector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoles();
        }

        private void CreateRoles()
        {
            ApplicationDbContext dbcontext = new ApplicationDbContext();


            var RoleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<IdentityRole>(dbcontext));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(dbcontext));

            if (!RoleManager.RoleExists("Admin"))
            {
                var Role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                Role.Name = "Admin";
                RoleManager.Create(Role);

                var User = new ApplicationUser();
                User.UserName = "Misty";
                User.Email = "andrewandmisty@gmail.com";

                string UserPassword = "TrashCollector13";

                var CheckUser = UserManager.Create(User, UserPassword);

                if(CheckUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(User.Id, "Admin");

                }
            }

            if(!RoleManager.RoleExists("Employee"))
            {
                var Role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                Role.Name = "Employee";
                RoleManager.Create(Role);
            }

            if(!RoleManager.RoleExists("Customer"))
            {
                var Role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                Role.Name = "Customer";
                RoleManager.Create(Role);
            }

        }
    }
}

using System.Web.Security;
using Thorgerson.Models;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Thorgerson.AutoInstall), "PostStart")]

namespace Thorgerson
{
    public class AutoInstall
    {
        public static void PostStart()
        {
            using (var ddb = new ThorgersonContext())
            {
                ddb.Database.Initialize(false);
            }

            MembershipUser defaultUser = null;
            if (Membership.GetAllUsers().Count == 0)
            {
                defaultUser = Membership.CreateUser("admin", "password");
            }

            if (!Roles.RoleExists("Admin"))
            {
                Roles.CreateRole("Admin");

                if (defaultUser != null)
                {
                    Roles.AddUserToRole(defaultUser.UserName, "Admin");
                }
            }
        }
    }
}

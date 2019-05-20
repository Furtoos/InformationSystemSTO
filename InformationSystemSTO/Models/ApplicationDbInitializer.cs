using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InformationSystemSTO.Models
{
    public class ApplicationDbInitializer: DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var role1 = new IdentityRole { Name = "User" };
            var role2 = new IdentityRole { Name = "Admin" };

            roleManager.Create(role1);
            roleManager.Create(role2);

            var admin = new ApplicationUser { Email = "furtooss@gmail.com", UserName = "furtooss@gmail.com" };
            string password = "Furtooss";
            var result = userManager.Create(admin, password);
            if(result.Succeeded)
            {
                userManager.AddToRole(admin.Id, role1.Name);
                userManager.AddToRole(admin.Id, role2.Name);
            }
            //Добавление контента
            //Equipment e_1 = new Equipment { Name = "Вулканізатор", Image = "вулканізатор.jpg", Status = true, Prise = 8438, UserName = "furtooss@gmail.com" };
            //Equipment e_2 = new Equipment { Name = "Компресор", Image = "компресор.jpg", Status = false, Prise = 3510, UserName = "furtooss@gmail.com" };
            //Equipment e_3 = new Equipment { Name = "Компресометр", Image = "комресометр.jpg", Status = true, Prise = 929, UserName = "furtooss@gmail.com" };
            //Equipment e_4 = new Equipment { Name = "Спотер", Image = "спотер.jpg", Status = true, Prise = 380, UserName = "furtooss@gmail.com" };

            //context.Equipments.Add(e_1);
            //context.Equipments.Add(e_2);
            //context.Equipments.Add(e_3);
            //context.Equipments.Add(e_4);

            Project p_1 = new Project { Name = "ІнтерБуд", Region = "Київська обл." };
            //p_1.Equipments.Add(e_2);
            //p_1.Equipments.Add(e_3);

            Project p_2 = new Project { Name = "ГлобалІнтер", Region = "Житомирська обл." };
            //p_2.Equipments.Add(e_1);
            //p_2.Equipments.Add(e_4);

            context.Projects.Add(p_1);
            context.Projects.Add(p_2);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
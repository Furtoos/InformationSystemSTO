using InformationSystemSTO.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InformationSystemSTO.Controllers
{
    public static class Data
    {
        public static IEnumerable<Project> GetProjects()
        {
            ApplicationContext context = new ApplicationContext();
            return context.Projects;
        }
    }
    public class SystemController : Controller
    {
        private ApplicationContext db = new ApplicationContext();
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles ="User")]
        public ActionResult Projects()
        {
            IEnumerable<Project> Projects = db.Projects;
            return View(Projects);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult NewEquipment()
        {
            var projects = from project in db.Projects
                           select new SelectListItem { Text = project.Name, Value = project.Id.ToString() };
            ViewData["ProjectId"] = projects;
            return View();
        }
        
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public  ActionResult NewEquipment(Equipment equipment, HttpPostedFileBase uploadImage)
        {
            if (ModelState.IsValid)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(uploadImage.InputStream))
                {
                    imageData = binaryReader.ReadBytes(uploadImage.ContentLength);
                }
                // установка массива байтов
                equipment.Image = imageData;

                db.Equipments.Add(equipment);
                db.SaveChanges();

            }
            return RedirectToAction("Index", "System");
        }

    }
}
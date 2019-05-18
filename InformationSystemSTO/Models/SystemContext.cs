using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InformationSystemSTO.Models
{
    public class SystemContext : DbContext
    {
        public SystemContext() :
            base("InformationSystem")
        { }
        DbSet<Equipment> Equipments { get; set; }
        DbSet<Project> Projects { get; set; }
    }
}
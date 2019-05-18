using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InformationSystemSTO.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Region { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set;}
        public Project()
        {
            Equipments = new List<Equipment>();
        }
    }
}
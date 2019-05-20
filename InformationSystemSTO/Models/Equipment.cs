using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InformationSystemSTO.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public decimal Prise { get; set; }
        public string UserName { get; set; }
        public byte[] Image { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
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
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public decimal Prise { get; set; }
        [Required]
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        [Required]
        public int? UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
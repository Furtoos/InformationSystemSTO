using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace InformationSystemSTO.Models
{
    public class NewEquipmentModel
    {
        public SelectList Projects { get; set; }
        public Equipment Equipment { get; set; }
    }
}
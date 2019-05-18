using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InformationSystemSTO.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Вкажіть почту")]
        [Display(Name ="Почта")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Вкажіть пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
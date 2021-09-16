using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Registeration
    {
        [Required(ErrorMessage = "This field is required")]
        public string email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        public string pass { get; set; } 
        public string order { get; set; } 
    }
}
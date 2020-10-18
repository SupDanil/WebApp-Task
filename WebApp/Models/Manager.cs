using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    // Create Manager model
    public class Manager
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        [Display(Name = "Manager's name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        [Display(Name = "Manager's surname")]
        public string SurName { get; set; }
    }
}

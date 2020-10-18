using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    // Create Customer model
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        [Display(Name = "Name of сustomer")]
        public string CustomerName { get; set; }

        [Display(Name = "Order date")]
        public string OrderDate { get; set; }
    }
}

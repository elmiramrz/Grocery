using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductInventory.Models
{
    public class UserAuthModel
    {
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "The email address is not valid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

            [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        }
    }

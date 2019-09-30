using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketing.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public bool IsSuperAdmin { get; set; } = false;
        public bool IsCustomer { get; set; } = false;
        public bool IsSupportAgent { get; set; } = false;
        public bool IsSupportEngineer { get; set; } = false;
    }
}

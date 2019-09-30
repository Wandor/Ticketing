using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketing.Models
{
    public class SupportEngineer
    {
        public Guid SupportEngineerID { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string EngineerName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string ApplicationUserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketing.Models
{
    public class SupportAgent
    {
        public Guid SupportAgentID { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string SupportAgentName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string ApplicationUserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}

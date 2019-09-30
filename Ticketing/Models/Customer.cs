using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketing.Models
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        [Display(Name = "Customer Name")]
        [StringLength(100)]
        [Required]
        public string CustomerName { get; set; }
        [Display(Name = "Customer Type")]
        public Enum.CustomerType CustomerType { get; set; } 
        [Display(Name = "Phone Number")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Display(Name = "Facebook Username")]
        [StringLength(100)]
        public string FacebookUserName { get; set; }
        [Display(Name = "Twitter Account")]
        [StringLength(100)]
        public string TwitterHandle { get; set; }
    }
}

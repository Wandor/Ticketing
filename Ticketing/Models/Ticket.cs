using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketing.Models
{
    public class Ticket : BaseEntity
    {
        public Ticket()
        {
           TicketStatus = Enum.TicketStatus.Unassigned;
           TicketPriority = Enum.TicketPriority.Low;
            TicketChannel = Enum.TicketChannel.Web;
        }
        public Guid TicketID { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Ticket Title")]
        public string TicketName { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "Ticket Description")]
        public string Description { get; set; }

        [Display(Name = "Customer ID")]
        public Guid CustomerID { get; set; }

        [StringLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [StringLength(20)]
        [Display(Name = "Phone Number")]
        public string PhoneNo { get; set; }
        [Display(Name = "Customer Branch")]
        public string Branch { get; set; }

        [Display(Name = "Status")]
        public Enum.TicketStatus TicketStatus { get; set; }

        [Display(Name = "Ticket Owner ID")]
        public Guid SupportAgentID { get; set; }

        [Display(Name = "Support Engineer ID")]
        public Guid SupportEngineerID { get; set; }

        [Display(Name = "Product")]
        public Enum.Product Product { get; set; }
        [Display(Name = "Ticket Priority")]
        public Enum.TicketPriority TicketPriority { get; set; }
        [Display(Name = "Ticket Channel")]
        public Enum.TicketChannel TicketChannel { get; set; }
    }
}

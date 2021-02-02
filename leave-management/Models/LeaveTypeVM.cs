using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveTypeVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Date Created")]
        public DateTime? DateCreated { get; set; }

        [Display(Name = "Number of days")]
        [Range(1, 25, ErrorMessage = "Please enter a valid number.")]
        [Required]
        public int DefaultDays { get; set; }
    }
}

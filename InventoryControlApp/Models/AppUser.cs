
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InventoryControlApp.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        public string? studentID { get; set; }
    }
}

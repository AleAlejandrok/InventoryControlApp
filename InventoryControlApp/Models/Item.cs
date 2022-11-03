using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace InventoryControlApp.Models
{
    public class Item
    {   

        [Key]
        public string uID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string? description { get; set; }
        [Required]
        public ItemType itemType { get; set; }
        public Zone location { get; set; }
        public bool isAvailable { get; set; }
        
        public string? schoolID { get; set; }
       
       
    }
}

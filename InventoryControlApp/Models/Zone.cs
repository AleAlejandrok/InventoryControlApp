using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace InventoryControlApp.Models
{
    public class Zone
    {
        [Key]
        public String Name { get; set; }
    }
}

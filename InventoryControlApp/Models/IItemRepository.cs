using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace InventoryControlApp.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> Items { get; }
    }
}

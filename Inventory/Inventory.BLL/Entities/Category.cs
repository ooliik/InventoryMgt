using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.BLL.Entities
{
   public class Category
    {
        [Required]
        public string CategoryID { get; set; }
        public string Description { get; set; }
        [Required]
        public string DefaultWarehouse { get; set; }
        [Required]
        public string DefaultWarehousePlace { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}

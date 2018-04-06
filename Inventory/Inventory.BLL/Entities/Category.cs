using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
   public class Category
    {
        public string CategoryID { get; set; }
        public string Description { get; set; }
        public string DefaultWarehouse { get; set; }
        public string DefaultWarehousePlace { get; set; }

        public virtual List<Item> Items { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}

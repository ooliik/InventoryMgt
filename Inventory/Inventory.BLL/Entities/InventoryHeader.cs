using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
   public class InventoryHeader
    {
        public string DocumentID { get; set; }
        public string Description { get; set; }
        public DateTime InventoryDate { get; set; }
        public string WarehouseName { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public virtual ICollection<InventoryLine> InventoryLines { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
    public class Warehouse
    {
        public string WarehouseName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<WarehousePlace> WarehousePlaces { get; set; }
        public virtual ICollection<ReceiveLine> ReceiveLines { get; set; }
        public virtual ICollection<ReleaseLine> ReleaseLines { get; set; }
        public virtual ICollection<WarehouseEntry> WarehouseEntries { get; set; }
        public virtual ICollection<InventoryHeader> InventoryHeaders { get; set; }
        public virtual ICollection<InventoryLine> InventoryLines { get; set; }
    }
}

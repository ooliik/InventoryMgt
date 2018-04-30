using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
    public class StockKeepUnit
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public double QuantityPerUnit { get; set; }

        public virtual ICollection<ItemStockKeepUnit> ItemStockKeepUnits { get; set; }
        public virtual ICollection<ReceiveLine> ReceiveLines { get; set; }
        public virtual ICollection<ReleaseLine> ReleaseLines { get; set; }
        public virtual ICollection<WarehouseEntry> WarehouseEntries { get; set; }
        public virtual ICollection<InventoryLine> InventoryLines { get; set; } 
    }
}

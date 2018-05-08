using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.ViewModels
{
   public class StockKeepUnitVm
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public double QuantityPerUnit { get; set; }

        public virtual IEnumerable<ItemStockKeepUnitVm> ItemStockKeepUnits { get; set; }
        public virtual IEnumerable<ReceiveLineVm> ReceiveLines { get; set; }
        public virtual IEnumerable<ReleaseLineVm> ReleaseLines { get; set; }
        public virtual IEnumerable<WarehouseEntryVm> WarehouseEntries { get; set; }
        public virtual IEnumerable<InventoryLineVm> InventoryLines { get; set; }
    }
}

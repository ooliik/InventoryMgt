using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.ViewModels
{
    public class WarehouseVm
    {
        public string WarehouseName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public virtual IEnumerable<CategoryVm> Categories { get; set; }
        public virtual IEnumerable<WarehousePlaceVm> WarehousePlaces { get; set; }
        public virtual IEnumerable<ReceiveLineVm> ReceiveLines { get; set; }
        public virtual IEnumerable<ReleaseLineVm> ReleaseLines { get; set; }
        public virtual IEnumerable<WarehouseEntryVm> WarehouseEntries { get; set; }
        public virtual IEnumerable<InventoryHeaderVm> InventoryHeaders { get; set; }
        public virtual IEnumerable<InventoryLineVm> InventoryLines { get; set; }
    }
}

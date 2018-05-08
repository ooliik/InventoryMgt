using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.ViewModels
{
    public class ItemVm
    {
        [Required]
        public string ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryID { get; set; }


        public virtual IEnumerable<ItemStockKeepUnitVm> ItemStockKeepUnits { get; set; }
        public virtual IEnumerable<ReceiveLineVm> ReceiveLines { get; set; }
        public virtual IEnumerable<ReleaseLineVm> ReleaseLines { get; set; }
        public virtual IEnumerable<WarehouseEntryVm> WarehouseEntries { get; set; }
        public virtual IEnumerable<InventoryLineVm> InventoryLines { get; set; }
    }
}

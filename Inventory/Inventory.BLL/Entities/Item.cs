using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.BLL.Entities
{
    public class Item
    {
        [Required]
        public string ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<ItemStockKeepUnit> ItemStockKeepUnits { get; set; }
        public virtual ICollection<ReceiveLine> ReceiveLines { get; set; }
        public virtual ICollection<ReleaseLine> ReleaseLines { get; set; }
        public virtual ICollection<WarehouseEntry> WarehouseEntries { get; set; }
        public virtual ICollection<InventoryLine> InventoryLines { get; set; }
    }
}

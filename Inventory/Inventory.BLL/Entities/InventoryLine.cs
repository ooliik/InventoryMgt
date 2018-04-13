using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
   public  class InventoryLine
    {
        public string DocumentID { get; set; }
        public int PositionNumber { get; set; }
        public string ItemID { get; set; }
        public string StockKeepUnit { get; set; }
        public string WarehouseNumber { get; set; }
        public string WarehousePlace { get; set; }
        public double Quantity { get; set; }
        public double CountedQuantity { get; set; }

        public virtual InventoryHeader InventoryHeader { get; set; }
        public virtual Item Item { get; set; }
        public virtual StockKeepUnit StockKeepUnitt { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}

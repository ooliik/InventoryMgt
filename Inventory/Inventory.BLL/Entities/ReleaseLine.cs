using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
    public class ReleaseLine
    {
        public string DocumentID { get; set; }
        public int PositionNumber { get; set; }
        public string ItemID { get; set; }
        public string StockKeepUnit { get; set; }
        public string WarehouseNumber { get; set; }
        public string WarehousePlace { get; set; }
        public double Quantity { get; set; }
        public double ReleaseQuantity { get; set; }
        public double ReleasedQuantity { get; set; }


        public virtual Item Item { get; set; }
        public virtual StockKeepUnit StockKeepUnitt { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ReleaseHeader ReleaseHeader { get; set; }
    }
}

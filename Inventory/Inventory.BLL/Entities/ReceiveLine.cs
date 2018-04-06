using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Inventory.BLL.Entities
{
   public class ReceiveLine
    {
        public string DocumentID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionNumber { get; set; }
        public string ItemID { get; set; }
        public string StockKeepUnit { get; set; }
        public string WarehouseNumber { get; set; }
        public string WarehousePlace { get; set; }
        public double Quantity { get; set; }
        public double ReceiveQuantity { get; set; }
        public double ReceivedQuantity { get; set; }

        public virtual Item Item { get; set; }
        public virtual StockKeepUnit StockKeepUnitt { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ReceiveHeader ReceiveHeader { get; set; }
    }
}

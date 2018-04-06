using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
   public class ItemStockKeepUnit
    {
        public string ItemID { get; set; }
        public string Code { get; set; }
      

        public virtual Item Item { get; set; }
        public virtual StockKeepUnit StockKeepUnit { get; set; }
    }
}

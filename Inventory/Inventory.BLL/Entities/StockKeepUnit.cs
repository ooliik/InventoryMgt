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

        public virtual List<ItemStockKeepUnit> ItemStockKeepUnits { get; set; }
        public virtual List<ReceiveLine> ReceiveLines { get; set; }
        public virtual List<ReleaseLine> ReleaseLines { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Inventory.ViewModels
{
  public class ReceiveLineVm
    {
        public string DocumentID { get; set; }
        public int PositionNumber { get; set; }
        public string ItemID { get; set; }
        public string StockKeepUnit { get; set; }
        public string WarehouseNumber { get; set; }
        public string WarehousePlace { get; set; }
        public double Quantity { get; set; }
        public double ReceiveQuantity { get; set; }
        public double ReceivedQuantity { get; set; }

        
    }
}

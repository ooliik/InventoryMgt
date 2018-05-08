using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.ViewModels
{
   public class InventoryHeaderVm
    {
        public string DocumentID { get; set; }
        public string Description { get; set; }
        public DateTime InventoryDate { get; set; }
        public string WarehouseName { get; set; }

   

        public virtual IEnumerable<InventoryLineVm> InventoryLines { get; set; }
    }
}

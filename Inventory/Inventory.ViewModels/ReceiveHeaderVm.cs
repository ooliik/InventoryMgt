using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.ViewModels
{
   public class ReceiveHeaderVm
    {
        public string DocumentID { get; set; }
        public string Description { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string VendorID { get; set; }

        
        public virtual IEnumerable<ReceiveLineVm> ReceiveLines { get; set; }
    }
}

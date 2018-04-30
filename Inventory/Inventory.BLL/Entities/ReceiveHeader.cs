using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
   public class ReceiveHeader
    {
        public string DocumentID { get; set; }
        public string Description { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string VendorID { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<ReceiveLine> ReceiveLines { get; set; }
    }
}

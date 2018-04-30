using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
    public class Vendor
    {
        public string VendorID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        public virtual ICollection<ReceiveHeader> ReceiveHeaders { get; set; }
        public virtual ICollection<WarehouseEntry> WarehouseEntries { get; set; }
    }
}

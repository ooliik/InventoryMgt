using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.BLL.Entities
{
    public class Customer
    {
        [Required]
        public string CustomerID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<ReleaseHeader> ReleaseHeaders { get; set; }
        public virtual ICollection<WarehouseEntry> WarehouseEntries { get; set; }
    }
}

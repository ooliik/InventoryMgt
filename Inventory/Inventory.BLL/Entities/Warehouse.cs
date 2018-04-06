using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
    public class Warehouse
    {
        public string WarehouseName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public virtual List<Category> Categories { get; set; }
        public virtual List<WarehousePlace> WarehousePlaces { get; set; }
    }
}

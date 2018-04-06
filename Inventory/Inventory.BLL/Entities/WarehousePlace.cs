using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
    public class WarehousePlace
    {
        public string WarehouseName { get; set; }
        public string WarehousePlaceName { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}

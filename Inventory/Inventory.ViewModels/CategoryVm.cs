using Inventory.BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.ViewModels
{
    public class CategoryVm
    {
        [Required]
        public string CategoryID { get; set; }
        public string Description { get; set; }
        [Required]
        public string DefaultWarehouse { get; set; }
        [Required]
        public string DefaultWarehousePlace { get; set; }

        public virtual IEnumerable<ItemVm> Items { get; set; }

     
    }
}

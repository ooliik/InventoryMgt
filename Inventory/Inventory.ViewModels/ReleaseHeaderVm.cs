using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.ViewModels
{
   public class ReleaseHeaderVm
    {
        public string DocumentID { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CustomerID { get; set; }

        
        public virtual IEnumerable<ReleaseLineVm> ReleaseLines { get; set; }
    }
}

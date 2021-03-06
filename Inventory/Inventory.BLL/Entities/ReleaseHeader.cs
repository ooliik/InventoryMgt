﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.BLL.Entities
{
    public class ReleaseHeader
    {
        public string DocumentID { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<ReleaseLine> ReleaseLines { get; set; }
    }
}

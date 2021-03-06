﻿using System.Collections.Generic;

namespace Inventory.ViewModels
{
    public abstract class BaseUserVm
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }

    }
}

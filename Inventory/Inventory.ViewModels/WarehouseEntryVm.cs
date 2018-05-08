﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.ViewModels
{
    public enum EntryType
    {
        Correction,
        Release,
        Receive
    }
    public class WarehouseEntryVm
    {
        public int EntryNumber { get; set; }
        public string CustomerID { get; set; }
        public string VendorID { get; set; }
        public string ItemID { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public string DocumentDescription { get; set; }
        public EntryType EntryType { get; set; }
        public double TotalQuantity { get; set; }
        public double Quantity { get; set; }
        public double QuantityPerUnit { get; set; }
        public string KeepUnit { get; set; }
        public string WarehouseNumber { get; set; }
        public string WarehousePlace { get; set; }
    }
}

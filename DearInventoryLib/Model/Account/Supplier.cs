using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Account
{
    public class Supplier : Account
    {
        public string AccountPayable { get; set; }
    }

    public class SuppliersList
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public List<Supplier> SupplierList { get; set; }
    }
}

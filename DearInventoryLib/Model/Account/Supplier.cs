using System.Collections.Generic;

namespace DearInventoryLib.Model.Account
{
    public class Supplier : Account
    {
        public string AccountPayable { get; set; }
    }

    public class SuppliersList : PagedData
    {
        public List<Supplier> SupplierList { get; set; }
    }
}

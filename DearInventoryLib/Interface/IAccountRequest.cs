using DearInventoryLib.Model.Account;
using System.Collections.Generic;

namespace DearInventoryLib.Interface
{
    interface IAccountRequest
    {
        List<Customer> GetAllCustomers();
        string AddCustomer(Customer Customer);
        bool EditCustomer(Customer Customer);
        List<Supplier> GetAllSuppliers();
        string AddSupplier(Supplier Supplier);
        bool EditSupplier(Supplier Supplier);
    }
}

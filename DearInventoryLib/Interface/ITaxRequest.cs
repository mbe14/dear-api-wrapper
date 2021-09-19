using DearInventoryLib.Model.Tax;
using System.Collections.Generic;

namespace DearInventoryLib.Interface
{
    interface ITaxRequest
    {
        List<Tax> GetAllTaxes(bool IsActive, bool IsTaxForSale, bool IsTaxForPurchase);
        List<Tax> GetTaxForAccount(string Account);
        string AddTax(Tax Tax);
        bool EditTax(Tax Tax);
    }
}

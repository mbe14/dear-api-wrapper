using DearInventoryLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

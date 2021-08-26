using DearInventoryLib.Model.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Interface
{
    interface IPurchaseRequest
    {
        /* Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber */
        List<PurchaseData> GetPurchaseList(string SearchCriteria);

        /* This endpoint is deprecated and supports only Simple Purchases. Please use Advanced Purchase endpoint. */
        SimplePurchase GetSimplePurchase(Guid ID);
    }
}

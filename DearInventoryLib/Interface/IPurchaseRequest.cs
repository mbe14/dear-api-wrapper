using DearInventoryLib.Model.Purchase;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Interface
{
    interface IPurchaseRequest
    {
        /* Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber */
        List<PurchaseData> GetPurchaseList(string SearchCriteria);

        /* This endpoint is deprecated and supports only Simple Purchases. Please use Advanced Purchase endpoint. */
        SimplePurchase GetSimplePurchase(Guid ID);

        PurchaseOrder GetPurchaseOrder(Guid TaskID);

        /* Method will return exception if Order status is not - DRAFT or NOT AVAILABLE */
        string AddPurchaseOrder(PurchaseOrder PurchaseOrder);

        /*
        * This endpoint is not available for Service Purchases.
        * If POST or PUT methods called for Simple Purchase, this purchase will be converted to Advanced Purchase.
        * This endpoint is applicable only for Advanced Purchases and if Use Put Away option set to true in General Settings.
        */

        //GET AND POST FOR Advanced Purchase Stock Received

        /*
         * POST method will return exception if Order status is not - AUTHORISED
         * POST method will return exception if Stock Received status is not - DRAFT or NOT AVAILABLE or PARTIALLY RECEIVED
         * POST method will return exception if Purchase Approach = INVOICE and InvoiceStatus is not - AUTHORISED
         * POST method is used to add only new stock lines.To Authorize Stock Received, Request with empty lines in payload can be done.If duplicated lines found in one payload, one line with sum quantity will be created.If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
         */

        /*
         * PUT method will return exception if Order status is not - AUTHORISED
         * PUT method will return exception if Stock Received status is not - DRAFT or NOT AVAILABLE or PARTIALLY RECEIVED
         * PUT method will return exception if Purchase Approach = INVOICE and InvoiceStatus is not - AUTHORISED
         * PUT method will overwrite data in the related Purchase Task.If duplicated lines found in one payload, one line with sum quantity will be created.If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
         */

    }
}

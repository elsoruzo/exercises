using System;

namespace ReceiptHtmlBuilder.Models
{
    public interface IHeader
    {
        СashierName Cashier { get; set; }
        string StoreName { get; set; }
        DateTime TimeOfPurchase { get; }
    }
}
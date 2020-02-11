namespace ReceiptHtmlBuilder.Models
{
    using System;
    public class Header : IHeader
    {
        public string StoreName { get; set; }
        public СashierName Cashier { get; set; }
        public DateTime TimeOfPurchase { get => DateTime.Now; }
    }
}

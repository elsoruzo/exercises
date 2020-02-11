namespace ReceiptHtmlBuilder.Models
{
    using System.Collections.Generic;
    public interface IReceipt
    {
        IHeader Header { get; set; }
        IList<IBody> Groceries { get; set; }
        IFooter Footer { get; set; }
    }
}
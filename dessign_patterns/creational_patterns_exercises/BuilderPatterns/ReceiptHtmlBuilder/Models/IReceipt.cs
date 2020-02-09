namespace ReceiptHtmlBuilder.Models
{
    using System.Collections.Generic;
    public interface IReceipt
    {
        string Header { get; set; }
        List<Grocery> ContentTable { get; set; }
        string Footer { get; set; }
    }
}
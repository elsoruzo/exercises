namespace ReceiptHtmlBuilder.Models
{
    using System.Collections.Generic;
    public interface IReceiptBuilder
    {
        IReceiptBuilder Init();
        string GetResult();
        IReceiptBuilder BuildHeader(IHeader header);
        IReceiptBuilder BuildBody(IList<IBody> groceries);
        IReceiptBuilder BuildFooter(IFooter footer);
        IReceiptBuilder BuildTemplate();
    }
}

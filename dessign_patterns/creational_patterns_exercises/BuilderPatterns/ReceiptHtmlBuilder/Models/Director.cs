namespace ReceiptHtmlBuilder.Models
{
    using System.Collections.Generic;
    public class Director
    {
        private IReceiptBuilder _builder;

        public IReceiptBuilder Builder
        {
            set { _builder = value; }
        }

        public string BuildHtmlReceipt(IReceipt receipt)///(IHeader header, IList<IBody> body, IFooter footer)
        {
            return _builder.Init()
            .BuildHeader(receipt.Header)
            .BuildBody(receipt.Groceries)
            .BuildFooter(receipt.Footer)
            .BuildTemplate()
            .GetResult();
        }
    }
}

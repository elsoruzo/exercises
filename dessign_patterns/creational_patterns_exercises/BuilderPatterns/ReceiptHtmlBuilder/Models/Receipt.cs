namespace ReceiptHtmlBuilder.Models
{
    using System.Collections.Generic;
    using System.Text;

    public class Receipt : IReceipt
    {

        public IHeader Header { get; set; }
        public IList<IBody> Groceries { get; set; }
        public IFooter Footer { get; set; }

        private string GetGroceriesListHTMLFormatted()
        {
            var result = new StringBuilder(); ;
            foreach (var grocery in Groceries)
            {
                result.Append($"\n {Header.StoreName} " +
                                    $"\n {Header.TimeOfPurchase} " +
                                    $"\n {Header.Cashier} " +
                                    $"\n {grocery.Price.ToString()} " +
                                    $"\n {grocery.Amounth.ToString()} " +
                                    $"\n {grocery.Total.ToString()} "+
                                    $"\n {Footer.Total} " +
                                    $"\n {Footer.ReceiptNumber} " +
                                    $"\n {Footer.FooterMessage} ");
            }

            return result.ToString();
        }

        public override string ToString()
        {
            return GetGroceriesListHTMLFormatted();
        }
    }
}
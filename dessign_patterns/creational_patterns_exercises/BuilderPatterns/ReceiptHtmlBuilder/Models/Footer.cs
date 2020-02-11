namespace ReceiptHtmlBuilder.Models
{
    public class Footer : IFooter
    {
        public double Total { get; set; }
        public int ReceiptNumber { get; set; }
        public string FooterMessage { get; set; }
    }
}
namespace ReceiptHtmlBuilder.Models
{
    public interface IFooter
    {
        string FooterMessage { get; set; }
        int ReceiptNumber { get; set; }
        double Total { get; set; }
    }
}
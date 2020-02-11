namespace ReceiptHtmlBuilder.Models
{
    public interface IBody
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        int Amounth { get; set; }
        double Total { get; }

    }
}
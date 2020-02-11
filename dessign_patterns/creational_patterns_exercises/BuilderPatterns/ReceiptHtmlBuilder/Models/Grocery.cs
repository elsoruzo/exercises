namespace ReceiptHtmlBuilder.Models
{
    public class Grocery : IBody
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amounth { get; set; }
        public double Total { get => Price * Amounth; }
    }
}

namespace ReceiptHtmlBuilder.Models
{
    using System.Collections.Generic;
    public class Receipt : IReceipt
    {

        public string Header { get; set; }
        public List<Grocery> ContentTable { get; set; }
        public string Footer { get; set; }

        public override string ToString()
        {
            return  $" \n {Header} \n {ContentTable} \n {Footer} ";
        }
    }
}
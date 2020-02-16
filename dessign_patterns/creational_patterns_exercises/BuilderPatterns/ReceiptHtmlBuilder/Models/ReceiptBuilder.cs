namespace ReceiptHtmlBuilder.Models
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class ReceiptBuilder : IReceiptBuilder
    {
        private IReceipt _receipt = null;
        private List<IBody> _groceries = null;
        private StringBuilder _header = null;
        private StringBuilder _body = null;
        private StringBuilder _footer = null;
        private string _template;
        private readonly string _openDivHtml = "<div>";
        private readonly string _closeDivHtml = "</div>";

        public ReceiptBuilder()
        {
            Init();
        }

        public IReceiptBuilder Init()
        {
            _receipt = new Receipt();
            _groceries = new List<IBody>();
            _header = new StringBuilder();
            _body = new StringBuilder();
            _footer = new StringBuilder();
            return this;
        }

        private void CheckReceiptIsNotNull()
        {
            if (_receipt == null)
                throw new Exception("Receipt shoud not be null");
        }

        private void CheckCanBuildHeader()
        {
            if (_header.Length > 0)
                throw new Exception("Header already exists");
        }

        private void CheckCanBuildFooter()
        {
            if (_footer.Length > 0)
                throw new Exception("Footer already exists");
        }
        private void CheckTemplateEmpty()
        {
            if (_template.Length == 0)
                throw new Exception("The template should not be empty");
        }


        public IReceiptBuilder BuildHeader(IHeader header)
        {
            CheckReceiptIsNotNull();
            CheckCanBuildHeader();
            _header.Append(_openDivHtml).Append(" Store Name : ").Append(header.StoreName).Append(_closeDivHtml)
                .Append(_openDivHtml).Append(" The time of purchase: ").Append(header.TimeOfPurchase).Append(_closeDivHtml)
                .Append(_openDivHtml).Append(" Cashier Name is ")
                                    .Append(header.Cashier.FirstName).Append(" ")
                                    .Append(header.Cashier.MiddleName).Append(" ")
                                    .Append(header.Cashier.LastName).Append(_closeDivHtml);

            return this;
        }

        public IReceiptBuilder BuildBody(IList<IBody> groceries)
        {
            CheckReceiptIsNotNull();
            _groceries.AddRange(groceries);

            var openRowHtml = "<tr>";
            var closeRowHtml = "</tr>";
            var openColumnHtml = "<th>";
            var closeColumnHtml = "</th>";
            var bodyTitles = new StringBuilder()
                                    .Append(openRowHtml)
                                        .Append(openColumnHtml).Append("ID").Append(closeColumnHtml)
                                        .Append(openColumnHtml).Append("PRODUCT NAME").Append(closeColumnHtml)
                                 .Append(openColumnHtml).Append("PRICE").Append(closeColumnHtml)
                                 .Append(openColumnHtml).Append("AMOUNTH").Append(closeColumnHtml)
                                 .Append(openColumnHtml).Append("TOTAL").Append(closeColumnHtml)
                                 .Append(closeRowHtml).ToString();

            _body.Append(bodyTitles);
            foreach (var grocery in groceries)
            {
                _body.Append(openRowHtml)
                                 .Append(openColumnHtml).Append(grocery.Id).Append(closeColumnHtml)
                                 .Append(openColumnHtml).Append(grocery.Name).Append(closeColumnHtml)
                                 .Append(openColumnHtml).Append(grocery.Price).Append(closeColumnHtml)
                                 .Append(openColumnHtml).Append(grocery.Amounth).Append(closeColumnHtml)
                                 .Append(openColumnHtml).Append(grocery.Total).Append(closeColumnHtml)
                      .Append(closeRowHtml);
            }

            _receipt.Groceries = groceries;
            return this;
        }

        public IReceiptBuilder BuildFooter(IFooter footer)
        {
            CheckReceiptIsNotNull();
            CheckCanBuildFooter();
            footer.Total = _groceries.Sum(x => x.Total);

            _footer.Append(_openDivHtml).Append(" Total:  ").Append(footer.Total).Append(_closeDivHtml)
                   .Append(_openDivHtml).Append(" Receipt Number: ").Append(footer.ReceiptNumber).Append(_closeDivHtml)
                   .Append(_openDivHtml).Append(footer.FooterMessage).Append(_closeDivHtml);

            return this;
        }

        private void CheckHeaderIsFilled()
        {
            if (_header.Length == 0)
                throw new Exception("The header should be filled before the template is built");
        }
        private void CheckBodyIsFilled()
        {
            if (_body.Length == 0)
                throw new Exception("The body should be filled before the template is built");
        }
        private void CheckFooterIsFilled()
        {
            if (_footer.Length == 0)
                throw new Exception("The footer should be filled before the template is built");
        }

        public IReceiptBuilder BuildTemplate()
        {
            CheckReceiptIsNotNull();
            CheckHeaderIsFilled();
            CheckBodyIsFilled();
            CheckFooterIsFilled();
            var openHtmlTag = $"<!DOCTYPE html><html> ";
            var closeHtmlTag = $"</html>";
            var headHtml = $"<head><meta charset = \"UTF-8\"><title> RECEIPT </title></head>";
            var openHtmlBodyTag = $"<body>";
            var closeHtmlBodyTag = $"<body>";
            var headerHtml = string.Format("{0}" + _header + "{1}", "<header>", "</header>");
            var footerHtml = string.Format("{0}" + _footer + "{1}", "<footer>", "</footer>");
            var tableHtml = string.Format("{0}" + _body + "{1}", "<table>", "</table>");
            var mainHtml = string.Format("{0}" + tableHtml + "{1}", "<main>", "</main>");
            //TODO Why do you use StringBuilder?
            _template = new StringBuilder()
                .Append(openHtmlTag)
                .Append(headHtml)
                .Append(openHtmlBodyTag)
                .Append(headerHtml)
                .Append(mainHtml)
                .Append(footerHtml)
                .Append(closeHtmlBodyTag)
                .Append(closeHtmlTag)
                .ToString();
            return this;
        }
        public string GetResult()
        {
            CheckTemplateEmpty();
            return _template;
        }

    }
}

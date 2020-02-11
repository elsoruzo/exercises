namespace ReceiptHtmlBuilder.Models
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    public class ReceiptBuilder : IReceiptBuilder
    {
        private IReceipt _receipt = null;
        private List<IBody> _groceries = null;
        private StringBuilder _header = null;
        private StringBuilder _body = null;
        private StringBuilder _footer = null;
        private string _template;

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
            _header.Append($"<div>{header.StoreName}</div>" +
                            $"<div>{header.TimeOfPurchase.ToString()}</div>" +
                            $"<div>{header.Cashier.FirstName + " " + header.Cashier.MiddleName + " " + header.Cashier.LastName }</div>");

            return this;
        }

        public IReceiptBuilder BuildBody(IList<IBody> groceries)
        {
            _groceries.AddRange(groceries);
            CheckReceiptIsNotNull();
            foreach (var grocery in groceries)
            {
                _body.Append($"<tr>" +
                                    $"<th> {grocery.Id.ToString()} </th>" +
                                    $"<th> {grocery.Name} </th>" +
                                    $"<th> {grocery.Price.ToString()} </th> " +
                                    $"<th> {grocery.Amounth.ToString()} </th> " +
                                    $"<th> {grocery.Total.ToString()}  </th> " +
                            $"</tr>");
            }

            _receipt.Groceries = groceries;
            return this;
        }
        private double CaculateTotal()
        {
            double result = 0;
            foreach (var grocery in _groceries)
            {
                result += grocery.Total;
            }
            return result;

        }
        public IReceiptBuilder BuildFooter(IFooter footer)
        {
            CheckReceiptIsNotNull();
            CheckCanBuildFooter();
            footer.Total = CaculateTotal();
            _footer.Append($"<div>Total: ${footer.Total.ToString()}</div>" +
                           $"<div>Receipt Number: {footer.ReceiptNumber.ToString()}</div>" +
                           $"<div>{footer.FooterMessage}</div>");

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
            _template = new StringBuilder($"<!DOCTYPE html>" +
                    $" <html lang = \"en\">" +
                    $"<head>" +
                    $"<meta charset = \"utf-8\">" +
                    $"<title> title </title>" +
                    $"<link rel = \"stylesheet\" href = \"style.css\">" +
                    $"<script src = \"script.js\"></script>" +
                    $"</head>" +
                    $"<body>" +
                    $"{_header}" +
                    $"<table>" +
                    $"{_body}" +
                    $"</table>" +
                    $"{_footer}" +
                    $"</body></html>").ToString();
            return this;
        }

        public string GetResult()
        {
            CheckTemplateEmpty();
            return _template;
        }

    }
}

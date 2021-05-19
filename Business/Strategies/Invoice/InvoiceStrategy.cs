using Strategy_Pattern.Business.Models;
using Strategy_Pattern.Strategies.Invoice;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.Business.Strategies.Invoice
{
    public abstract class InvoiceStrategy: IInvoiceStrategy
    {
        public abstract void Generate(Order order);

        public string GenerateTextInvoice(Order order)
        {
            var invoice = $"INVOICE DATE: {DateTimeOffset.Now}{Environment.NewLine}";

            invoice += $"ID|NAME|PRICE|QUANTITY{Environment.NewLine}";

            foreach (var item in order.LineItems)
            {
                invoice += $"{item.Key.Id}|{item.Key.Name}|{item.Key.Price}|{item.Value}{Environment.NewLine}";
            }
            invoice += Environment.NewLine + Environment.NewLine;

            var tax = order.GetTax();
            var total = order.TotalPrice + tax;

            invoice += $"TAX TOTAL: {tax}{Environment.NewLine}";
            invoice += $"TOTAL: {total}{Environment.NewLine}";

            return invoice;
        }
    }
}

using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Strategy_Pattern.Business.Strategies.Invoice
{
    public class FileInvoiceStrategy: InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            using (var stream = new StreamWriter($"D:\\Sample{Guid.NewGuid()}.txt"))
            {
                stream.Write(GenerateTextInvoice(order));

                stream.Flush();
            }
        }
    }
}

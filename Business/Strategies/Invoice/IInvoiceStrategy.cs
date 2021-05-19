using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.Strategies.Invoice
{
    public interface IInvoiceStrategy
    {
        public void Generate(Order order);
    }
}

using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTax(Order order);
    }
}

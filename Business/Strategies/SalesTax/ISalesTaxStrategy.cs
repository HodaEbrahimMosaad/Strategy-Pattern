using Strategy_Pattern.Business.Models;
using Strategy_Pattern.Business.Strategies.SalesTax.SalesTaxForItemTypeInSweden;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTax(Order order);
    }
}

using Strategy_Pattern.Business.Models;
using Strategy_Pattern_First_Look.Business.Strategies.SalesTax.SalesTaxForItemTypeInSweden;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        //public IItemTaxStrategy ItemTaxStrategy { get; set; }

        public decimal GetTax(Order order);
    }
}

using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax.SalesTaxForItemTypeInSweden
{
    public interface IItemTaxStrategy
    {
        public decimal GetTaxForItem(KeyValuePair<Item, int> item);
    }
}

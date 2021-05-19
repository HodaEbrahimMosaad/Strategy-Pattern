using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax.SalesTaxForItemTypeInSweden
{
    public class LiteratureItemTaxStrategy : IItemTaxStrategy
    {
        public decimal GetTaxForItem(KeyValuePair<Item, int> item)
        {
            return (item.Key.Price * 0.08m) * item.Value;
        }
    }
}

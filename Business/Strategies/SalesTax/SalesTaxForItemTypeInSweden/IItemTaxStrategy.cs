using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.Business.Strategies.SalesTax.SalesTaxForItemTypeInSweden
{
    public interface IItemTaxStrategy
    {
        public decimal GetTaxForItem(Item item);
    }
}

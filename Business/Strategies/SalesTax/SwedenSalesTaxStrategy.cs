using Strategy_Pattern.Business.Models;
using Strategy_Pattern_First_Look.Business.Strategies.SalesTax.SalesTaxForItemTypeInSweden;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    class SwedenSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            decimal totalTax = 0m;

            foreach (KeyValuePair<Item,int> item in order.LineItems)
            {
                totalTax += item.Key.GetTax() * item.Value;

                #region switch (item.Key.ItemType)
                /*
                switch (item.Key.ItemType)
                {
                    case ItemType.Food:
                        totalTax += (item.Key.Price * 0.06m) * item.Value;
                        break;

                    case ItemType.Literature:
                        totalTax += (item.Key.Price * 0.08m) * item.Value;
                        break;

                    case ItemType.Service:
                    case ItemType.Hardware:
                        totalTax += (item.Key.Price * 0.25m) * item.Value;
                        break;
                }
                */
                #endregion
            }

            return totalTax;

        }
    }
}

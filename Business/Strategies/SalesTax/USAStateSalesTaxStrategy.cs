using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    class USAStateSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            switch (order.ShippingDetails.DestinationState.ToLowerInvariant())
            {
                case "la": return order.TotalPrice * 0.095m;
                case "ny": return order.TotalPrice * 0.04m;
                case "nyc": return order.TotalPrice * 0.045m;
                default: return 0m;
            }
        }
    }
}

using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    class SwedenSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
            
            if (destination == order.ShippingDetails.OriginCountry.ToLowerInvariant())
            {
                return order.TotalPrice * 0.25m;
            }
            return 0;
        }
    }
}

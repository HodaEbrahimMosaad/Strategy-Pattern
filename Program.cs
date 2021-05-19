﻿using Strategy_Pattern.Business.Models;
using Strategy_Pattern_First_Look.Business.Strategies.SalesTax;
using Strategy_Pattern_First_Look.Business.Strategies.SalesTax.SalesTaxForItemTypeInSweden;
using System;
using System.Collections.Generic;

namespace Strategy_Pattern_First_Look
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                ShippingDetails = new ShippingDetails
                {
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                }
            };
            //Dictionary<Item, int> item1 = new Dictionary<Item, int>(new Item() { "CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1};
            var item1 = new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature );
            item1.ItemTaxStrategy = new LiteratureItemTaxStrategy();
            order.LineItems.Add(item1, 1);


            var item2 = new Item("CONSULTING", "Building a website", 100m, ItemType.Service);
            item2.ItemTaxStrategy = new ServiceAndHardwareItemTaxStrategy();
            order.LineItems.Add(item2, 1);

            Console.WriteLine(order.GetTax(new SwedenSalesTaxStrategy()));
        }
    }
}

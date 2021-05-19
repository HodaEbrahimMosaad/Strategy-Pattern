using Newtonsoft.Json;
using Strategy_Pattern.Business.Models;
using Strategy_Pattern.Strategies.Invoice;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Strategy_Pattern.Business.Strategies.Invoice
{
    public class PrintOnDemandInvoiceStrategy: IInvoiceStrategy
    {
        public void Generate(Order order)
        {
            using (var client = new HttpClient())
            {
                var content = JsonConvert.SerializeObject(order);

                client.BaseAddress = new Uri("https://blablabla.com");

                client.PostAsync("/print-on-demand", new StringContent(content));
            }
        }
    }
}

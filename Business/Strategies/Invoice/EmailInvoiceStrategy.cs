using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Strategy_Pattern.Business.Strategies.Invoice
{
    public class EmailInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            using (SmtpClient client = new SmtpClient("smtp.sendgrid.net", 587))
            {
                NetworkCredential credentials = new NetworkCredential("hoda.mosaad.1997@outlook.com", "allahakbar1997");
                client.Credentials = credentials;

                MailMessage mail = new MailMessage("hodamosaad0@gmail.com", "hodamosaad0@gmail.com")
                {
                    Subject = "We've created an invoice for your order",
                    Body = GenerateTextInvoice(order)
                };

                client.Send(mail);
            }
        }
    }
}

using Strategy_Pattern.Business.Strategies.SalesTax;
using Strategy_Pattern.Strategies.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy_Pattern.Business.Models
{
    public class Order
    {
        public Dictionary<Item, int> LineItems { get; } = new Dictionary<Item, int>();

        public IList<Payment> SelectedPayments { get; } = new List<Payment>();

        public IList<Payment> FinalizedPayments { get; } = new List<Payment>();

        public decimal AmountDue => TotalPrice - FinalizedPayments.Sum(payment => payment.Amount);

        public decimal TotalPrice => LineItems.Sum(item => item.Key.Price * item.Value);

        public ShippingStatus ShippingStatus { get; set; } = ShippingStatus.WaitingForPayment;

        public ShippingDetails ShippingDetails { get; set; }

        public ISalesTaxStrategy SalesTaxStrategy { get; set; }
        public IInvoiceStrategy InvoiceStrategy { get; set; }

        public decimal GetTax(ISalesTaxStrategy passedStrategy = default)
        {
            var strategy = passedStrategy ?? SalesTaxStrategy;
            if (strategy == null)
            {
                return 0m;
            }

            return strategy.GetTax(this);
        }

        public void FinalizeOrder()
        {
            if (SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Invoice) &&
               AmountDue > 0 &&
               ShippingStatus == ShippingStatus.WaitingForPayment)
            {
                InvoiceStrategy.Generate(this);

                ShippingStatus = ShippingStatus.ReadyForShippment;
            }
            else if (AmountDue > 0)
            {
                throw new Exception("Unable to finalize order");
            }
        }
    }
}
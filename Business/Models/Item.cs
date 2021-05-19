using Strategy_Pattern.Business.Strategies.SalesTax.SalesTaxForItemTypeInSweden;

namespace Strategy_Pattern.Business.Models
{
    public class Item
    {
        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public ItemType ItemType { get; set; }

        public IItemTaxStrategy ItemTaxStrategy { get; set; }


        public Item(string id, string name, decimal price, ItemType type)
        {
            Id = id;
            Name = name;
            Price = price;
            ItemType = type;
        }


        public decimal GetTax()
        {
            return ItemTaxStrategy.GetTaxForItem(this);
        }

        
    }
}
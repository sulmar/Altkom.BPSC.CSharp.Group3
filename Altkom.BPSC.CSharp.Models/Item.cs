namespace Altkom.BPSC.CSharp.Models
{
    public abstract class Item : Base
    {
        protected Item(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

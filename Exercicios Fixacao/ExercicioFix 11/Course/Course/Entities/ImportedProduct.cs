using System.Globalization;
namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; } //Taxa da alfândega

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            double totalPrice = Price + CustomFee; 
            return totalPrice;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}

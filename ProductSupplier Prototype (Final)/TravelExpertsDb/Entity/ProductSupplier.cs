namespace TravelExpertsDb
{
    public class ProductSupplier
    {
        public int ProductSupplierId { get; set; }
        public int SupplierId { get; set; }
        public string SupName { get; set; }

        public override string ToString()
        {
            return SupName;
        }

        public string SupplierIdToString()
        {
            return SupplierId.ToString();
        }
    }
}
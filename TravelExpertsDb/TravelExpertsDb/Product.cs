using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TravelExpertsDb
{
    public class Product
    {
        public int ProductId { get; set; } // make sure we validate the id properly
        public string ProdName { get; set; }

        public override string ToString()
        {
            return ProdName;
        }

        public List<ProductSupplier> GetSuppliers()
        {
            return ProductDB.GetProductSuppliers( this );
        }

        public List<ProductSupplier> GetRemainingSuppliers()
        {
            return ProductDB.GetSuppliersNotInProduct(this);
        }
    }
}

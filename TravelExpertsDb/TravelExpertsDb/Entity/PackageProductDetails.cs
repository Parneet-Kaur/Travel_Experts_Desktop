using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDb
{
    public class PackageProductDetails
    {
        public int PackageID { get; set; }
        public string PkgName { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }
        public string prodName { get; set; }
        public string supplierName { get; set; }
        public int ProductId { get; set; }
    }
}

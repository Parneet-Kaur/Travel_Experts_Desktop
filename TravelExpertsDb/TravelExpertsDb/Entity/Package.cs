using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDb.Entity
{
   public class Package
    {

        public int PackageId { get; set; }
        public string PkgName { get; set; }


        public DateTime PkgStartDate { get; set; }

        public DateTime PkgEndDate { get; set; }

        public string PkgDesc { get; set; }

        public double PkgBasePrice { get; set; }

        public double PkgAgencyCommission { get; set; }

    }
}

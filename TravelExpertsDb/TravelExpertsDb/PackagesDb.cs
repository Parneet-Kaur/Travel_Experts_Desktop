using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDb
{
    public static class PackagesDb
    {
        public static Packages getPackage(int packageID) {

            SqlConnection con=DataAccess.getConnection();
            string query = "SELECT * FROM  packages where "+
                            "packageID=@packageID";
            SqlCommand com = new SqlCommand(query,con);
            com.Parameters.Add("@packageID", SqlDbType.Int).Value = packageID;
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read()) {
                Packages package = new Packages();
                package.PkgName = reader[].ToString();
                package.PkgStartDate=
            }


        }
    }
}

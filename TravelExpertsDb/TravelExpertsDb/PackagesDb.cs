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
            Packages package = new Packages();
            SqlConnection con=DataAccess.getConnection();
            string query = "SELECT * FROM  packages where "+
                            "packageID=@packageID";
            SqlCommand com = new SqlCommand(query,con);
            com.Parameters.Add("@packageID", SqlDbType.Int).Value = packageID;
            con.Open();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                
                package.PackageID = Convert.ToInt16(reader[0].ToString());
                package.PkgName = reader[1].ToString();
                bool flagOD = (reader["pkgStartDate"] != System.DBNull.Value);
                     if (flagOD)
                        {
                           package.PkgStartDate = (DateTime)(reader["pkgStartDate"]);
                        }
                      else
                         {
                        package.PkgStartDate = DateTime.MinValue;
                        }
                flagOD = (reader["pkgEndDate"] != System.DBNull.Value);
                      if (flagOD)
                        {
                        package.PkgEndDate = (DateTime)(reader["pkgEndDate"]);
                        }
                        else
                         {
                        package.PkgEndDate= DateTime.MinValue;
                        }
                flagOD = (reader["pkgDesc"] != System.DBNull.Value);
                if (flagOD)
                {
                    package.PkgDesc = (reader["pkgDesc"]).ToString();
                }
                else
                {
                    package.PkgDesc ="";
                }

                package.PkgBasePrice =Convert.ToDecimal(reader["pkgBasePrice"].ToString());
                flagOD = (reader["PkgAgencyCommission"] != System.DBNull.Value);
                if (flagOD)
                {
                    package.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"].ToString());
                }
                else
                {
                    package.PkgAgencyCommission =0 ;
                }
        

            }
            con.Close();
            return package;
        }/// end of method to get packages


        //to  get all packageID's  from DB
        public static DataTable getPackageIDs() {
            SqlConnection con = DataAccess.getConnection();
            string query = "select PackageId,PkgName from Packages";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            con.Close();
            return dt;
        }

        //to update packages in the database
        public static int updatePackage(Packages package)
        {

            SqlConnection con = DataAccess.getConnection();
            string query = "UPDATE packages SET " +
                 " pkgStartDate = @PkgStartDate, " +
                 " pkgEndDate = @PkgEndDate," +
                 " pkgDesc = @PkgDesc," +
                 " pkgBasePrice =  @PkgBasePrice," +
                 " pkgAgencyCommission =  @PkgAgencyCommission " +
                 "where " +
                 " packageID = @PackageID";


            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@pkgEndDate", package.PkgEndDate);
            com.Parameters.AddWithValue("@pkgStartDate", package.PkgStartDate);
            com.Parameters.AddWithValue("@pkgDesc", package.PkgDesc);
            com.Parameters.AddWithValue("@pkgBasePrice", package.PkgBasePrice);
            com.Parameters.AddWithValue("@pkgAgencyCommission", package.PkgAgencyCommission);
            com.Parameters.AddWithValue("@packageID", package.PackageID);

            con.Open();
            int success = com.ExecuteNonQuery();


            con.Close();
            return success;

        }// end of function

    }
}

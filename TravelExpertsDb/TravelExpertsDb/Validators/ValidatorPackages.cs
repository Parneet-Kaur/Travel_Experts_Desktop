using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDb
{
    class ValidatorPackages
    {
        public static bool validateDates(DateTime startDate,DateTime endDate) {

            if (startDate<endDate) {
                return true;
            }
            else {
                return false;
            }
        }


        public static bool isEmpty(MaterialSingleLineTextField tb) {
            if (tb.Text=="") {

                return true;
            }
            else {
                return false;

            }
        }

        public  static decimal isDecimal(MaterialSingleLineTextField tb) {
            decimal price;
            decimal cost=0;  
            if (decimal.TryParse(tb.Text,  out price)) {
                cost = price;
                return cost;
            }
            else {
                MessageBox.Show("Price needs to be a decimal value.");
                return price;
            }
        }
    }
}

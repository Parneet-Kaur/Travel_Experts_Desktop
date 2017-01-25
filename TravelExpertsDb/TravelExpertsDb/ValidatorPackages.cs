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
        public static bool IsValidData(MaterialSingleLineTextField tb,
            DateTime start,DateTime end, MaterialSingleLineTextField basePrice) {

            //if (!isEmpty(tb) && IsDateProvided(start) && IsDateProvided(end) && validateDates(start, end) && isEmpty(basePrice))
            //{
            //    return true;
            //}
            //else {
            //    return false;
            //}
            if (!isEmpty(tb)) {
                if (IsDateProvided(start))
                {
                    if (IsDateProvided(end))
                    {
                        if (validateDates(start, end))
                        {
                            if (!isEmpty(basePrice))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {

                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else {
                    return false;
                }
            }
            else {

                return false;
            }
            
        }


      
            
        public static bool validateDates(DateTime startDate,DateTime endDate) {

            if (startDate<endDate) {

                return true;
            }
            else {
                MessageBox.Show("End date must be greater than start date.");
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

        public static bool IsDateProvided(DateTime date){
            if (date.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please provide a date in future.");
                return false;
            }
            else {
                return true;
            }
         }
    }//end of class
}

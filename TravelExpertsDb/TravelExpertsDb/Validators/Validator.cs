using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDb
{
    public static class Validator
    {
        /*************Author: Parneet Dec2016****/

            // validators are used to clarify the data in the desktop app....
           

        public static bool isEmpty(TextBox tb) {

            if (tb.Text=="") {
                return true;
            }
            else {
                return false;
            }
        }
        public static bool userName(TextBox tb)
        {
            var regex = "^[0-9]+$";//data can only have numbers in it. Validates AgentID from agents table
            var match = Regex.Match(tb.Text, regex, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Password(TextBox tb)
        {
            //^ ([2 - 9]\\d{ 2})\\d{ 3}
            //-\\d{ 4}$
            var regex = "^[0-9]+$";//data can only have numbers in it.
            var match = Regex.Match(tb.Text, regex, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsPresent(MaterialSingleLineTextField tb)
        {
            if(tb.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Expected " + tb.Tag + " is required", "Input Error");
                tb.Focus();
                tb.BackColor = Color.FromArgb(255, 127, 80);
                return false;
            }
        }


        public static bool IsPresent(RichTextBox tb)
        {
            if (tb.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Expected " + tb.Tag + " is required", "Input Error");
                tb.Focus();
                tb.BackColor = Color.FromArgb(255, 127, 80);
                return false;
            }
        }


        public static bool IsWithinRange(MaterialSingleLineTextField tb, decimal min, decimal max) //test to see if it is in range  min and max
        {

            decimal value = Convert.ToDecimal(tb.Text); //integer value otherwise produces an error 
            if (value >= min && value <= max) //if between the max/min values return true
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " Must be in range from " + min + " & " + max, "Input Error");
                tb.Focus();
                return false;
            }
        }



        public static bool IsInteger(TextBox tb)
        {
            int num; //auxillary for trying to parse
            if (Int32.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Expected" + tb.Tag + " has to be a whole number", "Input Error");
                tb.Focus();
                return false;
            }
        }


        public static bool ValidDate(DateTime StartDate, DateTime EndDate)
        {
            if (EndDate.Date < StartDate.Date)
            {
                MessageBox.Show("End date has to be after the start date.", "Input Error");
                return false;
            }
            else
                return true;
        }



        public static bool IsDecimal(MaterialSingleLineTextField tb)
        {


            decimal num;
            if (decimal.TryParse(tb.Text.Replace("$", ""), out num))
            {
                return true;
            }
            else
            {

                MessageBox.Show(tb.Tag + " has to be a number!", "Input Error");
                tb.Focus();
                tb.BackColor = Color.FromArgb(255, 127, 80);
                return false;
            }

        }//isDecimal


        public static bool CommissionBasePriceCheck(decimal BasePrice, decimal Commission)
        {
            if (BasePrice < Commission)
            {
                MessageBox.Show("Base price has to be greater than the commission.", "Input Error");
                return false;
            }
            else
                return true;
        }

    }//Class Validator
}

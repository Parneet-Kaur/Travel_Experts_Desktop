using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
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
                return false;
            }
        }


        public static bool IsWithinRange(TextBox tb, decimal min, decimal max) //test to see if it is in range  min and max
        {

            int value = Convert.ToInt32(tb.Text); //integer value otherwise produces an error 
            if (value >= min && value <= max) //if between the max/min values return true
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " Must be in range from " + min + " & " + max);
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


    }
}

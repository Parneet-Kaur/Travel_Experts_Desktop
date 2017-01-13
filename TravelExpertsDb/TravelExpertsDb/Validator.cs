using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDb
{
    class Validator
    {
        /*************Author: Parneet Dec2016****/

        public bool isEmpty(TextBox tb) {

            if (tb.Text=="") {
                return true;
            }
            else {
                return false;
            }
        }
        public bool username(TextBox tb)
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

        public bool password(TextBox tb)
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    class Validator
    {
        public static bool IsInteger(string Value)
        {
            try
            {
                int n = int.Parse(Value);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static bool IsPresen(string Value)
        {
            if (Value == null)
            {
                return false;
            }
            return true;
        }
    }
}

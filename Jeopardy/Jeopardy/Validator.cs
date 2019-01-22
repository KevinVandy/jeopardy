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
        public static bool IsBoolean(bool Value)
        {
            try
            {
                bool flag;
                Boolean.TryParse(Value.ToString(), out flag);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
        }
        public static bool IsInteger(string Value)
        {
            try
            {
                int n = int.Parse(Value);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Convert to Integer Failure");
                return false;
            }
        }
        public static bool IsPresent(string Value)
        {
            try
            {
                if(Value == null)
                {
                    throw ArgumentNullException("you cannot pass a null value!");
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "No data present");
                return false;
            }

        }

        private static Exception ArgumentNullException(string v)
        {
            throw new ArgumentNullException();
        }

        public static bool AreFourChoices(List<Choice>  Value)
        {
            try
            {
                if (Value.Count != 4)
                {
                    throw WrongCountException("wrong");
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
            
        }

        private static Exception WrongCountException(string v)
        {
            throw new Exception("Wrong number of choices");
        }
    }
}

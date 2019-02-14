using System;
using System.Windows.Forms;

namespace Jeopardy
{
    public class ValidateTypes
    {
        public static bool IsBoolean(bool Value)
        {
            try
            {
                bool flag;
                Boolean.TryParse(Value.ToString(), out flag);
                return true;
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Convert to Integer Failure");
                return false;
            }
        }
        public static bool IsPresent(string Value)
        {
            try
            {
                if (Value == null)
                {
                    throw new CustomExceptions.ArgumentNullException();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No data present");
                return false;
            }

        }




    }
}

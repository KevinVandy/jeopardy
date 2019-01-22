using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    class ValidateData
    {
        public static bool AreFourChoices(List<Choice> Value)
        {
            try
            {
                if (Value.Count != 4)
                {
                    throw CustomExceptions.WrongCountException("wrong");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }

        }

        
    }
}

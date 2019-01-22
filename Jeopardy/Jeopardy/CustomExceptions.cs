using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    public class CustomExceptions
    {
        public static Exception ArgumentNullException(string v)
        {
            throw new ArgumentNullException();
        }

        public static Exception WrongCountException(string v)
        {
            throw new Exception("Wrong number of choices");
        }
    }
}

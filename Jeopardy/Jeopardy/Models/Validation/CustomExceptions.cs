using System;
using System.Windows.Forms;

namespace Jeopardy
{
    public class CustomExceptions
    {
        //MARK: Data Exceptions

        [Serializable]
        public class ArgumentNullException : Exception
        {
            public ArgumentNullException()
            {

            }

            public ArgumentNullException(string s)
            {
                MessageBox.Show(s);
            }
        }

        [Serializable]
        public class WrongCountException : Exception
        {
            public WrongCountException()
            {

            }

            public WrongCountException(string s)
            {
                MessageBox.Show(s);
            }
        }

        [Serializable]
        public class IdNotFoundException : Exception
        {
            public IdNotFoundException()
            {

            }

            public IdNotFoundException(string s)
            {
                MessageBox.Show(s);
            }

        }

        [Serializable]
        public class StringTooLongException : Exception
        {
            public StringTooLongException()
            {

            }

            public StringTooLongException(string s)
            {
                MessageBox.Show(s);
            }
        }
    }


}

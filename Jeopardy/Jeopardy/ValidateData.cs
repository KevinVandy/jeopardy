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

        //MARK: Validate Game properties
        public static bool ValidateGameName(string gameName)
        {
            if (gameName.Length > 0 && gameName.Length < 30)
            {
                return true;
            }
            return false; //TODO throw custom exception
        }

        public static bool ValidateDefaultTimeLimit(TimeSpan defaultTimeLimit)
        {
            TimeSpan[] validTimeLimitsInSeconds = new TimeSpan[] { new TimeSpan(0, 0, 30), new TimeSpan(0, 1, 0), new TimeSpan(0, 2, 0), new TimeSpan(0, 3, 0) };
            if (validTimeLimitsInSeconds.Contains(defaultTimeLimit))
            {
                return true;
            }
            return false; //TODO throw custom exception
        }

        //MARK: Validate Category properties
        public static bool ValidateCategoryTitle(string title)
        {
            if (title.Length > 0 && title.Length < 128)
            {
                return true;
            }
            return false; //TODO throw custom exception
        }

        public static bool ValidateCategorySubtitle(string subtitle)
        {
            if (subtitle.Length > 0 && subtitle.Length < 128)
            {
                return true;
            }
            return false; //TODO throw custom exception
        }

        //MARK: Validate Question properties


        //MARK: Validate Choice properties


        //MARK: Validate Team properties



    }
}

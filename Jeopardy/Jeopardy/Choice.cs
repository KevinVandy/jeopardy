using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    class Choice
    {
        private int Id { get; set; }
        private int QuestionID { get; set; }
        private string Text { get; set; }

        public Choice createChoice(int aID, int aQuestionID, string aText)
        {
            Choice aChoice = new Choice();
            aChoice.Id = aID;
            aChoice.QuestionID = aQuestionID;
            aChoice.Text = aText;
            return aChoice;
        }
    }
}

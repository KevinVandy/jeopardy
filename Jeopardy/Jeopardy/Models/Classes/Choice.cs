using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    public class Choice
    {
        private int? id;
        private int questionId;
        private int index;
        private string text;

        public Choice() { }

        public Choice(int? id, int questionId, int index, string text)
        {
            this.id = id;
            this.questionId = questionId;
            this.index = index;
            this.text = text;
        }

        public int? Id
        {
            get => id;
            set => id = value;
        }

        public int QuestionId
        {
            get => questionId;
            set => questionId = value;
        }

        public int Index
        {
            get => index;
            set
            {
                if (ValidateData.ValidateChoiceIndex(value))
                {
                    index = value;
                }
            }
        }

        public string Text
        {
            get
            {
                if (ValidateData.ValidateChoiceText(text))
                {
                    return text;
                }
                else
                {
                    return " ";
                }
            }
            set
            {
                if (ValidateData.ValidateChoiceText(value))
                {
                    text = value.Trim();
                }
                else
                {
                    text = " ";
                }
            }
        }
    }
}

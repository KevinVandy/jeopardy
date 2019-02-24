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
            Id = id;
            QuestionId = questionId;
            Index = index;
            Text = text;
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
                if (Validation.ValidateChoiceIndex(value))
                {
                    index = value;
                }
            }
        }

        public string Text
        {
            get
            {
                if (Validation.ValidateChoiceText(text))
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
                if (Validation.ValidateChoiceText(value))
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

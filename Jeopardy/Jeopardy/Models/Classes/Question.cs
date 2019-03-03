using System.Collections.Generic;

namespace Jeopardy
{
    public class Question
    {
        private int? id;
        private int categoryId;
        private string questionText;
        private string type;
        private string answer;
        private int weight;
        private List<Choice> choices;
        private bool dailyDouble;       //NOT in database, determined at runtime
        private string state;           //NOT in database, determined at runtime

        public Question() { }

        public Question(int? id, int categoryId, string questionText, string type, string answer, int weight, string state, List<Choice> choices = null, bool dailyDouble = false)
        {
            Id = id;
            CategoryId = categoryId;
            QuestionText = questionText;
            Type = type;
            Answer = answer;
            Weight = weight;
            State = state;
            Choices = choices;
            DailyDouble = dailyDouble;
        }

        public int? Id
        {
            get => id;
            set => id = value;
        }

        public int CategoryId
        {
            get => categoryId;
            set => categoryId = value;
        }

        public string QuestionText
        {
            get => questionText;
            set
            {
                if (Validation.ValidateQuestionText(value))
                {
                    questionText = value.Trim();
                }
                else
                {
                    questionText = " ";
                }
            }
        }

        public string Type
        {
            get => type;
            set
            {
                if (Validation.ValidateQuestionType(value))
                {
                    type = value.Trim();
                }
                else
                {
                    type = "fb"; //fill in the blank
                }
            }
        }

        public string Answer
        {
            get => answer;
            set
            {
                if (Validation.ValidateQuestionAnswer(value))
                {
                    answer = value.Trim();
                }
                else
                {
                    answer = " ";
                }
            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                if (Validation.ValidateQuestionWeight(value))
                {
                    weight = value;
                }
                else
                {
                    weight = 0;
                }
            }
        }

        public List<Choice> Choices
        {
            get => choices;
            set => choices = value;
        }

        public bool DailyDouble
        {
            get => dailyDouble;
            set => dailyDouble = value;
        }

        public string State
        {
            get => state;
            set => state = value;
        }

        public void DetermineState()
        {
            if (QuestionText.Trim() == "")
            {
                State = "no question";
            }
            else if (QuestionText.Length >= 1 && Answer.Trim() == "")
            {
                State = "no answer";
            }
            else if (QuestionText.Length >= 1 && Type == "mc") //if is multiple choice
            {
                if (Choices ==  null || Choices.Count < 4 
                 || Choices[0].Text.Trim() == "" || Choices[1].Text.Trim() == "" || Choices[2].Text.Trim() == "" || Choices[3].Text.Trim() == "")
                {
                    State = "no choices";
                }
                else
                {
                    State = "done";
                }
            }
            else
            {
                State = "done";
            }
        }

        public void CreateBlankQuestion(int weight)
        {
            ResetQuestionToDefaults();
            Weight = weight;
        }

        public void ResetQuestionToDefaults()
        {
            Type = "fb";
            QuestionText = " ";
            Answer = " ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.id = id;
            this.categoryId = categoryId;
            this.questionText = questionText;
            this.type = type;
            this.answer = answer;
            this.weight = weight;
            this.state = state;
            this.choices = choices;
            this.dailyDouble = dailyDouble;
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
                if (ValidateData.ValidateQuestionText(value))
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
                if (ValidateData.ValidateQuestionType(value))
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
                if (ValidateData.ValidateQuestionAnswer(value))
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
                if (ValidateData.ValidateQuestionWeight(value))
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

        public void DetermineState(string mode)
        {
            if (mode == "edit")
            {
                if (QuestionText == "" || QuestionText == " ")
                {
                    State = "no question";
                }
                else if (QuestionText.Length > 1 && (Answer == "" || Answer == " "))
                {
                    State = "no answer";
                }
                else if (QuestionText.Length > 1 && Type == "mc") //if is multiple choice
                {
                    if (Choices[0].Text == " " || Choices[1].Text == " " || Choices[2].Text == " " || Choices[3].Text == " "
                        || Choices[0].Text == "" || Choices[1].Text == "" || Choices[2].Text == "" || Choices[3].Text == "")
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
            else if (mode == "play")
            {
                //TODO - Ryan, you can add your own code here
                //Added this code to return a value for testing feel free to delete
                State = "pass";
            }
        }

        public Question CreateBlankQuestion(int? categoryId, int weight)
        {
            CategoryId = (int)categoryId;
            ResetQuestionToDefaults();
            Weight = weight;
            Id = DB_Insert.InsertQuestion(this);

            return this;
        }

        public void ResetQuestionToDefaults()
        {
            Type = "fb";
            QuestionText = " ";
            Answer = " ";
        }
    }
}

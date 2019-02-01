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
        private bool dailyDouble;
        private string state;

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
                    questionText = value;
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
                    type = value;
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
                    answer = value;
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
            if(mode == "edit")
            {
                if (this.QuestionText.Length <= 1 || this.QuestionText == " ")
                {
                    this.State = "no question";
                }
                else if (this.QuestionText.Length > 1 && (this.Answer.Length <= 1 || this.Answer == " "))
                {
                    this.State = "no answer";
                }
                else if (this.QuestionText.Length > 1 && this.Type == "mc") //if is multiple choice
                {
                    foreach (Choice ch in this.Choices)
                    {
                        if (ch.Text.Length <= 1 || ch.Text == " ")
                        {
                            this.State = "no choices";
                        }
                        else
                        {
                            this.State = "done";
                        }
                    }
                }
                else
                {
                    this.State = "done";
                }
            }
            else if(mode == "play")
            {
                //TODO - Ryan, you can add your own code here
            }
        }
    }
}

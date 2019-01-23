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

        public Question() { }

        public Question(int? id, int categoryId, string questionText, string type, string answer, int weight, List<Choice> choices = null, bool dailyDouble = false)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.questionText = questionText;
            this.type = type;
            this.answer = answer;
            this.weight = weight;
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
    }
}

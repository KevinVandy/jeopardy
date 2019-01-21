using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    class Question
    {
        private int id;
        private int categoryId;
        private string type;
        private string answer;
        private int weight;
        private List<Choice> choices;
        private bool dailyDouble;

        public Question() { }

        public Question(int id, int categoryId, string type, string answer, int weight, List<Choice> choices = null, bool dailyDouble = false)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.type = type;
            this.answer = answer;
            this.weight = weight;
            this.choices = choices;
            this.dailyDouble = dailyDouble;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int CategoryId
        {
            get => categoryId;
            set => categoryId = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }
        
        public string Answer
        {
            get => answer;
            set => answer = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
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

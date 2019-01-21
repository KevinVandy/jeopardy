using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    class Choice
    {
        private int id;
        private int questionId;
        private string text;

        public Choice() { }

        public Choice(int id, int questionId, string text)
        {
            this.id = id;
            this.questionId = questionId;
            this.text = text;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int QuestionId
        {
            get => questionId;
            set => questionId = value;
        }

        public string Text
        {
            get => text;
            set => text = value;
        }
    }
}

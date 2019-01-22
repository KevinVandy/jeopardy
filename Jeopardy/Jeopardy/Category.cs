using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    class Category
    {
        private int id;
        private int gameId;
        private string title;
        private string subtitle;
        private List<Question> questions;

        public Category() { }

        public Category(int id, int gameId, string title, string subtitle, List<Question> questions)
        {
            this.id = id;
            this.gameId = gameId;
            this.title = title;
            this.subtitle = subtitle;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int GameId
        {
            get => gameId;
            set => gameId = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Subtitle
        {
            get => subtitle;
            set => subtitle = value;
        }

        public List<Question> Questions
        {
            get => questions;
            set => questions = value;
        }

        public void createCategory()
        {

        }

        public void editCategory()
        {

        }

        public void deleteCategory()
        {

        }
    }
}

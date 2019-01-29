using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    public class Category
    {
        private int? id;
        private int gameId;
        private int index;
        private string title;
        private string subtitle;
        private List<Question> questions;

        public Category() { }

        public Category(int? id, int gameId, int index, string title, string subtitle, List<Question> questions)
        {
            this.id = id;
            this.gameId = gameId;
            this.index = index;
            this.title = title;
            this.subtitle = subtitle;
            this.questions = questions;
        }

        public int? Id
        {
            get => id;
            set => id = value;
        }

        public int GameId
        {
            get => gameId;
            set => gameId = value;
        }

        public int Index
        {
            get => index;
            set => index = value;
        }

        public string Title
        {
            get => title;
            set
            {
                if (ValidateData.ValidateCategoryTitle(value))
                {
                    title = value;
                }
            }
        }

        public string Subtitle
        {
            get => subtitle;
            set
            {
                if (ValidateData.ValidateCategorySubtitle(value))
                {
                    subtitle = value;
                }
            }
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

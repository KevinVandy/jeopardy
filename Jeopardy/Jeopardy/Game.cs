using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public class Game
    {
        private int? id;
        private string gameName;
        private TimeSpan questionTimeLimit;
        private int numCategories;
        private int numQuestionsPerCategory;
        private List<Category> categories;

        public Game() { }

        public Game(int? id, string gameName, TimeSpan questionTimeLimit, int numCategories, int numQuestionsPerCategory, List<Category> categories)
        {
            this.id = id;
            this.gameName = gameName;
            this.questionTimeLimit = questionTimeLimit;
            this.numCategories = numCategories;
            this.numQuestionsPerCategory = numQuestionsPerCategory;
            this.categories = categories;
        }

        public int? Id
        {
            get => id;
            set => id = value;
        }

        public string GameName
        {
            get => gameName;
            set
            {
                if (ValidateData.ValidateGameName(value))
                {
                    gameName = value;
                }
            }
        }

        public TimeSpan QuestionTimeLimit
        {
            get => questionTimeLimit;
            set
            {
                if (ValidateData.ValidateGameTimeLimit(value))
                {
                    questionTimeLimit = value;
                }
            }
        }

        public int NumCategories
        {
            get => numCategories;
            set => numCategories = value;
        }

        public int NumQuestionsPerCategory
        {
            get => numQuestionsPerCategory;
            set => numQuestionsPerCategory = value;
        }

        public List<Category> Categories
        {
            get => categories;
            set => categories = value;
        }

        //MARK: Public Methods
        public Game CreateGame(string gameName, int numCategories, int numQuestionsPerCat, int questionTimeLimitIndex)
        {
            TimeSpan questionTimeLimit = new TimeSpan();
            if (questionTimeLimitIndex == 0)
            {
                questionTimeLimit = new TimeSpan(0, 0, 30);
            }
            else if (questionTimeLimitIndex == 1)
            {
                questionTimeLimit = new TimeSpan(0, 1, 0);
            }
            else if (questionTimeLimitIndex == 2)
            {
                questionTimeLimit = new TimeSpan(0, 2, 0);
            }
            else if (questionTimeLimitIndex == 3)
            {
                questionTimeLimit = new TimeSpan(0, 3, 0);
            }

            this.gameName = gameName;
            this.numCategories = numCategories;
            this.numQuestionsPerCategory = numQuestionsPerCat;
            this.questionTimeLimit = questionTimeLimit;

            if (ValidateData.ValidateGameName(gameName))
            {
                this.Id = DB_Insert.InsertGame(this);
            }
            else
            {
                MessageBox.Show("Invalid Game Name");
            }
            return this;
        }

       

        public void EditGame()
        {

        }

        public void DeleteGame()
        {

        }

        public void ImportGame()
        {

        }

        public void ExportGame()
        {

        }

        public void PlayGame()
        {

        }
    }
}

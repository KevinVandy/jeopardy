using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void CreateGame()
        {

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

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

        public Game(int? id, string gameName, TimeSpan questionTimeLimit, int numCategories, int numQuestionsPerCategory, List<Category> categories = null)
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
                else
                {
                    gameName = "Untitled Game";
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
                else
                {
                    questionTimeLimit = new TimeSpan(0,1,0);
                }
            }
        }

        public int NumCategories
        {
            get => numCategories;
            set
            {
                if(ValidateData.ValidateNumCategories(value))
                {
                    numCategories = value;
                }
                else
                {
                    numCategories = 5;
                }
            }
        }

        public int NumQuestionsPerCategory
        {
            get => numQuestionsPerCategory;
            set
            {
                if(ValidateData.ValidateNumQuestionsPerCategory(value))
                {
                    numQuestionsPerCategory = value;
                }
                else
                {
                    numQuestionsPerCategory = 6;
                }
            }
        }

        public List<Category> Categories
        {
            get => categories;
            set => categories = value;
        }

        //MARK: Public Methods
        public Game CreateBlankGame(string gameName, int numCategories, int numQuestionsPerCat, int questionTimeLimitIndex)
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
                questionTimeLimit = new TimeSpan(0, 1, 30);
            }
            else if (questionTimeLimitIndex == 3)
            {
                questionTimeLimit = new TimeSpan(0, 2, 0);
            }
            else if (questionTimeLimitIndex == 4)
            {
                questionTimeLimit = new TimeSpan(0, 3, 0);
            }

            this.gameName = gameName;
            this.numCategories = numCategories;
            this.numQuestionsPerCategory = numQuestionsPerCat;
            this.questionTimeLimit = questionTimeLimit;

            //insert the game
            if (ValidateData.ValidateGameName(gameName))
            {
                this.id = DB_Insert.InsertGame(this);
            }
            else
            {
                MessageBox.Show("Invalid Game Name");
            }
            
            //insert blank categories, also will insert blank questions for each category
            this.Categories = new List<Category>(new Category[this.numCategories]);
            for (int index = 0; index < this.numCategories; index++)
            {
                this.Categories[index] = new Category();
                this.Categories[index] = Categories[index].CreateBlankCategory(this.Id, this.numQuestionsPerCategory, index);
            }
            
            return this;
        }
        
    }
}

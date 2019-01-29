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

            //insert the game
            if (ValidateData.ValidateGameName(gameName))
            {
                this.id = DB_Insert.InsertGame(this);
            }
            else
            {
                MessageBox.Show("Invalid Game Name");
            }

            this.Categories = new List<Category>(new Category[this.numCategories]);

            //insert blank categories
            for (int i = 0; i < this.numCategories; i++)
            {
                this.Categories[i] = new Category();
                this.Categories[i].GameId = (int)this.id;
                this.Categories[i].Index = i;
                this.Categories[i].Title = "Category " + (i + 1);
                this.Categories[i].Subtitle = " ";
                this.Categories[i].Id = DB_Insert.InsertCategory(this.Categories[i]);

                this.Categories[i].Questions = new List<Question>(new Question[this.numQuestionsPerCategory]);

                //insert blank questions
                for(int j = 0; j < this.numQuestionsPerCategory; j++)
                {
                    this.Categories[i].Questions[j] = new Question();
                    this.Categories[i].Questions[j].CategoryId = (int)this.Categories[i].Id;
                    this.Categories[i].Questions[j].Type = "fb";
                    this.Categories[i].Questions[j].QuestionText = " ";
                    this.Categories[i].Questions[j].Answer = " ";
                    this.Categories[i].Questions[j].Weight = (j + 1) * 100;
                    this.Categories[i].Questions[j].Id = DB_Insert.InsertQuestion(this.Categories[i].Questions[j]);
                }
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

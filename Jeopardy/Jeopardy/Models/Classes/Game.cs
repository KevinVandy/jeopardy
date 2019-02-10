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
                    gameName = value.Trim();
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
                    questionTimeLimit = new TimeSpan(0, 1, 0);
                }
            }
        }

        public int NumCategories
        {
            get => numCategories;
            set
            {
                if (ValidateData.ValidateNumCategories(value))
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
                if (ValidateData.ValidateNumQuestionsPerCategory(value))
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
        public void CreateBlankGame(string gameName, int numCategories, int numQuestionsPerCat, int questionTimeLimitIndex)
        {
            TimeSpan questionTimeLimit = new TimeSpan();
            if (questionTimeLimitIndex == 0)
            {
                QuestionTimeLimit = new TimeSpan(0, 0, 30);
            }
            else if (questionTimeLimitIndex == 1)
            {
                QuestionTimeLimit = new TimeSpan(0, 1, 0);
            }
            else if (questionTimeLimitIndex == 2)
            {
                QuestionTimeLimit = new TimeSpan(0, 1, 30);
            }
            else if (questionTimeLimitIndex == 3)
            {
                QuestionTimeLimit = new TimeSpan(0, 2, 0);
            }
            else if (questionTimeLimitIndex == 4)
            {
                QuestionTimeLimit = new TimeSpan(0, 3, 0);
            }

            GameName = gameName;
            NumCategories = numCategories;
            NumQuestionsPerCategory = numQuestionsPerCat;
            QuestionTimeLimit = questionTimeLimit;
            
            //create blank categories, also will create blank questions for each category
            Categories = new List<Category>(new Category[NumCategories]);
            for (int i = 0; i < NumCategories; i++)
            {
                Categories[i] = new Category();
                Categories[i].CreateBlankCategory(NumQuestionsPerCategory, i);
            }
        }

        public void ResetGameToDefaults()
        {
            GameName = " ";
            QuestionTimeLimit = new TimeSpan(0, 1, 0);
        }

        public void GenerateDailyDouble()
        {
            foreach (Category c in Categories)
            {
                foreach (Question q in c.Questions)
                {
                    q.DailyDouble = false;
                }
            }
            Random rnd = new Random();
            int rndCategory = rnd.Next(0, NumCategories);
            int rndQuestion = rnd.Next(0, NumQuestionsPerCategory);

            Categories[rndCategory].Questions[rndQuestion].DailyDouble = true;
        }

    }
}

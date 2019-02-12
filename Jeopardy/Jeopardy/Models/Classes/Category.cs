﻿using System.Collections.Generic;

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
            set
            {
                if (ValidateData.ValidateCategoryIndex(value))
                {
                    index = value;
                }
                else
                {
                    index = 0;
                }
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if (ValidateData.ValidateCategoryTitle(value))
                {
                    title = value.Trim();
                }
                else
                {
                    title = " ";
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
                    subtitle = value.Trim();
                }
                else
                {
                    subtitle = " ";
                }
            }
        }

        public List<Question> Questions
        {
            get => questions;
            set => questions = value;
        }

        public void CreateBlankCategory(int numQuestionsPerCat, int index)
        {
            Index = index;
            ResetCategoryToDefaults();

            //create blank questions
            Questions = new List<Question>(new Question[numQuestionsPerCat]);
            for (int i = 0; i < numQuestionsPerCat; i++)
            {
                Questions[i] = new Question();
                Questions[i].CreateBlankQuestion((i + 1) * 100);
            }
        }

        public void ResetCategoryToDefaults()
        {
            Title = "Category " + (index + 1).ToString();
            Subtitle = " ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmCreateGame : Form
    {
        private Game game;
        private List<Button> categoryButtons;
        private List<Button> questionButtons;
        int numCategories;
        int numQuestionsPerCat;

        public frmCreateGame()
        {
            InitializeComponent();

            game = new Game();
            numCategories = (int)nudNumCategories.Value;
            numQuestionsPerCat = (int)nudNumQuestionCategory.Value;

            categoryButtons = new List<Button>();
            questionButtons = new List<Button>();
        }

        private void frmCreateGame_Load(object sender, EventArgs e)
        {
            DisplayNumberQuesions();

            DrawCategoryGrid();
            DrawQuestionGrid();

        }



        private void nudNumCategories_ValueChanged(object sender, EventArgs e)
        {
            DisplayNumberQuesions();
            numCategories = (int)nudNumCategories.Value;
            DrawCategoryGrid();
            DrawQuestionGrid();
        }

        private void nudNumQuestionCategory_ValueChanged(object sender, EventArgs e)
        {
            DisplayNumberQuesions();
            numQuestionsPerCat = (int)nudNumQuestionCategory.Value;
            DrawQuestionGrid();
        }

        private void DisplayNumberQuesions()
        {
            lblNumberQuestions.Text = CalcNumberOfQuestions().ToString();
        }

        private int CalcNumberOfQuestions()
        {
            return (int)nudNumCategories.Value * (int)nudNumQuestionCategory.Value;
        }

        private void DrawCategoryGrid()
        {
            gbxCategories.Controls.Clear();

            if(categoryButtons != null)
            {
                categoryButtons.Clear();
            }
            
            int gbxWidth = gbxCategories.Width;
            int gbxHeight = gbxCategories.Height;

            int buttonWidth = (gbxWidth - 80) / (numCategories);
            int buttonHeight = 80;
            
            int start_x = 30;
            int start_y = 30;

            for (int x = 0; x < 1; x++)
            {
                for(int y = 0; y < numCategories; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * buttonHeight);
                    tmpButton.Left = start_y + ((y * buttonWidth) + (y * 5));
                    tmpButton.Width = buttonWidth;
                    tmpButton.Height = buttonHeight;
                    tmpButton.Text = "Category " + (y + 1).ToString();
                    tmpButton.Click += CategoryButton_Click;
                    categoryButtons.Add(tmpButton);
                }
            }

            foreach(Button b in categoryButtons)
            {
                gbxCategories.Controls.Add(b);
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            frmEditCategory editCategoryForm = new frmEditCategory();
            editCategoryForm.ShowDialog();
        }

        private void DrawQuestionGrid()
        {
            gbxQuestions.Controls.Clear();

            if (questionButtons != null)
            {
                questionButtons.Clear();
            }

            int gbxWidth = gbxQuestions.Width;
            int gbxHeight = gbxQuestions.Height;

            int buttonWidth = (gbxWidth - 80) / (numCategories);
            int buttonHeight = 100;

            int start_x = 30;
            int start_y = 30;

            for (int x = 0; x < numQuestionsPerCat; x++)
            {
                for (int y = 0; y < numCategories; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + ((x * buttonHeight) + (x * 5));
                    tmpButton.Left = start_y + ((y * buttonWidth) + (y * 5));
                    tmpButton.Width = buttonWidth;
                    tmpButton.Height = buttonHeight;
                    tmpButton.Text = "Category " + (y + 1).ToString() + "\n" + "Question " + (x + 1).ToString();
                    tmpButton.Click += QuestionButton_Click;
                    questionButtons.Add(tmpButton);
                }
            }

            foreach (Button b in questionButtons)
            {
                gbxQuestions.Controls.Add(b);
            }
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            frmEditQuestion editQuestionForm = new frmEditQuestion();
            editQuestionForm.ShowDialog();
        }
    }
}

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
    public partial class frmEditGame : Form
    {
        private Game game = new Game();
        private List<Button> categoryButtons = new List<Button>();
        private List<Button> questionButtons = new List<Button>();

        public frmEditGame(Game theGame)
        {
            game = theGame;

            if (game.NumCategories == 0)
            {
                game.NumCategories = 6;
            }

            if (game.NumQuestionsPerCategory == 0)
            {
                game.NumQuestionsPerCategory = 5;
            }

            InitializeComponent();
        }

        private void frmCreateGame_Load(object sender, EventArgs e)
        {
            DisplayNumberQuesions();

            CreateCategoryGrid();
            CreateQuestionGrid();

            txtGameName.Text = game.GameName;
            nudNumCategories.Value = game.NumCategories;
            nudNumQuestionCategory.Value = game.NumQuestionsPerCategory;
            if(game.QuestionTimeLimit == new TimeSpan(0, 0, 30))
            {
                cboQuestionTimeLimit.SelectedIndex = 0;
            }
            else if (game.QuestionTimeLimit == new TimeSpan(0, 1, 0))
            {
                cboQuestionTimeLimit.SelectedIndex = 1;
            }
            else if (game.QuestionTimeLimit == new TimeSpan(0, 2, 0))
            {
                cboQuestionTimeLimit.SelectedIndex = 2;
            }
            else if (game.QuestionTimeLimit == new TimeSpan(0, 3, 0))
            {
                cboQuestionTimeLimit.SelectedIndex = 3;
            }
        }

        private void nudNumCategories_ValueChanged(object sender, EventArgs e)
        {
            game.NumCategories = (int)nudNumCategories.Value;
            DisplayNumberQuesions();

            CreateCategoryGrid();
            CreateQuestionGrid();
        }

        private void nudNumQuestionCategory_ValueChanged(object sender, EventArgs e)
        {
            game.NumQuestionsPerCategory = (int)nudNumQuestionCategory.Value;
            DisplayNumberQuesions();

            CreateQuestionGrid();
        }

        private void DisplayNumberQuesions()
        {
            lblNumberQuestions.Text = CalcNumberOfQuestions().ToString();
        }

        private int CalcNumberOfQuestions()
        {
            return (int)nudNumCategories.Value * (int)nudNumQuestionCategory.Value;
        }

        private void CreateCategoryGrid()
        {
            gbxCategories.Controls.Clear();

            if (categoryButtons != null)
            {
                categoryButtons.Clear();
            }

            int gbxWidth = gbxCategories.Width;
            int gbxHeight = gbxCategories.Height;

            int buttonWidth = (gbxWidth - 80) / (game.NumCategories);
            int buttonHeight = 80;

            int start_x = 30;
            int start_y = 30;

            for (int x = 0; x < 1; x++)
            {
                for (int y = 0; y < game.NumCategories; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * buttonHeight);
                    tmpButton.Left = start_y + ((y * buttonWidth) + (y * 5));
                    tmpButton.Width = buttonWidth;
                    tmpButton.Height = buttonHeight;
                    tmpButton.Text = "Category " + (y + 1).ToString();
                    tmpButton.ContextMenuStrip = cmsCategories;
                    tmpButton.Click += CategoryButton_Click;
                    categoryButtons.Add(tmpButton);
                }
            }

            foreach (Button b in categoryButtons)
            {
                gbxCategories.Controls.Add(b);
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            frmEditCategory editCategoryForm = new frmEditCategory();
            editCategoryForm.ShowDialog();
        }

        private void CreateQuestionGrid()
        {
            gbxQuestions.Controls.Clear();
            questionButtons.Clear();

            int gbxWidth = gbxQuestions.Width;
            int gbxHeight = gbxQuestions.Height;

            int buttonWidth = (gbxWidth - 80) / game.NumCategories;
            int buttonHeight = (gbxHeight - 80) / game.NumQuestionsPerCategory;

            int start_x = 30;
            int start_y = 30;

            for (int x = 0; x < game.NumQuestionsPerCategory; x++)
            {
                for (int y = 0; y < game.NumCategories; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + ((x * buttonHeight) + (x * 5));
                    tmpButton.Left = start_y + ((y * buttonWidth) + (y * 5));
                    tmpButton.Width = buttonWidth;
                    tmpButton.Height = buttonHeight;
                    tmpButton.Text = "Category " + (y + 1).ToString() + "\n" + "Question " + (x + 1).ToString();
                    tmpButton.ContextMenuStrip = cmsQuestions;
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

        private void ModifyGroupBoxWidths()
        {
            gbxGameInfo.Width = Width - 70;
            gbxCategories.Width = Width - 70;
            gbxQuestions.Width = Width - 70;
        }

        private void frmCreateGame_ResizeEnd(object sender, EventArgs e)
        {
            ModifyGroupBoxWidths();
            CreateCategoryGrid();
            CreateQuestionGrid();
        }

        //code to make maximizing and restoring the window act the same as resizing
        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void frmCreateGame_Resize(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                if (WindowState == FormWindowState.Maximized)
                {
                    frmCreateGame_ResizeEnd(sender, e);
                }
                if (WindowState == FormWindowState.Normal)
                {
                    frmCreateGame_ResizeEnd(sender, e);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmsQuestions_Opening(object sender, CancelEventArgs e)
        {

        }
        
    }
}

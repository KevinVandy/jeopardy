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
        Game game;
        Button[] categoryButtonss;
        Button[,] questionButtons;

        public frmEditGame(Game theGame)
        {
            game = theGame;

            InitializeComponent();
        }

        private void frmCreateGame_Load(object sender, EventArgs e)
        {
            //figure out diminsions of the grid
            categoryButtonss = new Button[game.NumCategories];
            questionButtons = new Button[game.NumCategories, game.NumQuestionsPerCategory];

            DrawGrids();

            DisplayNumberQuesions();
            
            txtGameName.Text = game.GameName;
            nudNumCategories.Value = game.NumCategories;
            nudNumQuestionCategory.Value = game.NumQuestionsPerCategory;
            if (game.QuestionTimeLimit == new TimeSpan(0, 0, 30))
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

        private void bwLoadGame_DoWork(object sender, DoWorkEventArgs e)
        {
            game = DB_Select.SelectGame_ByGameId(game.Id);
        }

        private void bwLoadGame_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DrawGrids();
        }

        private void nudNumCategories_ValueChanged(object sender, EventArgs e)
        {
            game.NumCategories = (int)nudNumCategories.Value;
            DisplayNumberQuesions();

            categoryButtonss = new Button[game.NumCategories];//diminsion change
            questionButtons = new Button[game.NumCategories, game.NumQuestionsPerCategory];//diminsion change

            DrawGrids();
        }

        private void nudNumQuestionCategory_ValueChanged(object sender, EventArgs e)
        {
            game.NumQuestionsPerCategory = (int)nudNumQuestionCategory.Value;
            DisplayNumberQuesions();
            
            questionButtons = new Button[game.NumCategories, game.NumQuestionsPerCategory]; //diminsion change

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

        private void DrawGrids()
        {
            CreateCategoryGrid();
            CreateQuestionGrid();
        }

        private void CreateCategoryGrid()
        {
            gbxCategories.Controls.Clear();
            
            int gbxWidth = gbxCategories.Width;
            int gbxHeight = gbxCategories.Height;

            int buttonWidth = (gbxWidth - 80) / (game.NumCategories);
            int buttonHeight = 80;

            int start_x = 30;
            int start_y = 30;

            categoryButtonss = new Button[game.NumCategories];

            //create the button with the button attributes
            for (int x = 0; x < game.NumCategories; x++)
            {
                Button tmpButton = new Button();
                tmpButton.Top = start_x;
                tmpButton.Left = start_y + ((x * buttonWidth) + (x * 5));
                tmpButton.Width = buttonWidth;
                tmpButton.Height = buttonHeight;
                tmpButton.Text = "Category " + (x + 1).ToString();
                tmpButton.ContextMenuStrip = cmsCategories;
                tmpButton.Click += CategoryButton_Click;
                categoryButtonss[x] = tmpButton;
            }
            //fill in category info, but only for defined categories
            for (int i = 0; i < game.Categories.Count; i++)
            {
                categoryButtonss[i].Text = game.Categories[i].Title + "\n" + game.Categories[i].Subtitle;
            }


            foreach (Button b in categoryButtonss)
            {
                gbxCategories.Controls.Add(b);
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            frmEditCategory editCategoryForm = new frmEditCategory((int)game.Id);
            DialogResult dialogResult = editCategoryForm.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                bwLoadGame.RunWorkerAsync(); //refresh game data and grid
            }
        }

        private void CreateQuestionGrid()
        {
            gbxQuestions.Controls.Clear();

            int gbxWidth = gbxQuestions.Width;
            int gbxHeight = gbxQuestions.Height;

            int buttonWidth = (gbxWidth - 80) / game.NumCategories;
            int buttonHeight = (gbxHeight - 80) / game.NumQuestionsPerCategory;

            int start_x = 30;
            int start_y = 30;

            questionButtons = new Button[game.NumCategories, game.NumQuestionsPerCategory];

            //draw blank buttons
            for (int x = 0; x < game.NumCategories; x++)
            {
                for (int y = 0; y < game.NumQuestionsPerCategory; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Tag = (y + 1) * 100; //score aka weight
                    tmpButton.Top = start_x + ((y * buttonHeight) + (y * 5));
                    tmpButton.Left = start_y + ((x * buttonWidth) + (x * 5));
                    tmpButton.Width = buttonWidth;
                    tmpButton.Height = buttonHeight;
                    tmpButton.Text = tmpButton.Tag + "\nCategory " + (x + 1).ToString() + "\n" + "Question " + (y + 1).ToString();
                    tmpButton.ContextMenuStrip = cmsQuestions;
                    tmpButton.Click += QuestionButton_Click;

                    questionButtons[x, y] = tmpButton; //add button to array
                }
            }

            //add info to buttons (associate with actual question)
            for (int i = 0; i < game.Categories.Count; i++)
            {
                for (int j = 0; j < game.Categories[i].Questions.Count; j++)
                {
                    questionButtons[i, j].Text = game.Categories[i].Questions[j].QuestionText;

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

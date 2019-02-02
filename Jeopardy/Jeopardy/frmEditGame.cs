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
        Button[] categoryButtons;
        Button[,] questionButtons;

        public frmEditGame(Game theGame)
        {
            game = theGame;
            
            InitializeComponent();
        }

        private void frmCreateGame_Load(object sender, EventArgs e)
        {
            DetermineQuestionStates();

            //figure out diminsions of the grids
            categoryButtons = new Button[game.NumCategories];
            questionButtons = new Button[game.NumCategories, game.NumQuestionsPerCategory];

            //Display Game Info
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
            else if (game.QuestionTimeLimit == new TimeSpan(0, 1, 30))
            {
                cboQuestionTimeLimit.SelectedIndex = 2;
            }
            else if (game.QuestionTimeLimit == new TimeSpan(0, 2, 0))
            {
                cboQuestionTimeLimit.SelectedIndex = 3;
            }
            else if (game.QuestionTimeLimit == new TimeSpan(0, 3, 0))
            {
                cboQuestionTimeLimit.SelectedIndex = 4;
            }

            //Display Stats
            DisplayNumberQuestions();
            DisplayNumFinishedQuestions();

            //Draw the grids and make sure they take advantage of the screen size
            frmCreateGame_ResizeEnd(sender, e);
        }

        //background thread to load/reload the game from the database
        private void bwLoadGame_DoWork(object sender, DoWorkEventArgs e)
        {
            game = DB_Select.SelectGame_ByGameId(game.Id);
        }

        //after the game has loaded/reloaded the game grids will redraw with updated info
        private void bwLoadGame_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DrawGrids();
        }

        //MARK Value & Index Change Event Handlers
        private void txtGameName_Leave(object sender, EventArgs e)
        {
            if (txtGameName.Text != game.GameName)
            {
                game.GameName = txtGameName.Text;
                bwUpdateGameName.RunWorkerAsync();
            }
        }

        private void bwUpdateGameName_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!DB_Update.UpdateGameName(game.GameName, game.Id))
            {
                MessageBox.Show("Error updating Game name");
            }
        }
        
        private void cboQuestionTimeLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuestionTimeLimit.SelectedIndex == 0 )
            {
                game.QuestionTimeLimit = new TimeSpan(0, 0, 30);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 1)
            {
                game.QuestionTimeLimit = new TimeSpan(0, 1, 0);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 2)
            {
                game.QuestionTimeLimit = new TimeSpan(0, 1, 30);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 3)
            {
                game.QuestionTimeLimit = new TimeSpan(0, 2, 0);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 4)
            {
                game.QuestionTimeLimit = new TimeSpan(0, 3, 0);
            }
            bwUpdateTimeLimit.RunWorkerAsync();
        }
        
        private void bwUpdateTimeLimit_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!DB_Update.UpdateGameQuestionTimeLimit(game.QuestionTimeLimit, game.Id))
            {
                MessageBox.Show("Error updating Game name");
            }
        }

        private void nudNumCategories_ValueChanged(object sender, EventArgs e)
        {
            if ((int)nudNumCategories.Value > game.NumCategories) //if up was clicked
            {
                nudNumCategories.Enabled = false;
                game.NumCategories = (int)nudNumCategories.Value;
                bwAddCategory.RunWorkerAsync();
                bwUpdateNumCategories.RunWorkerAsync();
            }
            else if ((int)nudNumCategories.Value < game.NumCategories) //if down was clicked
            {
                nudNumCategories.Enabled = false;
                game.NumCategories = (int)nudNumCategories.Value;
                bwRemoveCategory.RunWorkerAsync();
                bwUpdateNumCategories.RunWorkerAsync();
            }

            DisplayNumberQuestions();
        }

        private void nudNumQuestionCategory_ValueChanged(object sender, EventArgs e)
        {
            if ((int)nudNumQuestionCategory.Value > game.NumQuestionsPerCategory) //if up was clicked
            {
                nudNumQuestionCategory.Enabled = false;
                game.NumQuestionsPerCategory = (int)nudNumQuestionCategory.Value;
                bwAddQuestions.RunWorkerAsync();
                bwUpdateNumQuestionsPerCategory.RunWorkerAsync();
            }
            else if ((int)nudNumQuestionCategory.Value < game.NumQuestionsPerCategory) //if down was clicked
            {
                nudNumQuestionCategory.Enabled = false;
                game.NumQuestionsPerCategory = (int)nudNumQuestionCategory.Value;
                bwRemoveQuestions.RunWorkerAsync();
                bwUpdateNumQuestionsPerCategory.RunWorkerAsync();
            }

            DisplayNumberQuestions();
        }

        //MARK Background Worker Threads for interacting with the database
        private void bwUpdateNumCategories_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!DB_Update.UpdateGameNumCategories(game.NumCategories, game.Id))
            {
                MessageBox.Show("Failed to update NumCategories");
            }
        }

        private void bwUpdateNumQuestionsPerCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!DB_Update.UpdateGameNumQuestionsPerCategory(game.NumQuestionsPerCategory, game.Id))
            {
                MessageBox.Show("Failed to update NumQuestionsPerCategory");
            }
        }

        private void bwAddCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            Category newCategory = new Category(null, (int)game.Id, game.Categories.Count, "Category " + (game.Categories.Count + 1), " ", null);
            newCategory.Id = DB_Insert.InsertCategory(newCategory);
            newCategory.Questions = new List<Question>(new Question[game.NumQuestionsPerCategory]);
            for (int i = 0; i < game.NumQuestionsPerCategory; i++)
            {
                newCategory.Questions[i] = new Question();

                newCategory.Questions[i].CategoryId = (int)newCategory.Id;
                newCategory.Questions[i].Type = "fb";
                newCategory.Questions[i].QuestionText = " ";
                newCategory.Questions[i].Answer = " ";
                newCategory.Questions[i].Weight = (i + 1) * 100;
                newCategory.Questions[i].Id = DB_Insert.InsertQuestion(newCategory.Questions[i]);
            }
            game.Categories.Add(newCategory);
        }

        private void bwAddCategory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DrawGrids();
            nudNumCategories.Enabled = true;
        }

        private void bwRemoveCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            if (DB_Delete.DeleteCategory(game.Categories[game.NumCategories].Id) > 0)
            {
                game.Categories.RemoveAt(game.NumCategories);
            }
        }

        private void bwRemoveCategory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DrawGrids();
            nudNumCategories.Enabled = true;
        }

        private void bwAddQuestions_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < game.NumCategories; i++)
            {
                Question newQuestion = new Question();

                newQuestion.CategoryId = (int)game.Categories[i].Id;
                newQuestion.Type = "fb";
                newQuestion.QuestionText = " ";
                newQuestion.Answer = " ";
                newQuestion.Weight = (game.NumQuestionsPerCategory) * 100;
                newQuestion.Id = DB_Insert.InsertQuestion(newQuestion);

                game.Categories[i].Questions.Add(newQuestion);
            }
        }

        private void bwAddQuestions_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CreateQuestionGrid();
            nudNumQuestionCategory.Enabled = true;
        }

        private void bwRemoveQuestions_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < game.NumCategories; i++)
            {
                if (DB_Delete.DeleteQuestion(game.Categories[i].Questions[game.NumQuestionsPerCategory].Id) > 0)
                {
                    game.Categories[i].Questions.RemoveAt(game.NumQuestionsPerCategory);
                }
                else
                {
                    MessageBox.Show("Failed to delete questions");
                }
            }
        }

        private void bwRemoveQuestions_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CreateQuestionGrid();
            nudNumQuestionCategory.Enabled = true;
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

            categoryButtons = new Button[game.NumCategories];

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
                categoryButtons[x] = tmpButton;
            }
            //fill in category info, but only for defined categories
            for (int i = 0; i < game.NumCategories && i < game.Categories.Count; i++)
            {
                categoryButtons[i].Text = game.Categories[i].Title + "\n" + game.Categories[i].Subtitle;
            }


            foreach (Button b in categoryButtons)
            {
                gbxCategories.Controls.Add(b);
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            //detect position in button grid
            int x = -1;
            for (int i = 0; i < game.NumCategories && x < 0; ++i)
            {
                if (categoryButtons[i] == (Button)sender)
                {
                    x = i;
                    break;
                }
            }

            frmEditCategory editCategoryForm = new frmEditCategory(game.Categories[x]);
            DialogResult dialogResult = editCategoryForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
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
            for (int x = 0; x < game.NumCategories && x < game.NumCategories; x++)
            {
                for (int y = 0; y < game.NumQuestionsPerCategory; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Tag = (y + 1) * 100; //score aka weight
                    tmpButton.Top = start_x + ((y * buttonHeight) + (y * 5));
                    tmpButton.Left = start_y + ((x * buttonWidth) + (x * 5));
                    tmpButton.Width = buttonWidth;
                    tmpButton.Height = buttonHeight;
                    tmpButton.Text = tmpButton.Tag.ToString();
                    tmpButton.ContextMenuStrip = cmsQuestions;
                    tmpButton.Click += QuestionButton_Click;
                    tmpButton.MouseEnter += questionButton_MouseHover;

                    questionButtons[x, y] = tmpButton; //add button to array
                }
            }

            DetermineQuestionStates();
            ColorCodeButtons();
            DisplayNumFinishedQuestions();
            DisplayNumUnfinishedQuestions();

            //add info to buttons (associate with actual question)
            for (int i = 0; i < game.NumCategories && i < game.Categories.Count; i++)
            {
                for (int j = 0; j < game.NumQuestionsPerCategory && j < game.Categories[i].Questions.Count; j++)
                {
                    questionButtons[i, j].Text = game.Categories[i].Questions[j].Weight.ToString() + "\n" + game.Categories[i].Questions[j].QuestionText.Trim();
                }
            }

            foreach (Button b in questionButtons)
            {
                gbxQuestions.Controls.Add(b);
            }
        }

        private void questionButton_MouseHover(object sender, EventArgs e)
        {
            Button hoveredButton = (Button)sender;
            hoveredButton.Focus();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            //detect position in button grid
            int x = -1;
            int y = -1;
            for (int i = 0; i < game.NumCategories && x < 0; ++i)
            {
                for (int j = 0; j < game.NumQuestionsPerCategory; ++j)
                {
                    if (questionButtons[i, j] == (Button)sender)
                    {
                        x = i;
                        y = j;
                        break;
                    }
                }
            }

            Question selectedQuestion = game.Categories[x].Questions[y];
            frmEditQuestion editQuestionForm = new frmEditQuestion(selectedQuestion, (int)game.Id, game.Categories[x].Title + " " + game.Categories[x].Subtitle);

            DialogResult dialogResult = editQuestionForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                bwLoadGame.RunWorkerAsync(); //refresh game data and grid
            }

        }

        //MARK ToolStrip MenuItem Click Event Handlers
        private void exportGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }


        //MARK Private Utility Functions
        private void DetermineQuestionStates()
        {
            foreach(Category c in game.Categories)
            {
                foreach(Question q in c.Questions)
                {
                    q.DetermineState("edit");
                }
            }
        }

        private void ColorCodeButtons()
        {
            for(int i = 0; i < game.NumCategories; i++)
            {
                for(int j = 0; j < game.NumQuestionsPerCategory; j++)
                {
                    if(game.Categories[i].Questions[j].State == "no question")
                    {
                        questionButtons[i, j].BackColor = Color.Transparent;
                    }
                    else if(game.Categories[i].Questions[j].State == "no answer")
                    {
                        questionButtons[i, j].BackColor = Color.PaleVioletRed;
                    }
                    else if (game.Categories[i].Questions[j].State == "no choices")
                    {
                        questionButtons[i, j].BackColor = Color.Orange;
                    }
                    else if (game.Categories[i].Questions[j].State == "done")
                    {
                        questionButtons[i, j].BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void DisplayNumberQuestions()
        {
            lblNumberQuestions.Text = CalcNumberOfQuestions().ToString();
        }

        private int CalcNumberOfQuestions()
        {
            return (int)nudNumCategories.Value * (int)nudNumQuestionCategory.Value;
        }

        private void DisplayNumFinishedQuestions()
        {
            lblNumberFinishedQuestions.Text = CalcNumFinishedQuestions().ToString();
        }

        private int CalcNumFinishedQuestions()
        {
            int numFinishedQuestions = 0;
            foreach (Category c in game.Categories)
            {
                foreach (Question q in c.Questions)
                {
                    if(q.State == "done")
                    {
                        numFinishedQuestions++;
                    }
                }
            }
            return numFinishedQuestions;
        }

        private void DisplayNumUnfinishedQuestions()
        {
            lblNumberEmptyQuestions.Text = CalcNumUnfinishedQuestions().ToString();
        }

        private int CalcNumUnfinishedQuestions()
        {
            return CalcNumberOfQuestions() - CalcNumFinishedQuestions();
        }

        private void ModifyGroupBoxWidths()
        {
            gbxGameInfo.Width = Width - 70;
            gbxCategories.Width = Width - 70;
            gbxQuestions.Width = Width - 70;
        }

        private void ModifyGroupBoxHeights()
        {
            gbxGameInfo.Top = 50;
            gbxGameInfo.Height = 163;

            gbxCategories.Top = gbxGameInfo.Top + gbxGameInfo.Height + 30;
            gbxCategories.Height = 127;

            gbxQuestions.Top = gbxCategories.Top + gbxCategories.Height + 30;
            gbxQuestions.Height = Height - gbxCategories.Height - gbxGameInfo.Height - gbxCategories.Top + 30;

        }

        private void frmCreateGame_ResizeEnd(object sender, EventArgs e)
        {
            ModifyGroupBoxWidths();
            ModifyGroupBoxHeights();
            DrawGrids();
        }

        //code to make maximizing and restoring the window act the same as resizing
        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void frmCreateGame_Resize(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
                {
                    frmCreateGame_ResizeEnd(sender, e);
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateGame createGameForm = new frmCreateGame();
            this.Hide();
            this.Close();
            createGameForm.ShowDialog();
        }
    }
}

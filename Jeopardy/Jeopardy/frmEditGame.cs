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

        Category currentCategory;
        Question currentQuestion;

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

        //MARK: Value & Index Change Event Handlers (Mostly for stuff in the Game Info group box)

        private void txtGameName_Leave(object sender, EventArgs e)
        {
            if (txtGameName.Text != game.GameName)
            {
                game.GameName = txtGameName.Text;
                bwUpdateGameName.RunWorkerAsync();
            }
        }

        private void txtGameName_DoubleClick(object sender, EventArgs e)
        {
            if (txtGameName.Text != game.GameName)
            {
                game.GameName = txtGameName.Text;
                bwUpdateGameName.RunWorkerAsync();
            }
        }

        private void bwUpdateGameName_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!DB_Update.UpdateGameName(game.GameName, game.Id)) //updating the database happens here
            {
                MessageBox.Show("Error updating Game name", "Error");
            }
        }

        private void cboQuestionTimeLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuestionTimeLimit.SelectedIndex == 0)
            {
                game.QuestionTimeLimit = new TimeSpan(0, 0, 30); //30 seconds
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 1)
            {
                game.QuestionTimeLimit = new TimeSpan(0, 1, 0); //1 minute
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 2)
            {
                game.QuestionTimeLimit = new TimeSpan(0, 1, 30); //1 minute 30 seconds (90 seconds)
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 3)
            {
                game.QuestionTimeLimit = new TimeSpan(0, 2, 0); //2 minutes
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 4)
            {
                game.QuestionTimeLimit = new TimeSpan(0, 3, 0); //3 minutes
            }

            cboQuestionTimeLimit.Enabled = false; //disable while other thread running
            bwUpdateTimeLimit.RunWorkerAsync(); //update in backgroud thread
        }

        private void bwUpdateTimeLimit_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!DB_Update.UpdateGameQuestionTimeLimit(game.QuestionTimeLimit, game.Id))
            {
                MessageBox.Show("Error updating Game name");
            }
        }

        private void bwUpdateTimeLimit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cboQuestionTimeLimit.Enabled = true; //re-enable once safe
        }

        private void nudNumCategories_ValueChanged(object sender, EventArgs e)
        {
            if ((int)nudNumCategories.Value > game.NumCategories) //if up was clicked
            {
                nudNumCategories.Enabled = false;
                game.NumCategories = (int)nudNumCategories.Value;
                bwAddCategory.RunWorkerAsync();
            }
            else if ((int)nudNumCategories.Value < game.NumCategories) //if down was clicked
            {
                nudNumCategories.Enabled = false;
                game.NumCategories = (int)nudNumCategories.Value;
                bwRemoveCategory.RunWorkerAsync();
            }

            DisplayNumberQuestions();
        }

        private void bwUpdateNumCategories_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!DB_Update.UpdateGameNumCategories(game.NumCategories, game.Id))
            {
                MessageBox.Show("Failed to update NumCategories");
            }
        }

        private void bwUpdateNumCategories_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nudNumCategories.Enabled = true;
        }

        private void bwAddCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            Category newCategory = new Category();
            newCategory.GameId = (int)game.Id;
            newCategory.Index = game.Categories.Count;
            newCategory.ResetCategoryToDefaults(); //other default data
            newCategory.Id = DB_Insert.InsertCategory(newCategory);
            newCategory.Questions = new List<Question>(new Question[game.NumQuestionsPerCategory]);
            for (int i = 0; i < game.NumQuestionsPerCategory; i++)
            {
                newCategory.Questions[i] = new Question();

                newCategory.Questions[i].CategoryId = (int)newCategory.Id;
                newCategory.Questions[i].ResetQuestionToDefaults(); //other default data
                newCategory.Questions[i].Weight = (i + 1) * 100;
                newCategory.Questions[i].Id = DB_Insert.InsertQuestion(newCategory.Questions[i]);
            }
            game.Categories.Add(newCategory);
        }

        private void bwAddCategory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwUpdateNumCategories.RunWorkerAsync();
            DrawGrids();
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

            bwUpdateNumCategories.RunWorkerAsync();
            DrawGrids();
            nudNumCategories.Enabled = true;
        }

        private void nudNumQuestionCategory_ValueChanged(object sender, EventArgs e)
        {
            if ((int)nudNumQuestionCategory.Value > game.NumQuestionsPerCategory) //if up was clicked
            {
                nudNumQuestionCategory.Enabled = false;
                game.NumQuestionsPerCategory = (int)nudNumQuestionCategory.Value;
                bwAddQuestions.RunWorkerAsync();
                
            }
            else if ((int)nudNumQuestionCategory.Value < game.NumQuestionsPerCategory) //if down was clicked
            {
                nudNumQuestionCategory.Enabled = false;
                game.NumQuestionsPerCategory = (int)nudNumQuestionCategory.Value;
                bwRemoveQuestions.RunWorkerAsync();
                
            }

            DisplayNumberQuestions();
        }

        private void bwUpdateNumQuestionsPerCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!DB_Update.UpdateGameNumQuestionsPerCategory(game.NumQuestionsPerCategory, game.Id)) //updating db happens here
            {
                MessageBox.Show("Failed to update NumQuestionsPerCategory");
            }
        }

        private void bwUpdateNumQuestionsPerCategory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nudNumQuestionCategory.Enabled = true; //re-enable once thread safe
        }

        private void bwAddQuestions_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < game.NumCategories; i++)
            {
                Question newQuestion = new Question();

                newQuestion.CategoryId = (int)game.Categories[i].Id;
                newQuestion.ResetQuestionToDefaults(); //default data
                newQuestion.Weight = (game.NumQuestionsPerCategory) * 100;
                newQuestion.Id = DB_Insert.InsertQuestion(newQuestion);

                if (newQuestion.Id != null && newQuestion.Id > 0) //if the insert into db worked
                {
                    game.Categories[i].Questions.Add(newQuestion); //add it to the current game object too
                }
            }
        }

        private void bwAddQuestions_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwUpdateNumQuestionsPerCategory.RunWorkerAsync();
            CreateQuestionGrid(); //only recreate the question grid, category grid can stay the same
        }

        private void bwRemoveQuestions_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < game.NumCategories; i++)
            {
                if (DB_Delete.DeleteQuestion(game.Categories[i].Questions[game.NumQuestionsPerCategory].Id) > 0) //deleting question happens here
                {
                    game.Categories[i].Questions.RemoveAt(game.NumQuestionsPerCategory); //if deleting from db was successful, also remove from game
                }
                else
                {
                    MessageBox.Show("Failed to delete questions");
                }
            }
        }

        private void bwRemoveQuestions_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwUpdateNumQuestionsPerCategory.RunWorkerAsync();
            CreateQuestionGrid();
            nudNumQuestionCategory.Enabled = true;
        }

        //MARK: Methods for Drawing the Buttons in the Group Boxes

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
                categoryButtons[x] = new Button();
                categoryButtons[x].Top = start_x;
                categoryButtons[x].Left = start_y + ((x * buttonWidth) + (x * 5));
                categoryButtons[x].Width = buttonWidth;
                categoryButtons[x].Height = buttonHeight;
                categoryButtons[x].Text = game.Categories[x].Title + "\n" + game.Categories[x].Subtitle;
                categoryButtons[x].Font = new Font("Microsoft Sans Serif", 14);
                categoryButtons[x].ContextMenuStrip = cmsCategories;
                categoryButtons[x].Click += CategoryButton_Click;
            }
            
            foreach (Button b in categoryButtons) //adds them with less stuttering when in its own foreach loop
            {
                gbxCategories.Controls.Add(b);
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
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
                if (!bwLoadGame.IsBusy)
                {
                    bwLoadGame.RunWorkerAsync();
                }
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
                    questionButtons[x, y] = new Button();
                    questionButtons[x, y].Top = start_x + ((y * buttonHeight) + (y * 5));
                    questionButtons[x, y].Left = start_y + ((x * buttonWidth) + (x * 5));
                    questionButtons[x, y].Width = buttonWidth;
                    questionButtons[x, y].Height = buttonHeight;
                    questionButtons[x, y].Text = game.Categories[x].Questions[y].Weight.ToString() + "\n" + game.Categories[x].Questions[y].QuestionText.Trim();
                    questionButtons[x, y].Font = new Font("Microsoft Sans Serif", 12);
                    questionButtons[x, y].ContextMenuStrip = cmsQuestions;
                    questionButtons[x, y].Click += QuestionButton_Click;
                    questionButtons[x, y].MouseEnter += questionButton_MouseHover;
                }
            }

            DetermineQuestionStates();
            ColorCodeButtons();
            DisplayNumFinishedQuestions();
            DisplayNumUnfinishedQuestions();

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
            //detect position in button grid of sender
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
                if (!bwLoadGame.IsBusy)
                {
                    bwLoadGame.RunWorkerAsync();
                }
            }

        }

        //MARK Methods for figuring out stats and Button Colors
        private void DetermineQuestionStates()
        {
            foreach (Category c in game.Categories)
            {
                foreach (Question q in c.Questions)
                {
                    q.DetermineState("edit");
                }
            }
        }

        private void ColorCodeButtons()
        {
            for (int i = 0; i < game.NumCategories; i++)
            {
                for (int j = 0; j < game.NumQuestionsPerCategory; j++)
                {
                    if (game.Categories[i].Questions[j].State == "no question")
                    {
                        questionButtons[i, j].BackColor = Color.Transparent;
                    }
                    else if (game.Categories[i].Questions[j].State == "no answer")
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
                    if (q.State == "done")
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

        //MARK: ToolStrip MenuItem Click Event Handlers
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateGame createGameForm = new frmCreateGame();
            Hide();
            Close();
            createGameForm.ShowDialog();
        }

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

        //MARK: Context Menu Item Click Event Handlers
        private void tsmiEditCategory_Click(object sender, EventArgs e) //just simulates a click of the button
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    Button clickedButton = (Button)owner.SourceControl;
                    CategoryButton_Click(clickedButton, null);
                }
            }
        }
        
        private void tsmiDeleteCategory_Click(object sender, EventArgs e) //updates a category to be blank and default
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    Button clickedButton = (Button)owner.SourceControl;

                    //detect position in button grid
                    int x = -1;
                    for (int i = 0; i < game.NumCategories && x < 0; ++i)
                    {
                        if (categoryButtons[i] == clickedButton)
                        {
                            x = i;
                            break;
                        }
                    }
                    game.Categories[x].ResetCategoryToDefaults(); //deletes info, restores default values
                    currentCategory = game.Categories[x];
                    bwUpdateCategory.RunWorkerAsync();
                }
            }
        }

        private void bwUpdateCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            DB_Update.UpdateCategory(currentCategory);
        }

        private void bwUpdateCategory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!bwLoadGame.IsBusy)
            {
                bwLoadGame.RunWorkerAsync();
            }
        }

        private void tsmiEditQuestion_Click(object sender, EventArgs e) //just simulates a click of the button
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    Button clickedButton = (Button)owner.SourceControl;
                    QuestionButton_Click(clickedButton, null);
                }
            }
        }

        private void tsmiDeleteQuestion_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    Button clickedButton = (Button)owner.SourceControl;

                    //detect position in button grid
                    int x = -1;
                    int y = -1;
                    for (int i = 0; i < game.NumCategories && x < 0; ++i)
                    {
                        for (int j = 0; j < game.NumQuestionsPerCategory; ++j)
                        {
                            if (questionButtons[i, j] == clickedButton)
                            {
                                x = i;
                                y = j;
                                break;
                            }
                        }
                    }
                    currentQuestion = game.Categories[x].Questions[y]; //needs to be here for the first bw to use
                    if (game.Categories[x].Questions[y].Type == "mc")
                    {
                        bwDeleteChoices.RunWorkerAsync();
                    }
                    game.Categories[x].Questions[y].ResetQuestionToDefaults(); //reset with default blank data
                    currentQuestion = game.Categories[x].Questions[y]; //needs to be here again with default data for the 2nd bw to use
                    bwUpdateQuestion.RunWorkerAsync();
                }
            }
        }

        private void bwUpdateQuestion_DoWork(object sender, DoWorkEventArgs e)
        {
            DB_Update.UpdateQuestion(currentQuestion);
        }

        private void bwUpdateQuestion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!bwLoadGame.IsBusy)
            {
                bwLoadGame.RunWorkerAsync();
            }
        }

        private void bwDeleteChoices_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < currentQuestion.Choices.Count; i++)
            {
                DB_Delete.DeleteChoice(currentQuestion.Choices[i].Id);
            }
        }

        private void bwDeleteChoices_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!bwLoadGame.IsBusy)
            {
                bwLoadGame.RunWorkerAsync();
            }
        }

        //MARK: Resizing the Window Event Handler stuff
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

        
    }
}

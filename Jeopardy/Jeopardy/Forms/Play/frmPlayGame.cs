using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmPlayGame : Form
    {
        //Variables
        private int rows = 1;
        private int columns = 1;
        private Button[,] questionButtons;
        private List<Label> LabelList = new List<Label>();
        private Game game = new Game();
        private Team currentTeam = new Team();
        private List<Question> wrongQuestions = new List<Question>();

        public frmPlayGame(Game theGame)
        {
            game = theGame;
            rows = game.NumQuestionsPerCategory;
            columns = game.NumCategories;
            currentTeam = game.Teams[0];
            InitializeComponent();
        }

        private void frmPlayGame_Load(object sender, EventArgs e)
        {
            LoadTeams();
            ModifyPanelWidths();
            ModifyPanelHeights();
            ModifyTeamGrid();
            DrawCategories();
            DrawGameGrid();
            game.GenerateDailyDouble();

            //grabs the time limit from the game and sets it as the default on the form
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
        }

        private void frmPlayGame_ResizeEnd(object sender, EventArgs e)
        {
            //every time the game is resized, modify the team panels and redraw the game grid
            ModifyPanelWidths();
            ModifyPanelHeights();
            ModifyTeamGrid();
            DrawCategories();
            DrawGameGrid();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //Encompasses every button on the game grid

            //Grab whichever button is clicked
            Button button = sender as Button;

            //Grab the Question assigned to that button (assigned to the button's tag [done in the creation of the grid])
            Question currentQuestion = (Question)button.Tag;

            //Used to determine if user answered the question correctly
            bool answeredCorrectly = false;

            //Used later to determine if every question has been answered
            

            //Used to determine if the user canceled a question form or answered.
            DialogResult formResult = DialogResult.Cancel;

            //If the question is a daily double, pull up the daily double form
            if (currentQuestion.DailyDouble == true)
            {
                frmDoubleJeopardy frmDJ = new frmDoubleJeopardy(currentQuestion, currentTeam);
                frmDJ.ShowDialog();
                currentQuestion = (Question)frmDJ.Tag;
            }

            //Based on the question's type, pull up the correct form
            switch (currentQuestion.Type)
            {
                case "tf":
                    //call up true/false question form
                    using (frmTrueFalse frmTFQuestion = new frmTrueFalse(currentQuestion, game.QuestionTimeLimit))
                    {
                        formResult = frmTFQuestion.ShowDialog();

                        answeredCorrectly = frmTFQuestion.Correct;
                    }
                    break;
                case "fb":
                    //call up fill in the blank question form
                    frmFillInTheBlank frmFB = new frmFillInTheBlank(currentQuestion, game.QuestionTimeLimit);
                    formResult = frmFB.ShowDialog();

                    answeredCorrectly = frmFB.Correct;
                    break;
                case "mc":
                    //call up multiple choice question form
                    frmMultipleChoice frmMC = new frmMultipleChoice(currentQuestion, game.QuestionTimeLimit);
                    formResult = frmMC.ShowDialog();

                    answeredCorrectly = frmMC.Correct;
                    break;
            }

            //If the user answered the question
            if (formResult == DialogResult.OK)
            {
                //Put the question into the wrongQuestions list if it was answered wrong, used for review later
                if (answeredCorrectly == false)
                {
                    wrongQuestions.Add(currentQuestion);
                }

                //hide the clicked button
                //Only hides if the question was answered
                //This was done intentionally as requested
                button.Visible = false;
                currentQuestion.State = "Answered";

                //method to assign score to the right team
                AssignPoints(answeredCorrectly, currentQuestion);
                
                //If the game is done and every question has been answered
                //Then pull up frmWrongQuestions
               
                //If the game is done, then pull up the review form
                if (game.CheckGameOver())
                {
                    //show the frmWrongQuestions for statistics
                    frmReviewWrongQuestions frmRWQ = new frmReviewWrongQuestions(wrongQuestions, game.Teams);
                    frmRWQ.ShowDialog();
                    //close the form
                    Close();
                }
                else
                {
                    MoveToNextTeam(); //method to automatically move the teams along
                }
            }
        }

        private void DrawCategories()
        {
            //Have to clear the controls because we dynamically resize the labels when the form resizes
            pnlCategories.Controls.Clear();

            //Temporary storage for our labels
            if (LabelList != null)
            {
                LabelList.Clear();
            }

            int pnlWidth = pnlCategories.Width;
            int pnlHeight = pnlCategories.Height;

            int labelWidth = (pnlWidth - 60) / (game.NumCategories);
            int labelHeight = 80;

            int start_x = 10;
            int start_y = 10;

            //For one row..
            for (int x = 0; x < 1; x++)
            {
                //Create as many labels as there are categories
                for (int y = 0; y < game.NumCategories; y++)
                {
                    //Dynamically create a label with all the needed properties
                    Label tmpLabel = new Label();
                    tmpLabel.Top = start_x + (x * labelHeight);
                    tmpLabel.Left = start_y + ((y * labelWidth) + (y * 5));
                    tmpLabel.Width = labelWidth;
                    tmpLabel.Height = labelHeight;
                    tmpLabel.Text = game.Categories[y].Title + '\n' + game.Categories[y].Subtitle;
                    tmpLabel.TextAlign = ContentAlignment.MiddleCenter;
                    tmpLabel.Font = new Font("Arial", 18, FontStyle.Bold);
                    tmpLabel.ForeColor = Color.Yellow;
                    LabelList.Add(tmpLabel);
                }
            }

            //Re-add the labels to the panels
            foreach (Label l in LabelList)
            {
                pnlCategories.Controls.Add(l);
            }
        }

        private void ModifyTeamGrid() //adjust widths of team panels
        {
            int numTeams = game.Teams.Length;
            if (game.Teams[3] == null) //just make each team block wider if more room available
            {
                numTeams = 3;
            }

            int panelWidth = gbxScoreBoard.Width;
            int questionTimeLimitSpace = pnlTeamOne.Left;

            int availableWidthLeft = panelWidth - questionTimeLimitSpace;

            pnlTeamOne.Left = questionTimeLimitSpace;
            pnlTeamOne.Width = availableWidthLeft / numTeams;
            availableWidthLeft -= pnlTeamOne.Width;

            pnlTeamTwo.Left = questionTimeLimitSpace + pnlTeamOne.Width;
            pnlTeamTwo.Width = availableWidthLeft / (numTeams - 1);
            availableWidthLeft -= pnlTeamTwo.Width;

            if (numTeams >= 3)
            {
                pnlTeamThree.Left = questionTimeLimitSpace + pnlTeamOne.Width + pnlTeamTwo.Width;
                pnlTeamThree.Width = availableWidthLeft / (numTeams - 2);
                availableWidthLeft -= pnlTeamThree.Width;
            }

            if (numTeams >= 4)
            {
                pnlTeamFour.Left = questionTimeLimitSpace + pnlTeamOne.Width + pnlTeamTwo.Width + pnlTeamThree.Width;
                pnlTeamFour.Width = availableWidthLeft / (numTeams - 3);
                availableWidthLeft -= pnlTeamFour.Width;
            }
        }

        private void DrawGameGrid()
        {
            //Have to clear the controls because we dynamically resize the buttons when the form resizes
            pnlGameboard.Controls.Clear();

            int gbxWidth = pnlGameboard.Width;
            int gbxHeight = pnlGameboard.Height;

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
                    //If the question has already been answered, don't make the button
                    if (game.Categories[x].Questions[y].State != "Answered")
                    {
                        //Dynamically create each button with all the needed properties
                        Button tmpButton = new Button();
                        tmpButton.Tag = game.Categories[x].Questions[y]; //send the entire question through the tag
                        tmpButton.Top = start_x + ((y * buttonHeight));
                        tmpButton.Left = start_y + ((x * buttonWidth));
                        tmpButton.Width = buttonWidth;
                        tmpButton.Height = buttonHeight;
                        tmpButton.Font = new Font("Stencil", 30);
                        tmpButton.ForeColor = Color.Yellow;
                        tmpButton.BackColor = Color.DarkBlue;
                        tmpButton.Cursor = Cursors.Hand;
                        tmpButton.Click += button_Click;
                        tmpButton.MouseEnter += TmpButton_MouseEnter;
                        tmpButton.MouseLeave += TmpButton_MouseLeave;

                        questionButtons[x, y] = tmpButton; //add button to array
                    }
                }
            }

            //add info to buttons (associate with actual question)
            for (int x = 0; x < game.NumCategories && x < game.Categories.Count; x++)
            {
                for (int y = 0; y < game.NumQuestionsPerCategory && y < game.Categories[x].Questions.Count; y++)
                {
                    //If the question has already been answered, then it doesn't have a button to assign to the .Text property
                    if (game.Categories[x].Questions[y].State != "Answered")
                    {
                        questionButtons[x, y].Text = game.Categories[x].Questions[y].Weight.ToString();
                    }
                }
            }

            //Re-add the buttons to the game grid
            foreach (Button b in questionButtons)
            {
                pnlGameboard.Controls.Add(b);
            }
        }

        private void TmpButton_MouseEnter(object sender, EventArgs e)
        {
            //Highlights the button if you hover over it
            Button hoveredButton = (Button)sender;
            hoveredButton.Focus();
            hoveredButton.BackColor = Color.Blue;
        }

        private void TmpButton_MouseLeave(object sender, EventArgs e)
        {
            //Reset the color if you're not hovering over the button anymore
            Button hoveredButton = (Button)sender;
            hoveredButton.BackColor = Color.DarkBlue;
        }

        private void ModifyPanelWidths()
        {
            gbxScoreBoard.Left = 0;
            gbxScoreBoard.Width = Width;

            pnlCategories.Left = 0;
            pnlCategories.Width = Width;

            pnlGameboard.Left = 0;
            pnlGameboard.Width = Width;
        }

        private void ModifyPanelHeights()
        {
            gbxScoreBoard.Top = 0;
            gbxScoreBoard.Height = 120;

            pnlCategories.Top = gbxScoreBoard.Top + gbxScoreBoard.Height;
            pnlCategories.Height = 80;

            pnlGameboard.Top = pnlCategories.Top + pnlCategories.Height;
            pnlGameboard.Height = Height - pnlGameboard.Top - 10;
        }

        private void LoadTeams()
        {
            //If the team isn't null, then set up the team name, and make it visible
            if (game.Teams[0] != null)
            {
                pnlTeamOne.BackColor = Color.LightBlue;
                pnlTeamOne.Visible = true;

                if (game.Teams[0].TeamName != "Team 1")
                {
                    lblTeamOne.Text = "Team 1\n" + game.Teams[0].TeamName;
                }
            }

            if (game.Teams[1] != null)
            {
                pnlTeamTwo.Visible = true;

                if (game.Teams[1].TeamName != "Team 2")
                {
                    lblTeamTwo.Text = "Team 2\n" + game.Teams[1].TeamName;
                }
            }

            if (game.Teams[2] != null)
            {
                pnlTeamThree.Visible = true;

                if (game.Teams[2].TeamName != "Team 3")
                {
                    lblTeamThree.Text = "Team 3\n" + game.Teams[2].TeamName;
                }
            }

            if (game.Teams[3] != null)
            {
                pnlTeamFour.Visible = true;

                if (game.Teams[3].TeamName != "Team 4")
                {
                    lblTeamFour.Text = "Team 4\n" + game.Teams[3].TeamName;
                }
            }
        }

        private void MoveToNextTeam()
        {
            //We assume there will always be at least two teams, so automatically move onto team two (team[1])
            if (currentTeam == game.Teams[0])
            {
                currentTeam = game.Teams[1];
                pnlTeamOne.BackColor = SystemColors.Control;
                pnlTeamTwo.BackColor = Color.LightBlue;
            }
            //The rest of these else ifs make sure the next team isn't null, and if they are, go back to team one (team[0])
            else if (currentTeam == game.Teams[1])
            {
                if (game.Teams[2] != null)
                {
                    currentTeam = game.Teams[2];
                    pnlTeamTwo.BackColor = SystemColors.Control;
                    pnlTeamThree.BackColor = Color.LightBlue;
                }
                else
                {
                    currentTeam = game.Teams[0];
                    pnlTeamOne.BackColor = Color.LightBlue;
                    pnlTeamTwo.BackColor = SystemColors.Control;
                }
            }
            else if (currentTeam == game.Teams[2])
            {
                if (game.Teams[3] != null)
                {
                    currentTeam = game.Teams[3];
                    pnlTeamThree.BackColor = SystemColors.Control;
                    pnlTeamFour.BackColor = Color.LightBlue;
                }
                else
                {
                    currentTeam = game.Teams[0];
                    pnlTeamOne.BackColor = Color.LightBlue;
                    pnlTeamThree.BackColor = SystemColors.Control;
                }
            }
            else if (currentTeam == game.Teams[3])
            {
                currentTeam = game.Teams[0];
                pnlTeamOne.BackColor = Color.LightBlue;
                pnlTeamFour.BackColor = SystemColors.Control;
            }
        }

        private void AssignPoints(bool answeredCorrectly, Question theQuestion)
        {
            //Checks if the question has been answered correctly or incorrectly
            if (answeredCorrectly == true)
            {
                //Checks which team is the currentTeam, and gives them the points for answering it correctly
                if (currentTeam == game.Teams[0])
                {
                    nudTeamOne.Value += theQuestion.Weight;
                }
                else if (currentTeam == game.Teams[1])
                {
                    nudTeamTwo.Value += theQuestion.Weight;
                }
                else if (currentTeam == game.Teams[2])
                {
                    nudTeamThree.Value += theQuestion.Weight;
                }
                else if (currentTeam == game.Teams[3])
                {
                    nudTeamFour.Value += theQuestion.Weight;
                }
            }
            else if (answeredCorrectly == false)
            {
                //Checks which team is the currentTeam, and takes away the points for answering it wrong
                if (currentTeam == game.Teams[0])
                {
                    nudTeamOne.Value -= theQuestion.Weight;
                }
                else if (currentTeam == game.Teams[1])
                {
                    nudTeamTwo.Value -= theQuestion.Weight;
                }
                else if (currentTeam == game.Teams[2])
                {
                    nudTeamThree.Value -= theQuestion.Weight;
                }
                else if (currentTeam == game.Teams[3])
                {
                    nudTeamFour.Value -= theQuestion.Weight;
                }
            }
        }

        private void cboQuestionTimeLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Changes the time limit to whatever the user selected on the form
            if (cboQuestionTimeLimit.SelectedIndex == 0)
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

        private void bwUpdateTimeLimit_DoWork(object sender, DoWorkEventArgs e) //also update in db for future games
        {
            //Updates the database whenever the user changes the question time limit
            if (!DB_Update.UpdateGameQuestionTimeLimit(game.QuestionTimeLimit, game.Id))
            {
                MessageBox.Show("Error updating Game name");
            }
        }

        //code to make maximizing and restoring the window act the same as resizing
        private FormWindowState LastWindowState = FormWindowState.Minimized;
        private void frmPlayGame_Resize(object sender, EventArgs e) //just comment this out if it is causing problems
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
                {
                    frmPlayGame_ResizeEnd(sender, e);
                }
            }
        }

        private void nudTeamOne_ValueChanged(object sender, EventArgs e)
        {
            //Assigns the team score to the value of the numeric up down on the form
            game.Teams[0].Score = (int)nudTeamOne.Value;
            pnlGameboard.Focus();
        }

        private void nudTeamTwo_ValueChanged(object sender, EventArgs e)
        {
            //Assigns the team score to the value of the numeric up down on the form
            game.Teams[1].Score = (int)nudTeamTwo.Value;
            pnlGameboard.Focus();
        }

        private void nudTeamThree_ValueChanged(object sender, EventArgs e)
        {
            //Assigns the team score to the value of the numeric up down on the form
            game.Teams[2].Score = (int)nudTeamThree.Value;
            pnlGameboard.Focus();
        }

        private void nudTeamFour_ValueChanged(object sender, EventArgs e)
        {
            //Assigns the team score to the value of the numeric up down on the form
            game.Teams[3].Score = (int)nudTeamFour.Value;
            pnlGameboard.Focus();
        }

        private void frmPlayGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!game.CheckGameOver())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit this unfinished game?", "Confirm Quit", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    game.ResetStatesToNull();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                game.ResetStatesToNull();
            }
        }
    }
}

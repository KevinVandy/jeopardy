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
        private Team[] teams = new Team[4];
        private Game currentGame = new Game();
        private Team currentTeam = new Team();
        private List<Question> wrongQuestions = new List<Question>();

        public frmPlayGame(Game theGame, Team[] theTeams)
        {
            currentGame = theGame;
            teams = theTeams;
            rows = currentGame.NumQuestionsPerCategory;
            columns = currentGame.NumCategories;
            currentTeam = teams[0];
            InitializeComponent();
        }

        private void frmPlayGame_Load(object sender, EventArgs e)
        {
            LoadTeams();
            ModifyPanelWidths();
            ModifyPanelHeights();
            DrawCategories();
            DrawGameGrid();
            currentGame.GenerateDailyDouble();

            //grabs the time limit from the game and sets it as the default on the form
            if (currentGame.QuestionTimeLimit == new TimeSpan(0, 0, 30))
            {
                cboQuestionTimeLimit.SelectedIndex = 0;
            }
            else if (currentGame.QuestionTimeLimit == new TimeSpan(0, 1, 0))
            {
                cboQuestionTimeLimit.SelectedIndex = 1;
            }
            else if (currentGame.QuestionTimeLimit == new TimeSpan(0, 1, 30))
            {
                cboQuestionTimeLimit.SelectedIndex = 2;
            }
            else if (currentGame.QuestionTimeLimit == new TimeSpan(0, 2, 0))
            {
                cboQuestionTimeLimit.SelectedIndex = 3;
            }
            else if (currentGame.QuestionTimeLimit == new TimeSpan(0, 3, 0))
            {
                cboQuestionTimeLimit.SelectedIndex = 4;
            }
        }

        private void frmPlayGame_ResizeEnd(object sender, EventArgs e)
        {
            //every time the game is resized, modify the team panels and redraw the game grid
            ModifyPanelWidths();
            ModifyPanelHeights();
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
            bool gameDone = true;

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
                    using (frmTrueFalse frmTFQuestion = new frmTrueFalse(currentQuestion, currentGame.QuestionTimeLimit))
                    {
                        formResult = frmTFQuestion.ShowDialog();

                        answeredCorrectly = frmTFQuestion.Correct;
                    }
                    break;
                case "fb":
                    //call up fill in the blank question form
                    frmFillInTheBlank frmFB = new frmFillInTheBlank(currentQuestion, currentGame.QuestionTimeLimit);
                    formResult = frmFB.ShowDialog();

                    answeredCorrectly = frmFB.Correct;
                    break;
                case "mc":
                    //call up multiple choice question form
                    frmMultipleChoice frmMC = new frmMultipleChoice(currentQuestion, currentGame.QuestionTimeLimit);
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

                //method to automatically move the teams along
                MoveToNextTeam();

                //If the game is done and every question has been answered
                //Then pull up frmWrongQuestions
                foreach (Category c in currentGame.Categories)
                {
                    foreach (Question q in c.Questions)
                    {
                        if (gameDone == false)
                        {
                            break;
                        }
                        if (q.State != "Answered")
                        {
                            gameDone = false;
                        }
                    }
                }

                //If the game is done, then pull up the review form
                if (gameDone == true)
                {
                    //show the frmWrongQuestions for statistics
                    frmReviewWrongQuestions frmRWQ = new frmReviewWrongQuestions(wrongQuestions, teams);
                    frmRWQ.ShowDialog();
                    //close the form
                    Close();
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

            int labelWidth = (pnlWidth - 60) / (currentGame.NumCategories);
            int labelHeight = 80;

            int start_x = 10;
            int start_y = 10;

            //For one row..
            for (int x = 0; x < 1; x++)
            {
                //Create as many labels as there are categories
                for (int y = 0; y < currentGame.NumCategories; y++)
                {
                    //Dynamically create a label with all the needed properties
                    Label tmpLabel = new Label();
                    tmpLabel.Top = start_x + (x * labelHeight);
                    tmpLabel.Left = start_y + ((y * labelWidth) + (y * 5));
                    tmpLabel.Width = labelWidth;
                    tmpLabel.Height = labelHeight;
                    tmpLabel.Text = currentGame.Categories[y].Title + '\n' + currentGame.Categories[y].Subtitle;
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

        private void DrawGameGrid()
        {
            //Have to clear the controls because we dynamically resize the buttons when the form resizes
            pnlGameboard.Controls.Clear();

            int gbxWidth = pnlGameboard.Width;
            int gbxHeight = pnlGameboard.Height;

            int buttonWidth = (gbxWidth - 80) / currentGame.NumCategories;
            int buttonHeight = (gbxHeight - 80) / currentGame.NumQuestionsPerCategory;

            int start_x = 30;
            int start_y = 30;
            
            questionButtons = new Button[currentGame.NumCategories, currentGame.NumQuestionsPerCategory];

            //draw blank buttons
            for (int x = 0; x < currentGame.NumCategories && x < currentGame.NumCategories; x++)
            {
                for (int y = 0; y < currentGame.NumQuestionsPerCategory; y++)
                {
                    //If the question has already been answered, don't make the button
                    if (currentGame.Categories[x].Questions[y].State != "Answered")
                    {
                        //Dynamically create each button with all the needed properties
                        Button tmpButton = new Button();
                        tmpButton.Tag = currentGame.Categories[x].Questions[y]; //send the entire question through the tag
                        tmpButton.Top = start_x + ((y * buttonHeight) + (y * 0));
                        tmpButton.Left = start_y + ((x * buttonWidth) + (x * 0));
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
            for (int i = 0; i < currentGame.NumCategories && i < currentGame.Categories.Count; i++)
            {
                for (int j = 0; j < currentGame.NumQuestionsPerCategory && j < currentGame.Categories[i].Questions.Count; j++)
                {
                    //If the question has already been answered, then it doesn't have a button to assign to the .Text property
                    if (currentGame.Categories[i].Questions[j].State != "Answered")
                    {
                        questionButtons[i, j].Text = currentGame.Categories[i].Questions[j].Weight.ToString();
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
            pnlCategories.Height = 100;

            pnlGameboard.Top = pnlCategories.Top + pnlCategories.Height;
            pnlGameboard.Height = Height - pnlGameboard.Top - 50;
        }

        private void LoadTeams()
        {
            //If the team isn't null, then set up the team name, and make it visible
            if (teams[0] != null)
            {
                pnlTeamOne.BackColor = Color.LightBlue;
                pnlTeamOne.Visible = true;

                if (teams[0].TeamName != "Team 1")
                {
                    lblTeamOne.Text = "Team 1\n" + teams[0].TeamName;
                }
            }

            if (teams[1] != null)
            {
                pnlTeamTwo.Visible = true;

                if (teams[1].TeamName != "Team 2")
                {
                    lblTeamTwo.Text = "Team 2\n" + teams[1].TeamName;
                }
            }

            if (teams[2] != null)
            {
                pnlTeamThree.Visible = true;

                if (teams[2].TeamName != "Team 3")
                {
                    lblTeamThree.Text = "Team 3\n" + teams[2].TeamName;
                }
            }

            if (teams[3] != null)
            {
                pnlTeamFour.Visible = true;

                if (teams[3].TeamName != "Team 4")
                {
                    lblTeamFour.Text = "Team 4\n" + teams[3].TeamName;
                }
            }
        }

        private void MoveToNextTeam()
        {
            //We assume there will always be at least two teams, so automatically move onto team two (team[1])
            if (currentTeam == teams[0])
            {
                currentTeam = teams[1];
                pnlTeamOne.BackColor = SystemColors.Control;
                pnlTeamTwo.BackColor = Color.LightBlue;
            }
            //The rest of these else ifs make sure the next team isn't null, and if they are, go back to team one (team[0])
            else if (currentTeam == teams[1])
            {
                if (teams[2] != null)
                {
                    currentTeam = teams[2];
                    pnlTeamTwo.BackColor = SystemColors.Control;
                    pnlTeamThree.BackColor = Color.LightBlue;
                }
                else
                {
                    currentTeam = teams[0];
                    pnlTeamOne.BackColor = Color.LightBlue;
                    pnlTeamTwo.BackColor = SystemColors.Control;
                }
            }
            else if (currentTeam == teams[2])
            {
                if (teams[3] != null)
                {
                    currentTeam = teams[3];
                    pnlTeamThree.BackColor = SystemColors.Control;
                    pnlTeamFour.BackColor = Color.LightBlue;
                }
                else
                {
                    currentTeam = teams[0];
                    pnlTeamOne.BackColor = Color.LightBlue;
                    pnlTeamThree.BackColor = SystemColors.Control;
                }
            }
            else if (currentTeam == teams[3])
            {
                currentTeam = teams[0];
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
                if (currentTeam == teams[0])
                {
                    nudTeamOne.Value += theQuestion.Weight;
                }
                else if (currentTeam == teams[1])
                {
                    nudTeamTwo.Value += theQuestion.Weight;
                }
                else if (currentTeam == teams[2])
                {
                    nudTeamThree.Value += theQuestion.Weight;
                }
                else if (currentTeam == teams[3])
                {
                    nudTeamFour.Value += theQuestion.Weight;
                }
            }
            else if (answeredCorrectly == false)
            {
                //Checks which team is the currentTeam, and takes away the points for answering it wrong
                if (currentTeam == teams[0])
                {
                    nudTeamOne.Value -= theQuestion.Weight;
                }
                else if (currentTeam == teams[1])
                {
                    nudTeamTwo.Value -= theQuestion.Weight;
                }
                else if (currentTeam == teams[2])
                {
                    nudTeamThree.Value -= theQuestion.Weight;
                }
                else if (currentTeam == teams[3])
                {
                    nudTeamFour.Value -= theQuestion.Weight;
                }
            }
        }

        private void frmPlayGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Resets all the questions' statuses if the game is closed
            foreach (Category c in currentGame.Categories)
            {
                foreach (Question q in c.Questions)
                {
                    q.State = "";
                }
            }
        }

        private void cboQuestionTimeLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Changes the time limit to whatever the user selected on the form
            if (cboQuestionTimeLimit.SelectedIndex == 0)
            {
                currentGame.QuestionTimeLimit = new TimeSpan(0, 0, 30);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 1)
            {
                currentGame.QuestionTimeLimit = new TimeSpan(0, 1, 0);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 2)
            {
                currentGame.QuestionTimeLimit = new TimeSpan(0, 1, 30);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 3)
            {
                currentGame.QuestionTimeLimit = new TimeSpan(0, 2, 0);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 4)
            {
                currentGame.QuestionTimeLimit = new TimeSpan(0, 3, 0);
            }
            bwUpdateTimeLimit.RunWorkerAsync();
        }

        private void bwUpdateTimeLimit_DoWork(object sender, DoWorkEventArgs e) //also update in db for future games
        {
            //Updates the database whenever the user changes the question time limit
            if (!DB_Update.UpdateGameQuestionTimeLimit(currentGame.QuestionTimeLimit, currentGame.Id))
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
            teams[0].Score = (int)nudTeamOne.Value;
            pnlGameboard.Focus();
        }

        private void nudTeamTwo_ValueChanged(object sender, EventArgs e)
        {
            //Assigns the team score to the value of the numeric up down on the form
            teams[1].Score = (int)nudTeamTwo.Value;
            pnlGameboard.Focus();
        }

        private void nudTeamThree_ValueChanged(object sender, EventArgs e)
        {
            //Assigns the team score to the value of the numeric up down on the form
            teams[2].Score = (int)nudTeamThree.Value;
            pnlGameboard.Focus();
        }

        private void nudTeamFour_ValueChanged(object sender, EventArgs e)
        {
            //Assigns the team score to the value of the numeric up down on the form
            teams[3].Score = (int)nudTeamFour.Value;
            pnlGameboard.Focus();
        }
    }
}

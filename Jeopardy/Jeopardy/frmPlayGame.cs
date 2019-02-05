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
    public partial class frmPlayGame : Form
    {
        int rows = 1;
        int columns = 1;
        Button[,] questionButtons;
        private List<Label> LabelList = new List<Label>();
        private Team[] teams = new Team[4];
        private Game currentGame = new Game();
        private Team currentTeam = new Team();

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
            ModifyPanelWidths();
            ModifyPanelHeights();
            DrawCategories();
            DrawGameGrid();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Question currentQuestion = (Question)button.Tag;
            bool answeredCorrectly = false;
            DialogResult formResult = DialogResult.Cancel;

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
            if(formResult == DialogResult.OK)
            {
                //hide the clicked button
                button.Visible = false;
                currentQuestion.State = "Answered";

                //method to assign score to the right team
                AssignPoints(answeredCorrectly, currentQuestion);

                //method to automatically move the teams along
                MoveToNextTeam();
            }
        }

        private void DrawCategories()
        {
            pnlCategories.Controls.Clear();

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

            for (int x = 0; x < 1; x++)
            {
                for (int y = 0; y < currentGame.NumCategories; y++)
                {
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

            foreach (Label l in LabelList)
            {
                pnlCategories.Controls.Add(l);
            }
        }

        private void DrawGameGrid()
        {
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
                    if (currentGame.Categories[x].Questions[y].State != "Answered")
                    {
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
                    if (currentGame.Categories[i].Questions[j].State != "Answered")
                    {
                        questionButtons[i, j].Text = currentGame.Categories[i].Questions[j].Weight.ToString();
                    }
                }
            }

            foreach (Button b in questionButtons)
            {
                pnlGameboard.Controls.Add(b);
            }

        }

        private void TmpButton_MouseEnter(object sender, EventArgs e)
        {
            Button hoveredButton = (Button)sender;
            hoveredButton.Focus();
            hoveredButton.BackColor = Color.Blue;
        }

        private void TmpButton_MouseLeave(object sender, EventArgs e)
        {
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
            if (teams[0] != null)
            {
                pnlTeamOne.Visible = true;
                pnlTeamOne.BackColor = Color.LightBlue;
                lblTeamOne.Text = "Team 1\n" + teams[0].TeamName;
                lblTeamOne.MaximumSize = new Size(250, 0);
                lblTeamOne.AutoSize = true;
            }

            if (teams[1] != null)
            {
                pnlTeamTwo.Visible = true;
                lblTeamTwo.Text = "Team 2\n" + teams[1].TeamName;
                lblTeamTwo.MaximumSize = new Size(250, 0);
                lblTeamTwo.AutoSize = true;
            }

            if (teams[2] != null)
            {
                pnlTeamThree.Visible = true;
                lblTeamThree.Text = "Team 3\n" + teams[2].TeamName;
                lblTeamThree.MaximumSize = new Size(250, 0);
                lblTeamThree.AutoSize = true;
            }

            if (teams[3] != null)
            {
                pnlTeamFour.Visible = true;
                lblTeamFour.Text = "Team 4\n" + teams[3].TeamName;
                lblTeamFour.MaximumSize = new Size(250, 0);
                lblTeamFour.AutoSize = true;
            }
        }

        private void MoveToNextTeam()
        {
            if (currentTeam == teams[0])
            {
                currentTeam = teams[1];
                pnlTeamOne.BackColor = SystemColors.Control;
                pnlTeamTwo.BackColor = Color.LightBlue;
            }
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
            if (answeredCorrectly == true)
            {
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
            if (!DB_Update.UpdateGameQuestionTimeLimit(currentGame.QuestionTimeLimit, currentGame.Id))
            {
                MessageBox.Show("Error updating Game name");
            }
        }

        //code to make maximizing and restoring the window act the same as resizing
        FormWindowState LastWindowState = FormWindowState.Minimized;
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
    }
}

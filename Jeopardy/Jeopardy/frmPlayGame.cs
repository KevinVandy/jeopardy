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
        //private List<Button> ButtonList = new List<Button>();
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
            DrawCategories();
            DrawForm();
        }

        private void frmPlayGame_ResizeEnd(object sender, EventArgs e)
        {
            ModifyPanelWidths();
            DrawCategories();
            DrawForm();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Question currentQuestion = (Question)button.Tag;
            MessageBox.Show(currentQuestion.QuestionText + " got clicked");
            bool answeredCorrectly = false;

            //TODO: call up the question form w/ the question passed
            switch (currentQuestion.Type)
            {
                case "tf":
                    //call up true/false question form
                    using (frmTrueFalse frmTFQuestion = new frmTrueFalse(currentQuestion))
                    {
                        frmTFQuestion.ShowDialog();

                        answeredCorrectly = frmTFQuestion.correct;
                    }
                    break;
                case "fb":
                    //call up fill in the blank question form
                    frmFillInTheBlank frmFB = new frmFillInTheBlank(currentQuestion);
                    frmFB.ShowDialog();

                    answeredCorrectly = frmFB.correct;
                    break;
                case "mc":
                    //call up multiple choice question form
                    break;
            }

            //hide the clicked button
            button.Visible = false;

            //method to assign score to the right team
            AssignPoints(answeredCorrectly, currentQuestion);

            //method to automatically move the teams along
            MoveToNextTeam();
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
                    LabelList.Add(tmpLabel);
                }
            }

            foreach (Label l in LabelList)
            {
                pnlCategories.Controls.Add(l);
            }
        }

        private void DrawForm()
        {
            //foreach (Button b in ButtonList)
            //{
            //    pnlGameboard.Controls.Remove(b);
            //}
            //ButtonList.Clear();
            ////int formWidth = this.Width;
            ////int formHeight = this.Height;
            //int formWidth = pnlGameboard.Width;
            //int formHeight = pnlGameboard.Height;

            ////This code scrunches the buttons
            ////pnlGameboard.Width = formWidth - 50;
            ////pnlGameboard.Height = formHeight - 70;


            //// Some default options, can change later
            //int ButtonWidth = (pnlGameboard.Width - 60) / (rows + 1);
            //int ButtonHeight = (pnlGameboard.Height - 30) / (columns - 1);
            //int Distance = 20;
            //int start_x = 10;
            //int start_y = 10;


            //// For each row..
            //for (int x = 0; x < rows; x++)
            //{
            //    // Create that many columns until you break out of for loop
            //    // Which in turn starts the next row
            //    for (int y = 0; y < columns; y++)
            //    {
            //        Button tmpButton = new Button();
            //        tmpButton.Top = start_x + (x * ButtonHeight + Distance);
            //        tmpButton.Left = start_y + (y * ButtonWidth + Distance);
            //        tmpButton.Width = ButtonWidth;
            //        tmpButton.Height = ButtonHeight;
            //        tmpButton.Click += new EventHandler(button_Click);
            //        tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();
            //        ButtonList.Add(tmpButton);

            //        // Add the buttons to the panel, not the form itself
            //        pnlGameboard.Controls.Add(tmpButton);
            //    }

            //}

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
                    Button tmpButton = new Button();
                    tmpButton.Tag = currentGame.Categories[x].Questions[y]; //send the entire question through the tag
                    tmpButton.Top = start_x + ((y * buttonHeight) + (y * 5));
                    tmpButton.Left = start_y + ((x * buttonWidth) + (x * 5));
                    tmpButton.Width = buttonWidth;
                    tmpButton.Height = buttonHeight;
                    tmpButton.Text = tmpButton.Tag.ToString();
                    tmpButton.Click += button_Click;

                    questionButtons[x, y] = tmpButton; //add button to array
                }
            }

            //add info to buttons (associate with actual question)
            for (int i = 0; i < currentGame.NumCategories && i < currentGame.Categories.Count; i++)
            {
                for (int j = 0; j < currentGame.NumQuestionsPerCategory && j < currentGame.Categories[i].Questions.Count; j++)
                {
                    questionButtons[i, j].Text = currentGame.Categories[i].Questions[j].Weight.ToString();
                    //currentGame.Categories[i].Questions[j].QuestionText.Trim();
                }
            }

            foreach (Button b in questionButtons)
            {
                pnlGameboard.Controls.Add(b);
            }

        }

        private void ModifyPanelWidths()
        {
            pnlCategories.Width = Width - 70;
            pnlGameboard.Width = Width - 70;
        }

        private void LoadTeams()
        {
            if(teams[0] != null)
            {
                pnlTeamOne.Visible = true;
                pnlTeamOne.BackColor = Color.LightBlue;
                lblTeamOne.Text = "Team " + teams[0].TeamName;
                lblTeamOne.MaximumSize = new Size(100, 0);
                lblTeamOne.AutoSize = true;              
            }

            if (teams[1] != null)
            {
                pnlTeamTwo.Visible = true;
                lblTeamTwo.Text = "Team " + teams[1].TeamName;
                lblTeamTwo.MaximumSize = new Size(100, 0);
                lblTeamTwo.AutoSize = true;
            }

            if (teams[2] != null)
            {
                pnlTeamThree.Visible = true;
                lblTeamThree.Text = "Team " + teams[2].TeamName;
                lblTeamThree.MaximumSize = new Size(100, 0);
                lblTeamThree.AutoSize = true;
            }

            if (teams[3] != null)
            {
                pnlTeamFour.Visible = true;
                lblTeamFour.Text = "Team " + teams[3].TeamName;
                lblTeamFour.MaximumSize = new Size(100, 0);
                lblTeamFour.AutoSize = true;
            }
        }

        private void MoveToNextTeam()
        {
            if(currentTeam == teams[0])
            {
                currentTeam = teams[1];
                pnlTeamOne.BackColor = SystemColors.Control;
                pnlTeamTwo.BackColor = Color.LightBlue;
            }
            else if(currentTeam == teams[1])
            {
                if(teams[2] != null)
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
            else if(currentTeam == teams[2])
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
            else if(currentTeam == teams[3])
            {
                currentTeam = teams[0];
                pnlTeamOne.BackColor = Color.LightBlue;
                pnlTeamFour.BackColor = SystemColors.Control;
            }
        }

        private void AssignPoints(bool answeredCorrectly, Question theQuestion)
        {
            if(answeredCorrectly == true)
            {
                if(currentTeam == teams[0])
                {
                    nudTeamOne.Value += theQuestion.Weight;
                }
                else if(currentTeam == teams[1])
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
    }
}

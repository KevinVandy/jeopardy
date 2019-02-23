using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmCreateGame : Form
    {
        private Game newGame = new Game();
        private int selectedQuestionTimeLimitIndex = 1; //start at default of 1 minute

        public frmCreateGame()
        {
            InitializeComponent();
        }

        private void frmCreateGameStart_Load(object sender, EventArgs e)
        {
            cboQuestionTimeLimit.SelectedIndex = selectedQuestionTimeLimitIndex;
            DrawPreview();
        }

        //MARK Value & Index Change Event Handlers
        private void cboQuestionTimeLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedQuestionTimeLimitIndex = cboQuestionTimeLimit.SelectedIndex;
        }

        private void nudNumCategories_ValueChanged(object sender, EventArgs e)
        {
            if (nudNumCategories.Value == 3)
            {
                lblDefault1.Text = "(Minimum)";
                lblDefault1.Visible = true;
            }
            else if (nudNumCategories.Value == 6)
            {
                lblDefault1.Text = "(Default)";
                lblDefault1.Visible = true;
            }
            else if (nudNumCategories.Value == 8)
            {
                lblDefault1.Text = "(Maximum)";
                lblDefault1.Visible = true;
            }
            else
            {
                lblDefault1.Visible = false;
            }

            DrawPreview();
            DisplayNumQuestions();
        }

        private void nudNumQuestionCategory_ValueChanged(object sender, EventArgs e)
        {
            if (nudNumQuestionCategory.Value == 3)
            {
                lblDefault2.Text = "(Minimum)";
                lblDefault2.Visible = true;
            }
            else if (nudNumQuestionCategory.Value == 5)
            {
                lblDefault2.Text = "(Default)";
                lblDefault2.Visible = true;
            }
            else if (nudNumQuestionCategory.Value == 8)
            {
                lblDefault2.Text = "(Maximum)";
                lblDefault2.Visible = true;
            }
            else
            {
                lblDefault2.Visible = false;
            }

            DrawPreview();
            DisplayNumQuestions();
        }

        //MARK Button Event Handlers
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!bwInsertGame.IsBusy) //prevents closing window when game is only half made
            {
                Close();
            }
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            string gameName = txtGameName.Text;
            int numCategories = (int)nudNumCategories.Value;
            int numQuestionsPerCat = (int)nudNumQuestionCategory.Value;

            if (ValidateData.ValidateGameName(gameName))
            {
                btnCreateGame.Text = "Creating Game";
                btnCreateGame.Enabled = false;

                newGame = new Game(null, gameName, new TimeSpan(0, 1, 0), numCategories, numQuestionsPerCat, null); //timespan gets overwritten
                newGame.CreateBlankGame(newGame.GameName, newGame.NumCategories, newGame.NumQuestionsPerCategory, selectedQuestionTimeLimitIndex);

                bwInsertGame.RunWorkerAsync(); //insert the game in a background thread to prevent the form from freezing
            }
            else
            {
                MessageBox.Show("Invalid Game Name");
            }
        }

        //creating the new blank game in the db can take a few seconds, so do it in a background thread
        private void bwInsertGame_DoWork(object sender, DoWorkEventArgs e)
        {
            DB_Insert.InsertGame(newGame);
        }

        //after creating the game, open the game to edit it
        private void bwInsertGame_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frmEditGame createGameForm = new frmEditGame(newGame);
            Hide();
            createGameForm.ShowDialog();
            Close();
        }

        private void DisplayNumQuestions()
        {
            lblNumQuestions.Text = CalcNumQuestions().ToString() + " Questions";
        }

        private int CalcNumQuestions()
        {
            return (int)nudNumCategories.Value * (int)nudNumQuestionCategory.Value;
        }

        private void DrawPreview()
        {
            pnlPreview.Controls.Clear();

            int top = 7;
            int left = 7;

            for (int c = 0; c < nudNumCategories.Value; c++)
            {
                for (int q = 0; q < nudNumQuestionCategory.Value; q++)
                {
                    PictureBox questionBox = new PictureBox();
                    questionBox.BackColor = Color.Yellow;
                    questionBox.Width = (pnlPreview.Width / (int)nudNumCategories.Value) - 12;
                    questionBox.Height = (pnlPreview.Height / (int)nudNumQuestionCategory.Value) - 12;
                    questionBox.Top = top;
                    questionBox.Left = left;

                    pnlPreview.Controls.Add(questionBox);

                    top += (questionBox.Height + 12);
                }
                top = 7;
                left += (pnlPreview.Width / (int)nudNumCategories.Value);                
            }
        }
    }
}

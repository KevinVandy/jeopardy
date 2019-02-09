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
        Game newGame = new Game();
        int selectedQuestionTimeLimitIndex = 1;

        public frmCreateGame()
        {
            InitializeComponent();
        }

        private void frmCreateGameStart_Load(object sender, EventArgs e)
        {
            cboQuestionTimeLimit.SelectedIndex = selectedQuestionTimeLimitIndex;
        }

        //MARK Value & Index Change Event Handlers
        private void cboQuestionTimeLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedQuestionTimeLimitIndex = cboQuestionTimeLimit.SelectedIndex;
        }

        private void nudNumCategories_ValueChanged(object sender, EventArgs e)
        {
            if (nudNumCategories.Value == 6)
            {
                lblDefault1.Visible = true;
            }
            else
            {
                lblDefault1.Visible = false;
            }
        }

        private void nudNumQuestionCategory_ValueChanged(object sender, EventArgs e)
        {
            if (nudNumQuestionCategory.Value == 5)
            {
                lblDefault2.Visible = true;
            }
            else
            {
                lblDefault2.Visible = false;
            }
        }
        
        //MARK Button Event Handlers
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!bwInsertGame.IsBusy) //prevents closing window when game is only half made
            {
                this.Close();
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

                newGame = new Game(null, gameName, new TimeSpan(0,1,0), numCategories, numQuestionsPerCat, null); //timespan gets overwritten
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
            this.Hide();
            createGameForm.ShowDialog();
            this.Close();
        }
    }
}

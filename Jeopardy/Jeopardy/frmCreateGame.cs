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

        public frmCreateGame()
        {
            InitializeComponent();
        }

        private void frmCreateGameStart_Load(object sender, EventArgs e)
        {
            cboQuestionTimeLimit.SelectedIndex = 1;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudNumCategories_ValueChanged(object sender, EventArgs e)
        {
            if(nudNumCategories.Value == 6)
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

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            string gameName = txtGameName.Text;
            int numCategories = (int)nudNumCategories.Value;
            int numQuestionsPerCat = (int)nudNumQuestionCategory.Value;

            if (ValidateData.ValidateGameName(gameName))
            {
                newGame = newGame.CreateGame(gameName, numCategories, numQuestionsPerCat, cboQuestionTimeLimit.SelectedIndex);

                frmEditGame createGameForm = new frmEditGame(newGame);
                createGameForm.Tag = newGame;
                this.Hide();
                createGameForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Game Name");
            }
        }

        private void bwCreateGame_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void bwCreateGame_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}

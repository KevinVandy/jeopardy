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
        Game newGame;

        public frmCreateGame()
        {
            InitializeComponent();
        }

        private void frmCreateGameStart_Load(object sender, EventArgs e)
        {
            cboQuestionTimeLimit.SelectedIndex = 1;
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            string gameName = txtGameName.Text;

            int numCategories = (int)nudNumCategories.Value;
            int numQuestionsPerCat = (int)nudNumQuestionCategory.Value;

            TimeSpan questionTimeLimit = new TimeSpan();
            if(cboQuestionTimeLimit.SelectedIndex == 0)
            {
                questionTimeLimit = new TimeSpan(0, 0, 30);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 1)
            {
                questionTimeLimit = new TimeSpan(0, 1, 0);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 2)
            {
                questionTimeLimit = new TimeSpan(0, 2, 0);
            }
            else if (cboQuestionTimeLimit.SelectedIndex == 3)
            {
                questionTimeLimit = new TimeSpan(0, 3, 0);
            }
            
            if (ValidateData.ValidateGameName(gameName))
            {
                newGame = new Game(null, gameName, questionTimeLimit, numCategories, numQuestionsPerCat, null);
                DB_Insert.InsertGame(newGame);
                frmEditGame createGameForm = new frmEditGame(newGame);
                this.Hide();
                createGameForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Game Name");
            }
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
    }
}

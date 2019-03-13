using System;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmTeams : Form
    {
        private Game game = new Game();

        public frmTeams(Game theGame)
        {
            game = theGame;
            InitializeComponent();
        }

        private void frmTeams_Load(object sender, EventArgs e)
        {
            btnExit.Enabled = false;
            btnOK.Enabled = false;
            bwLoadGame.RunWorkerAsync();
        }

        private void bwLoadGame_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            game = DB_Select.SelectGame_ByGameId(game.Id);
        }

        private void bwLoadGame_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            btnExit.Enabled = true;
            btnOK.Enabled = true;
        }

        private void nudNumberOfTeams_ValueChanged(object sender, EventArgs e)
        {
            //Grab the number from the numeric up down
            //And display the team textboxes based on that number
            int numberTeams = (int)nudNumberOfTeams.Value;
            DisplayPanels(numberTeams);
        }

        private void DisplayPanels(int numTeams)
        {
            //Display the teams
            if (numTeams == 2)
            {
                pnlFirstTeam.Visible = true;
                pnlSecondTeam.Visible = true;
                pnlThirdTeam.Visible = false;
                pnlFourthTeam.Visible = false;
            }
            else if (numTeams == 3)
            {
                pnlFirstTeam.Visible = true;
                pnlSecondTeam.Visible = true;
                pnlThirdTeam.Visible = true;
                pnlFourthTeam.Visible = false;
            }
            else if (numTeams >= 4)
            {
                pnlFirstTeam.Visible = true;
                pnlSecondTeam.Visible = true;
                pnlThirdTeam.Visible = true;
                pnlFourthTeam.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Creates teams based on the number in the numeric up down
        //Puts the teams into an array, and then passes it to the play game form
        private void btnOK_Click(object sender, EventArgs e)
        {
            game.Teams = new Team[4];
            int numberTeams = (int)nudNumberOfTeams.Value;
            
            if (numberTeams >= 1)
            {
                game.Teams[0] = new Team(1, txtFirstTeam.Text, 0);
            }
            if (numberTeams >= 2)
            {
                game.Teams[1] = new Team(2, txtSecondTeam.Text, 0);
            }
            if (numberTeams >= 3)
            {
                game.Teams[2] = new Team(3, txtThirdTeam.Text, 0);
            }
            if (numberTeams >= 4)
            {
                game.Teams[3] = new Team(4, txtFourthTeam.Text, 0);
            }

            if ((numberTeams >= 2 && Validation.ValidateTeamName(txtFirstTeam.Text) && Validation.ValidateTeamName(txtSecondTeam.Text))
             || (numberTeams >= 3 && Validation.ValidateTeamName(txtFirstTeam.Text) && Validation.ValidateTeamName(txtSecondTeam.Text) && Validation.ValidateTeamName(txtThirdTeam.Text))
             || (numberTeams >= 4 && Validation.ValidateTeamName(txtFirstTeam.Text) && Validation.ValidateTeamName(txtSecondTeam.Text) && Validation.ValidateTeamName(txtThirdTeam.Text) && Validation.ValidateTeamName(txtFourthTeam.Text)))
            {
                Hide();
                frmPlayGame playGameForm = new frmPlayGame(game);
                playGameForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You need to enter names for each team.", "Team Name Error");
            }
        }

        //Quality of Life stuff/methods
        private void txtFirstTeam_Enter(object sender, EventArgs e)
        {
            txtFirstTeam.SelectAll();
        }

        private void txtSecondTeam_Enter(object sender, EventArgs e)
        {
            txtSecondTeam.SelectAll();
        }

        private void txtThirdTeam_Enter(object sender, EventArgs e)
        {
            txtThirdTeam.SelectAll();
        }

        private void txtFourthTeam_Enter(object sender, EventArgs e)
        {
            txtFourthTeam.SelectAll();
        }

        private void frmTeams_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bwLoadGame.IsBusy) //don't close while reading database to prevent memory error
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}

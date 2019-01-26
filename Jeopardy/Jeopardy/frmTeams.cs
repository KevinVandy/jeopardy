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
    public partial class frmTeams : Form
    {
        //The design on this form could probably use some tidying up
        //But for what we need it works
        Game currentGame = new Game();
        List<Team> theTeams = new List<Team>();

        public frmTeams(Game theGame)
        {
            currentGame = theGame;
            InitializeComponent();
        }

        private void frmTeams_Load(object sender, EventArgs e)
        {

        }

        private void nudNumberOfTeams_ValueChanged(object sender, EventArgs e)
        {
            int numberTeams = (int)nudNumberOfTeams.Value;
            DisplayPanels(numberTeams);
        }

        private void DisplayPanels(int numTeams)
        {
            if(numTeams == 2)
            {
                pnlFirstTeam.Visible = true;
                pnlSecondTeam.Visible = true;
                pnlThirdTeam.Visible = false;
                pnlFourthTeam.Visible = false;
            }
            else if(numTeams == 3)
            {
                pnlFirstTeam.Visible = true;
                pnlSecondTeam.Visible = true;
                pnlThirdTeam.Visible = true;
                pnlFourthTeam.Visible = false;
            }
            else if(numTeams >= 4)
            {
                pnlFirstTeam.Visible = true;
                pnlSecondTeam.Visible = true;
                pnlThirdTeam.Visible = true;
                pnlFourthTeam.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int numberTeams = (int)nudNumberOfTeams.Value;

            if (numberTeams == 2)
            {
                if (ValidateData.ValidateTeamName(txtFirstTeam.Text) && ValidateData.ValidateTeamName(txtSecondTeam.Text))
                {
                    Team firstTeam = new Team(1, txtFirstTeam.Text, 0);
                    Team secondTeam = new Team(2, txtSecondTeam.Text, 0);

                    theTeams.Add(firstTeam);
                    theTeams.Add(secondTeam);

                    this.Hide();

                    frmPlayGame playGameForm = new frmPlayGame(currentGame, theTeams);
                    playGameForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You need to enter names for each team.", "Team Name Error");
                }
            }
            else if (numberTeams == 3)
            {
                if (ValidateData.ValidateTeamName(txtFirstTeam.Text) && ValidateData.ValidateTeamName(txtSecondTeam.Text) 
                    && ValidateData.ValidateTeamName(txtThirdTeam.Text))
                {
                    Team firstTeam = new Team(1, txtFirstTeam.Text, 0);
                    Team secondTeam = new Team(2, txtSecondTeam.Text, 0);
                    Team thirdTeam = new Team(3, txtThirdTeam.Text, 0);

                    theTeams.Add(firstTeam);
                    theTeams.Add(secondTeam);
                    theTeams.Add(thirdTeam);

                    this.Hide();

                    frmPlayGame playGameForm = new frmPlayGame(currentGame, theTeams);
                    playGameForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You need to enter names for each team.", "Team Name Error");
                }
            }
            else if (numberTeams >= 4)
            {
                if (ValidateData.ValidateTeamName(txtFirstTeam.Text) && ValidateData.ValidateTeamName(txtSecondTeam.Text) 
                    && ValidateData.ValidateTeamName(txtThirdTeam.Text) && ValidateData.ValidateTeamName(txtFourthTeam.Text))
                {
                    Team firstTeam = new Team(1, txtFirstTeam.Text, 0);
                    Team secondTeam = new Team(2, txtSecondTeam.Text, 0);
                    Team thirdTeam = new Team(3, txtThirdTeam.Text, 0);
                    Team fourthTeam = new Team(4, txtFourthTeam.Text, 0);

                    theTeams.Add(firstTeam);
                    theTeams.Add(secondTeam);
                    theTeams.Add(thirdTeam);
                    theTeams.Add(fourthTeam);

                    this.Hide();

                    frmPlayGame playGameForm = new frmPlayGame(currentGame, theTeams);
                    playGameForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You need to enter names for each team.", "Team Name Error");
                }
            }

        }

        
    }
}

using System;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmDoubleJeopardy : Form
    {
        private Question currentQuestion = new Question();
        private Team currentTeam = new Team();

        public frmDoubleJeopardy(Question theQuestion, Team theTeam)
        {
            currentQuestion = theQuestion;
            currentTeam = theTeam;
            InitializeComponent();
        }

        private void frmDoubleJeopardy_Load(object sender, EventArgs e)
        {
            //set min
            tbPoints.Minimum = 100 / 100;
            nudPoints.Minimum = 100;
            lblMin.Text = nudPoints.Minimum.ToString();

            //set max
            //If they have more than 1000 points, set the max to the teams score...
            //Otherwise set the max to 1000
            if (currentTeam.Score > 1000)
            {
                tbPoints.Maximum = currentTeam.Score / 100;
                nudPoints.Maximum = currentTeam.Score;
            }
            else if (currentTeam.Score <= 1000)
            {
                tbPoints.Maximum = 1000 / 100;
                nudPoints.Maximum = 1000;
            }

            //Update the max text on the form
            lblMax.Text = nudPoints.Maximum.ToString();

            //set value
            tbPoints.Value = currentQuestion.Weight / 100; //true daily double
            nudPoints.Value = tbPoints.Value * 100;
        }

        //MARK: Value & Index Change Events
        private void tbPoints_Scroll(object sender, EventArgs e)
        {
            nudPoints.Value = tbPoints.Value * 100;
            toolTip1.SetToolTip(tbPoints, (tbPoints.Value * 100).ToString());
        }

        private void nudPoints_ValueChanged(object sender, EventArgs e)
        {
            tbPoints.Value = (int)nudPoints.Value / 100;
        }

        //MARK: Button Event Handlers
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Pass the current question through the form's tag
            Tag = currentQuestion;
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Update the current questions weight based on what they selected for points
            currentQuestion.Weight = (int)nudPoints.Value;
            Tag = currentQuestion;
            Close();
        }
    }
}

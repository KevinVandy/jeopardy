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
    public partial class frmDoubleJeopardy : Form
    {
        Question currentQuestion = new Question();
        Team currentTeam = new Team();

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
            Tag = currentQuestion;
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            currentQuestion.Weight = (int)nudPoints.Value;
            Tag = currentQuestion;
            Close();
        }
    }
}

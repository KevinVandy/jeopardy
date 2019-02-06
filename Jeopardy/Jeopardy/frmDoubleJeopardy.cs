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
            if(currentTeam.Score > 1000)
            {
                tbPoints.Maximum = currentTeam.Score;
            }
            else if(currentTeam.Score <= 1000)
            {
                tbPoints.Maximum = 1000;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Tag = currentQuestion;
            this.Close();
        }

        private void tbPoints_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tbPoints, tbPoints.Value.ToString());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //The Weight setter in the Question class doesn't work for anything thats not
            // 100, 200, 300, 400, 500, 600, 700, 800
            // We'll have to change that for this to work
            currentQuestion.Weight = tbPoints.Value;
            this.Tag = currentQuestion;
            this.Close();
        }
    }
}

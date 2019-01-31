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
    public partial class frmTrueFalse : Form
    {
        public bool correct { get; set; }

        Question question;
        

        public frmTrueFalse(Question question)
        {
            this.question = question;
            InitializeComponent();
        }

        

        private void frmTrueFalse_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = question.QuestionText.ToString();
            lblCorrectAnswer.Text = question.Answer;
        }

        private async void btnTrue_Click(object sender, EventArgs e)
        {
            if (question.Answer == "True") 
            {
                correct = true;
                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.ForeColor = Color.ForestGreen;
                await Task.Delay(3000); //show the answer for a bit              
            }
            else{
                correct = false;
                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.ForeColor = Color.Red;
                await Task.Delay(3000); //show the answer for a bit               
            }

            this.Close();
        }

        private async void btnFalse_Click(object sender, EventArgs e)
        {
            if (question.Answer == "False")
            {
                correct = true;
                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.ForeColor = Color.ForestGreen;
                await Task.Delay(3000); //show the answer for a bit
            }
            else
            {
                correct = false;
                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.ForeColor = Color.Red;
                await Task.Delay(3000); //show the answer for a bit
            }

            this.Close();
        }
    }
}

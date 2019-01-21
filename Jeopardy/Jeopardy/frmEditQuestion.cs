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
    public partial class frmEditQuestion : Form
    {
        public frmEditQuestion()
        {
            InitializeComponent();
        }

        private void frmEditQuestion_Load(object sender, EventArgs e)
        {
            rdoFillInTheBlank.Checked = true;
        }

        private void rdoType_Change(object sender, EventArgs e)
        {
            if (rdoFillInTheBlank.Checked)
            {
                rdoChoiceA.Checked = false;
                rdoChoiceB.Checked = false;
                rdoChoiceC.Checked = false;
                rdoChoiceD.Checked = false;

                rdoChoiceA.Text = "";
                rdoChoiceB.Text = "";
                rdoChoiceC.Text = "";
                rdoChoiceD.Text = "";

                rdoChoiceA.Enabled = false;
                rdoChoiceB.Enabled = false;
                rdoChoiceC.Enabled = false;
                rdoChoiceD.Enabled = false;

                txtChoiceA.Text = "";
                txtChoiceB.Text = "";
                txtChoiceC.Text = "";
                txtChoiceD.Text = "";

                txtChoiceA.Enabled = false;
                txtChoiceB.Enabled = false;
                txtChoiceC.Enabled = false;
                txtChoiceD.Enabled = false;

                txtAnswer.Enabled = true;
            }
            else if (rdoMultipleChoice.Checked)
            {
                rdoChoiceA.Checked = false;
                rdoChoiceB.Checked = false;
                rdoChoiceC.Checked = false;
                rdoChoiceD.Checked = false;

                rdoChoiceA.Text = "a";
                rdoChoiceB.Text = "b";
                rdoChoiceC.Text = "c";
                rdoChoiceD.Text = "d";

                rdoChoiceA.Enabled = true;
                rdoChoiceB.Enabled = true;
                rdoChoiceC.Enabled = true;
                rdoChoiceD.Enabled = true;

                txtChoiceA.Text = "";
                txtChoiceB.Text = "";
                txtChoiceC.Text = "";
                txtChoiceD.Text = "";

                txtChoiceA.Enabled = true;
                txtChoiceB.Enabled = true;
                txtChoiceC.Enabled = true;
                txtChoiceD.Enabled = true;

                txtAnswer.Enabled = false;
            }
            else if (rdoTrueFalse.Checked)
            {
                rdoChoiceA.Checked = false;
                rdoChoiceB.Checked = false;
                rdoChoiceC.Checked = false;
                rdoChoiceD.Checked = false;

                rdoChoiceA.Text = "T";
                rdoChoiceB.Text = "";
                rdoChoiceC.Text = "F";
                rdoChoiceD.Text = "";

                rdoChoiceA.Enabled = true;
                rdoChoiceB.Enabled = false;
                rdoChoiceC.Enabled = true;
                rdoChoiceD.Enabled = false;
                
                txtChoiceA.Text = "True";
                txtChoiceB.Text = "";
                txtChoiceC.Text = "False";
                txtChoiceD.Text = "";

                txtChoiceA.Enabled = false;
                txtChoiceB.Enabled = false;
                txtChoiceC.Enabled = false;
                txtChoiceD.Enabled = false;

                txtAnswer.Enabled = false;
            }

        }

        
    }
}

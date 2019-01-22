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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            frmPlayGame playGameForm = new frmPlayGame();
            playGameForm.ShowDialog();
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            frmCreateGame createGameForm = new frmCreateGame();
            createGameForm.Text = "Create a Game!";
            createGameForm.ShowDialog();
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            frmCreateGame createGameForm = new frmCreateGame();
            createGameForm.Text = "Edit a Game!";
            createGameForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form help = new frmHelp();
            help.ShowDialog();
        }

        private void importGameFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

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

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            // Instantiates the play game form
            frmPlayGame playGameForm = new frmPlayGame();

            // Show the play game form
            playGameForm.ShowDialog();
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            // Instantiates the create game form
            frmCreateGame createGameForm = new frmCreateGame();

            // Show the create game form
            createGameForm.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }
    }
}

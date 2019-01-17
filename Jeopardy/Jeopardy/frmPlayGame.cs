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
    public partial class frmPlayGame : Form
    {
        public frmPlayGame()
        {
            InitializeComponent();
        }

        private void frmPlayGame_Load(object sender, EventArgs e)
        {
            // Some default options, can change later
            int ButtonWidth = 170;
            int ButtonHeight = 140;
            int Distance = 20;
            int start_x = 10;
            int start_y = 10;

            // rows and columns, will be passed in later
            // Just some defaults for now
            int rows = 5;
            int columns = 6;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();
                    // Possible add Buttonclick event etc..
                    //this.Controls.Add(tmpButton);
                    pnlGameboard.Controls.Add(tmpButton);
                }

            }

            pnlGameboard.AutoSize = true;
            this.AutoSize = true;

            this.WindowState = FormWindowState.Maximized;
        }
    }
}

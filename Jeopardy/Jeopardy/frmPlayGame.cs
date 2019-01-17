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
            int ButtonWidth = 170;
            int ButtonHeight = 140;

            // These will eventually be passed in
            int rows = 6;
            int columns = 5;

            // Some default values, will need to autosize later on
            int Distance = 25;
            int start_x = 0;
            int start_y = 0;

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();
                    // Possible add Buttonclick event etc..
                    this.Controls.Add(tmpButton);
                }

            }

            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
        }
    }
}

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
    public partial class frmTest : Form
    {
        int rows = 5;
        int columns = 6;
        private List<Button> ButtonList = new List<Button>();
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            Validator.IsInteger("12");
            DrawForm();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(button.Text.ToString() + " got clicked");
        }

        private void frmTest_Resize(object sender, System.EventArgs e)
        {
            DrawForm();
        }

        private void DrawForm()
        {
            foreach (Button b in ButtonList)
            {
                pnlGameBoard.Controls.Remove(b);
            }
            ButtonList.Clear();
            int formWidth = this.Width;
            int formHeight = this.Height;
            pnlGameBoard.Width = formWidth - 50;
            pnlGameBoard.Height = formHeight - 70;

            // Some default options, can change later
            int ButtonWidth = (pnlGameBoard.Width - 60) / (rows +1);
            int ButtonHeight = (pnlGameBoard.Height - 30) / (columns -1);
            int Distance = 20;
            int start_x = 10;
            int start_y = 10;


            // For each row..
            for (int x = 0; x < rows; x++)
            {
                // Create that many columns until you break out of for loop
                // Which in turn starts the next row
                for (int y = 0; y < columns; y++)
                {
                    Button tmpButton = new Button();
                    ButtonList.Add(tmpButton);
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Click += new EventHandler(button_Click);
                    tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();

                    // Possible add Buttonclick event etc..
                    //this.Controls.Add(tmpButton);

                    // Add the buttons to the panel, not the form itself
                    pnlGameBoard.Controls.Add(tmpButton);
                }

            }
        }

    }
}

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
        int rows = 5;
        int columns = 6;
        private List<Button> ButtonList = new List<Button>();

        // Dummy Data for creating dynamic labels for categories
        //private List<Label> LabelList = new List<Label>();
        //private List<Category> Categories = new List<Category>();
        //private Game theGame = new Game();
        //private TimeSpan theTime = new TimeSpan(0, 10, 0);
        //private Category cat1 = new Category(1, 1, "Category 1", "Sub 1", null);
        //private Category cat2 = new Category(2, 1, "Category 2", "Sub 2", null);
        //private Category cat3 = new Category(3, 1, "Category 3", "Sub 3", null);
        //private Category cat4 = new Category(4, 1, "Category 4", "Sub 4", null);

        public frmPlayGame()
        {
            InitializeComponent();
        }

        private void frmPlayGame_Load(object sender, EventArgs e)
        {         
            //DrawCategories();
            DrawForm();
        }

        private void frmPlayGame_ResizeEnd(object sender, EventArgs e)
        {
            //Had to add this here instead of form load because frmPlayGame_Resize is prioritized over form load
            //Categories.Add(cat1);
            //Categories.Add(cat2);
            //Categories.Add(cat3);
            //Categories.Add(cat4);
            //theGame = new Game(1, "Test Game", theTime, Categories);

            //DrawCategories();
            DrawForm();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(button.Text.ToString() + " got clicked");
        }

        //private void DrawCategories()
        //{
        //    pnlCategories.Controls.Clear();

        //    if (LabelList != null)
        //    {
        //        LabelList.Clear();
        //    }

        //    int pnlWidth = pnlCategories.Width;
        //    int pnlHeight = pnlCategories.Height;

        //    int buttonWidth = (pnlWidth - 80) / (theGame.Categories.Count);
        //    int buttonHeight = 80;

        //    int start_x = 10;
        //    int start_y = 10;

        //    for (int x = 0; x < 1; x++)
        //    {
        //        for (int y = 0; y < theGame.Categories.Count; y++)
        //        {
        //            Label tmpLabel = new Label();
        //            tmpLabel.Top = start_x + (x * buttonHeight);
        //            tmpLabel.Left = start_y + ((y * buttonWidth) + (y * 5));
        //            tmpLabel.Width = buttonWidth;
        //            tmpLabel.Height = buttonHeight;
        //            tmpLabel.Text = theGame.Categories[y].Title + '\n' + theGame.Categories[y].Subtitle;
        //            tmpLabel.TextAlign = ContentAlignment.MiddleCenter;
        //            tmpLabel.Font = new Font("Arial", 18, FontStyle.Bold);
        //            LabelList.Add(tmpLabel);
        //        }
        //    }

        //    foreach (Label l in LabelList)
        //    {
        //        pnlCategories.Controls.Add(l);
        //    }
        //}

        private void DrawForm()
        {
            foreach (Button b in ButtonList)
            {
                pnlGameboard.Controls.Remove(b);
            }
            ButtonList.Clear();
            int formWidth = this.Width;
            int formHeight = this.Height;
            pnlGameboard.Width = formWidth - 50;
            pnlGameboard.Height = formHeight - 70;

            // Some default options, can change later
            int ButtonWidth = (pnlGameboard.Width - 60) / (rows + 1);
            int ButtonHeight = (pnlGameboard.Height - 30) / (columns - 1);
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
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Click += new EventHandler(button_Click);
                    tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();
                    ButtonList.Add(tmpButton);

                    // Add the buttons to the panel, not the form itself
                    pnlGameboard.Controls.Add(tmpButton);
                }

            }
        }

        //code to make maximizing and restoring the window act the same as resizing
        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void frmPlayGame_Resize(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {
                    frmPlayGame_ResizeEnd(sender, e);
                }
                if (WindowState == FormWindowState.Normal)
                {
                    frmPlayGame_ResizeEnd(sender, e);
                }
            }
        }
    }
}

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
        int rows = 1;
        int columns = 1;
        private List<Button> ButtonList = new List<Button>();
        private List<Label> LabelList = new List<Label>();
        private List<Team> teams = new List<Team>();
        private Game currentGame = new Game();

        public frmPlayGame(Game theGame, List<Team> theTeams)
        {
            currentGame = theGame;
            teams = theTeams;
            rows = currentGame.NumQuestionsPerCategory;
            columns = currentGame.NumCategories;
            InitializeComponent();
        }

        private void frmPlayGame_Load(object sender, EventArgs e)
        {
            ModifyPanelWidths();
            DrawCategories();
            DrawForm();
        }

        private void frmPlayGame_ResizeEnd(object sender, EventArgs e)
        {
            ModifyPanelWidths();
            DrawCategories();
            DrawForm();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(button.Text.ToString() + " got clicked");
        }

        private void DrawCategories()
        {
            pnlCategories.Controls.Clear();

            if (LabelList != null)
            {
                LabelList.Clear();
            }

            int pnlWidth = pnlCategories.Width;
            int pnlHeight = pnlCategories.Height;

            int labelWidth = (pnlWidth - 60) / (currentGame.NumCategories);
            int labelHeight = 80;

            int start_x = 10;
            int start_y = 10;

            for (int x = 0; x < 1; x++)
            {
                for (int y = 0; y < currentGame.NumCategories; y++)
                {
                    Label tmpLabel = new Label();
                    tmpLabel.Top = start_x + (x * labelHeight);
                    tmpLabel.Left = start_y + ((y * labelWidth) + (y * 5));
                    tmpLabel.Width = labelWidth;
                    tmpLabel.Height = labelHeight;
                    //tmpLabel.Text = currentGame.Categories[y].Title + '\n' + currentGame.Categories[y].Subtitle;
                    tmpLabel.Text = "Category " + (y + 1);
                    tmpLabel.TextAlign = ContentAlignment.MiddleCenter;
                    tmpLabel.Font = new Font("Arial", 18, FontStyle.Bold);
                    LabelList.Add(tmpLabel);
                }
            }

            foreach (Label l in LabelList)
            {
                pnlCategories.Controls.Add(l);
            }
        }

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

        private void ModifyPanelWidths()
        {
            pnlCategories.Width = Width - 70;
            pnlGameboard.Width = Width - 70;
        }
    }
}

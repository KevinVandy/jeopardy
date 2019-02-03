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
    public partial class frmImportQuestion : Form
    {
        List<Game> allGames;
        public Question selectedQuestion; //This will get returned to the main edit question form because it is a public property

        public frmImportQuestion()
        {
            InitializeComponent();
        }

        private void frmImportQuestion_Load(object sender, EventArgs e)
        {
            bwLoadGames.RunWorkerAsync(); //start thread to load games
            btnImport.Enabled = false;
        }

        //Load all of the games in the background
        private void bwLoadGames_DoWork(object sender, DoWorkEventArgs e)
        {
            allGames = DB_Select.SelectAllGames();
        }

        //After all of the games have loaded, show them in the list box
        private void bwLoadGames_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Game g in allGames)
            {
                lstGames.Items.Add(g.GameName);
            }
        }

        //After the user selects a game in the first list box, show the categories in that game
        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCategories.Items.Clear();
            if (lstGames.SelectedIndex != -1)
            {
                foreach (Category c in allGames[lstGames.SelectedIndex].Categories)
                {
                    lstCategories.Items.Add(c.Title + " - " + c.Subtitle);
                }
            }
        }

        //After the user selects a category in the second list box, show each question in that game
        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvQuestions.Items.Clear();
            if (lstCategories.SelectedIndex != -1)
            {
                foreach (Question q in allGames[lstGames.SelectedIndex].Categories[lstCategories.SelectedIndex].Questions)
                {
                    string type = "";
                    switch (q.Type)
                    {
                        case "fb": type = "Fill in the Blank"; break;
                        case "mc": type = "Multiple Choice"; break;
                        case "tf": type = "True / False"; break;
                    }
                    ListViewItem lvi = new ListViewItem(type);
                    lvi.SubItems.Add(q.QuestionText);
                    lvi.SubItems.Add(q.Answer);

                    lsvQuestions.Items.Add(lvi);
                }
            }
            if (lsvQuestions.SelectedIndices.Count > 0)
            {
                btnImport.Enabled = true;
            }
            else
            {
                btnImport.Enabled = false;
            }
        }

        private void lsvQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvQuestions.SelectedIndices.Count > 0)
            {
                btnImport.Enabled = true;
            }
            else
            {
                btnImport.Enabled = false;
            }
        }

        //MARK: Button Event Handlers
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lstGames.SelectedIndex != -1 && lstCategories.SelectedIndex != -1 && lsvQuestions.SelectedIndices.Count > 0)
            {
                selectedQuestion = allGames[lstGames.SelectedIndex].Categories[lstCategories.SelectedIndex].Questions[lsvQuestions.SelectedIndices[0]];

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectedQuestion = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

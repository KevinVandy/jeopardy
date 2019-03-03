using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmImportCategory : Form
    {
        private List<Game> allGames;

        public Category SelectedCategory; //other form sees this

        public frmImportCategory()
        {
            InitializeComponent();
        }

        private void frmImportCategory_Load(object sender, EventArgs e)
        {
            bwLoadGames.RunWorkerAsync();
            btnImport.Enabled = false;
        }

        private void bwLoadGames_DoWork(object sender, DoWorkEventArgs e)
        {
            if (allGames == null)
            {
                allGames = DB_Select.SelectAllGames();
            }
        }

        //After all of the games have loaded, show them in the list box
        private void bwLoadGames_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (allGames != null && allGames.Count > 0)
            {
                foreach (Game g in allGames)
                {
                    lstGames.Items.Add(g.GameName);
                }
                lstGames.Enabled = true;
            }
            else
            {
                lstGames.Items.Add("No games");
                lstGames.SelectedIndex = -1;
                lstGames.Enabled = false;
                lstCategories.Enabled = false;
                lsvQuestions.Enabled = false;
            }
            lblCloseWarning.Hide();
        }

        //After the user selects a game in the first list box, show the categories in that game
        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCategories.Items.Clear();
            if (lstGames.SelectedIndex != -1)
            {
                if (allGames[lstGames.SelectedIndex].Categories != null && allGames[lstGames.SelectedIndex].Categories.Count > 0)
                {
                    foreach (Category c in allGames[lstGames.SelectedIndex].Categories)
                    {
                        lstCategories.Items.Add(c.Title + " - " + c.Subtitle);
                    }
                    lstCategories.Enabled = true;
                }
                else
                {
                    lstCategories.Items.Add("No categories");
                    lstCategories.SelectedIndex = -1;
                    lstCategories.Enabled = false;
                    lsvQuestions.Enabled = false;
                }
            }
            if (lstCategories.SelectedIndex != -1)
            {
                btnImport.Enabled = true;
            }
            else
            {
                btnImport.Enabled = false;
                lsvQuestions.Items.Clear();
            }
        }

        //After the user selects a category in the second list box, show each question in that game
        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvQuestions.Items.Clear();
            if (lstCategories.SelectedIndex != -1)
            {
                if (allGames[lstGames.SelectedIndex].Categories[lstCategories.SelectedIndex].Questions != null && allGames[lstGames.SelectedIndex].Categories[lstCategories.SelectedIndex].Questions.Count > 0)
                {
                    foreach (Question q in allGames[lstGames.SelectedIndex].Categories[lstCategories.SelectedIndex].Questions)
                    {
                        if (q.QuestionText.Trim() != "") //only add non-blank questions
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
                            lvi.Checked = true;
                            lsvQuestions.Items.Add(lvi);
                        }
                    }
                    lsvQuestions.Enabled = true;
                }
                else
                {
                    lsvQuestions.Enabled = false;
                }

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
            if (lstGames.SelectedIndex != -1 && lstCategories.SelectedIndex != -1)
            {
                SelectedCategory = allGames[lstGames.SelectedIndex].Categories[lstCategories.SelectedIndex];

                if (cbxQuestions.Checked) //only import the questions associated with this category if checked
                {
                    List<Question> selectedQuestions = new List<Question>();
                    //only add in the ones that are checked
                    for (int i = 0; i < lsvQuestions.Items.Count; i++)
                    {
                        if (lsvQuestions.Items[i].Checked) //only import a specific question if it is checked
                        {
                            selectedQuestions.Add(allGames[lstGames.SelectedIndex].Categories[lstCategories.SelectedIndex].Questions[i]);
                        }
                    }
                    SelectedCategory.Questions = selectedQuestions;
                }
                else //don't return any quesions if the user only wanted the title and subtitle info
                {
                    SelectedCategory.Questions = new List<Question>();
                }

                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedCategory = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //MARK: Menu Bar Item Event Handlers
        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_Conn.OpenHelpFile();
        }

        private void frmImportCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bwLoadGames.IsBusy)
            {
                lblCloseWarning.Show();
                e.Cancel = true;
            }
            else
            {
                lblCloseWarning.Hide();
                e.Cancel = false;
            }
        }
    }
}

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
        

        public frmImportQuestion()
        {
            InitializeComponent();
        }

        private void frmImportQuestion_Load(object sender, EventArgs e)
        {
            bwLoadGames.RunWorkerAsync();
        }

        private void bwLoadGames_DoWork(object sender, DoWorkEventArgs e)
        {
            allGames = DB_Select.SelectAllGames();
        }

        private void bwLoadGames_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(Game g in allGames)
            {
                lstGames.Items.Add(g.GameName);
            }
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCategories.Items.Clear();
            if(lstGames.SelectedIndex != -1)
            {
                foreach(Category c in allGames[lstGames.SelectedIndex].Categories)
                {
                    lstCategories.Items.Add(c.Title + " - " + c.Subtitle);
                }
            }
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvQuestions.Items.Clear();
            if (lstCategories.SelectedIndex != -1)
            {
                foreach (Question q in allGames[lstGames.SelectedIndex].Categories[lstCategories.SelectedIndex].Questions)
                {
                    ListViewItem lvi = new ListViewItem(q.Type);
                    lvi.SubItems.Add(q.QuestionText);
                    lvi.SubItems.Add(q.Answer);

                    lsvQuestions.Items.Add(lvi);
                }
            }
        }
        

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        
    }
}

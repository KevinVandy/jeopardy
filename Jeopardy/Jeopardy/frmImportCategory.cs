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
    public partial class frmImportCategory : Form
    {
        List<Game> allGames;
        Game selectedGame;
        Category selectedCategory;

        public frmImportCategory()
        {
            InitializeComponent();
        }

        private void frmImportCategory_Load(object sender, EventArgs e)
        {
            bwLoadGames.RunWorkerAsync();
        }

        private void bwLoadGames_DoWork(object sender, DoWorkEventArgs e)
        {
            allGames = DB_Select.SelectAllGames();
        }

        private void bwLoadGames_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowGames();
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstGames.SelectedIndex != -1)
            {
                selectedGame = allGames[lstGames.SelectedIndex];
                ShowCategories();
            }
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = selectedGame.Categories[lstCategories.SelectedIndex];

            ShowQuestions();
        }

        private void ShowGames()
        {
            lstGames.Items.Clear();

            foreach(Game g in allGames)
            {
                lstGames.Items.Add(g.GameName);
            }

        }

        private void ShowCategories()
        {
            lstCategories.Items.Clear();
        }

        private void ShowQuestions()
        {

        }

        private void Import_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

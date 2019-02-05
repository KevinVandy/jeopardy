using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmMain : Form
    {
        List<Game> allGames;
        Game selectedGame;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bwLoadGames.RunWorkerAsync(); //start background thread to load games

            newGameToolStripMenuItem.Enabled = true;
            editGameToolStripMenuItem.Enabled = false;
            deleteGameToolStripMenuItem.Enabled = false;
            importGameFromFileToolStripMenuItem.Enabled = true;
            exportGameToFileToolStripMenuItem.Enabled = false;

            btnPlayGame.Enabled = false;
            btnCreateGame.Enabled = true;
            btnEditGame.Enabled = false;
            btnDeleteGame.Enabled = false;
            btnImportGame.Enabled = true;
            btnExportGame.Enabled = false;
        }

        //Load the game list in a background thread so it does not freeze the form
        private void bwLoadGames_DoWork(object sender, DoWorkEventArgs e)
        {
            allGames = DB_Select.SelectAllGames();
        }

        //Show the games in the list box once the background thread has finished loading the games
        private void bwLoadGames_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            lstGamesFromDB.Items.Clear();
            foreach (Game g in allGames)
            {
                lstGamesFromDB.Items.Add(g.GameName);
            }
            lstGamesFromDB_SelectedIndexChanged(null, null); //trigger select Index changed behaviour
        }

        private void lstGamesFromDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGamesFromDB.SelectedIndex != -1)
            {
                selectedGame = allGames[lstGamesFromDB.SelectedIndex];

                newGameToolStripMenuItem.Enabled = true;
                editGameToolStripMenuItem.Enabled = true;
                deleteGameToolStripMenuItem.Enabled = true;
                importGameFromFileToolStripMenuItem.Enabled = true;
                exportGameToFileToolStripMenuItem.Enabled = true;

                btnPlayGame.Enabled = true;
                btnCreateGame.Enabled = true;
                btnEditGame.Enabled = true;
                btnDeleteGame.Enabled = true;
                btnImportGame.Enabled = true;
                btnExportGame.Enabled = true;

                btnPlayGame.Focus();
            }
            else //disable buttons that need a game to be selected to work
            {
                newGameToolStripMenuItem.Enabled = true;
                editGameToolStripMenuItem.Enabled = false;
                deleteGameToolStripMenuItem.Enabled = false;
                importGameFromFileToolStripMenuItem.Enabled = true;
                exportGameToFileToolStripMenuItem.Enabled = false;

                btnPlayGame.Enabled = false;
                btnCreateGame.Enabled = true;
                btnEditGame.Enabled = false;
                btnDeleteGame.Enabled = false;
                btnImportGame.Enabled = true;
                btnExportGame.Enabled = false;
            }
        }
        
        //MARK Button Event Handlers
        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            frmTeams teamsForm = new frmTeams(selectedGame);
            this.Hide();
            teamsForm.ShowDialog();
            this.Show();
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            frmCreateGame createGameForm = new frmCreateGame();
            createGameForm.Text = "Create a Game!";
            this.Hide();
            createGameForm.ShowDialog();
            this.Show();
            if (!bwLoadGames.IsBusy)
            {
                bwLoadGames.RunWorkerAsync();
                RefreshListBox();
            } 
            
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            frmEditGame createGameForm = new frmEditGame(selectedGame);
            createGameForm.Tag = selectedGame;
            createGameForm.Text = "Edit a Game!";
            this.Hide();
            createGameForm.ShowDialog();
            this.Show();
            bwLoadGames.RunWorkerAsync();
            RefreshListBox();
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            int numRows = DB_Delete.DeleteGame(selectedGame.Id);
            bwLoadGames.RunWorkerAsync();
        }

        private void btnExportGame_Click(object sender, EventArgs e)
        {
            XML_IO.exportXML(selectedGame);
        }
        
        private void btnImportGame_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
                { 
                    if(Path.GetExtension(fbd.FileName) == ".xml")
                    {
                        string fileName = Path.GetFileNameWithoutExtension(fbd.FileName);
                        XML_IO.importXML(fbd.FileName, fileName);
                    }
                    else
                    {
                        MessageBox.Show("File Needs To Be .xml");
                    }
                }

                allGames = DB_Select.SelectAllGames();
                RefreshListBox();

            }
        }

        //MARK Tool Strip Event Handlers - Most of these just trigger the associated button event handlers
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreateGame_Click(sender, e);
        }

        private void editGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditGame_Click(sender, e);
        }

        private void deleteGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteGame_Click(sender, e);
        }

        private void importGameFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnImportGame_Click(sender, e);
        }

        private void exportGameToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditGame_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }

    }
}

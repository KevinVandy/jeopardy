﻿using System;
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
            bwLoadGames.RunWorkerAsync();

            btnPlayGame.Enabled = false;
            btnCreateGame.Enabled = true;
            btnEditGame.Enabled = false;
            btnDeleteGame.Enabled = false;
        }

        private void bwLoadGames_DoWork(object sender, DoWorkEventArgs e)
        {
            allGames = DB_Select.SelectAllGames();
        }

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
            lstGamesFromDB_SelectedIndexChanged(null, null);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }

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
            bwLoadGames.RunWorkerAsync();
            RefreshListBox();
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
            XML_Export.exportXML(selectedGame);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form help = new frmHelp();
            help.ShowDialog();
        }

        private void importGameFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lstGamesFromDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstGamesFromDB.SelectedIndex != -1)
            {
                selectedGame = allGames[lstGamesFromDB.SelectedIndex];

                btnPlayGame.Enabled = true;
                btnCreateGame.Enabled = true;
                btnEditGame.Enabled = true;
                btnDeleteGame.Enabled = true;
            }
            else
            {
                btnPlayGame.Enabled = false;
                btnCreateGame.Enabled = true;
                btnEditGame.Enabled = false;
                btnDeleteGame.Enabled = false;
            }
        }

        
    }
}

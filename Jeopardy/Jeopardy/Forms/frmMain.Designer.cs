namespace Jeopardy
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.lstGamesFromDB = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importGameFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportGameToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditGame = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.bwLoadGames = new System.ComponentModel.BackgroundWorker();
            this.btnExportGame = new System.Windows.Forms.Button();
            this.btnImportGame = new System.Windows.Forms.Button();
            this.bwLoadGameToPlay = new System.ComponentModel.BackgroundWorker();
            this.bwLoadGameToEdit = new System.ComponentModel.BackgroundWorker();
            this.bwLoadGameToExport = new System.ComponentModel.BackgroundWorker();
            this.bwDeleteGame = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.Location = new System.Drawing.Point(359, 62);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(287, 56);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "New Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.Location = new System.Drawing.Point(48, 296);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(287, 134);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // lstGamesFromDB
            // 
            this.lstGamesFromDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGamesFromDB.FormattingEnabled = true;
            this.lstGamesFromDB.ItemHeight = 24;
            this.lstGamesFromDB.Location = new System.Drawing.Point(48, 62);
            this.lstGamesFromDB.Name = "lstGamesFromDB";
            this.lstGamesFromDB.Size = new System.Drawing.Size(287, 172);
            this.lstGamesFromDB.TabIndex = 2;
            this.lstGamesFromDB.SelectedIndexChanged += new System.EventHandler(this.lstGamesFromDB_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.editGameToolStripMenuItem,
            this.deleteGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.importGameFromFileToolStripMenuItem,
            this.exportGameToFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // editGameToolStripMenuItem
            // 
            this.editGameToolStripMenuItem.Name = "editGameToolStripMenuItem";
            this.editGameToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.editGameToolStripMenuItem.Text = "Edit Game";
            this.editGameToolStripMenuItem.Click += new System.EventHandler(this.editGameToolStripMenuItem_Click);
            // 
            // deleteGameToolStripMenuItem
            // 
            this.deleteGameToolStripMenuItem.Name = "deleteGameToolStripMenuItem";
            this.deleteGameToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.deleteGameToolStripMenuItem.Text = "Delete Game";
            this.deleteGameToolStripMenuItem.Click += new System.EventHandler(this.deleteGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // importGameFromFileToolStripMenuItem
            // 
            this.importGameFromFileToolStripMenuItem.Name = "importGameFromFileToolStripMenuItem";
            this.importGameFromFileToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.importGameFromFileToolStripMenuItem.Text = "Import Game From File";
            this.importGameFromFileToolStripMenuItem.Click += new System.EventHandler(this.importGameFromFileToolStripMenuItem_Click);
            // 
            // exportGameToFileToolStripMenuItem
            // 
            this.exportGameToFileToolStripMenuItem.Name = "exportGameToFileToolStripMenuItem";
            this.exportGameToFileToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.exportGameToFileToolStripMenuItem.Text = "Export Game To File";
            this.exportGameToFileToolStripMenuItem.Click += new System.EventHandler(this.exportGameToFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.helpToolStripMenuItem2});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.helpToolStripMenuItem1.Text = "About";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(116, 24);
            this.helpToolStripMenuItem2.Text = "Help";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.helpToolStripMenuItem2_Click);
            // 
            // btnEditGame
            // 
            this.btnEditGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGame.Location = new System.Drawing.Point(359, 140);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(287, 56);
            this.btnEditGame.TabIndex = 5;
            this.btnEditGame.Text = "Edit Game";
            this.btnEditGame.UseVisualStyleBackColor = true;
            this.btnEditGame.Click += new System.EventHandler(this.btnEditGame_Click);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGame.Location = new System.Drawing.Point(359, 218);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(287, 56);
            this.btnDeleteGame.TabIndex = 6;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // bwLoadGames
            // 
            this.bwLoadGames.WorkerSupportsCancellation = true;
            this.bwLoadGames.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadGames_DoWork);
            this.bwLoadGames.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadGames_RunWorkerCompleted);
            // 
            // btnExportGame
            // 
            this.btnExportGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportGame.Location = new System.Drawing.Point(359, 374);
            this.btnExportGame.Name = "btnExportGame";
            this.btnExportGame.Size = new System.Drawing.Size(287, 56);
            this.btnExportGame.TabIndex = 7;
            this.btnExportGame.Text = "Export to File";
            this.btnExportGame.UseVisualStyleBackColor = true;
            this.btnExportGame.Click += new System.EventHandler(this.btnExportGame_Click);
            // 
            // btnImportGame
            // 
            this.btnImportGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportGame.Location = new System.Drawing.Point(359, 296);
            this.btnImportGame.Name = "btnImportGame";
            this.btnImportGame.Size = new System.Drawing.Size(287, 56);
            this.btnImportGame.TabIndex = 8;
            this.btnImportGame.Text = "Import From File";
            this.btnImportGame.UseVisualStyleBackColor = true;
            this.btnImportGame.Click += new System.EventHandler(this.btnImportGame_Click);
            // 
            // bwLoadGameToPlay
            // 
            this.bwLoadGameToPlay.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadGameToPlay_DoWork);
            this.bwLoadGameToPlay.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadGameToPlay_RunWorkerCompleted);
            // 
            // bwLoadGameToEdit
            // 
            this.bwLoadGameToEdit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadGameToEdit_DoWork);
            this.bwLoadGameToEdit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadGameToEdit_RunWorkerCompleted);
            // 
            // bwLoadGameToExport
            // 
            this.bwLoadGameToExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadGameToExport_DoWork);
            this.bwLoadGameToExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadGameToExport_RunWorkerCompleted);
            // 
            // bwDeleteGame
            // 
            this.bwDeleteGame.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDeleteGame_DoWork);
            this.bwDeleteGame.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDeleteGame_RunWorkerCompleted);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(48, 237);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(287, 56);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Select a Game";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 467);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnImportGame);
            this.Controls.Add(this.btnExportGame);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.lstGamesFromDB);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Jeopardy!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.ListBox lstGamesFromDB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importGameFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.Button btnEditGame;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.ComponentModel.BackgroundWorker bwLoadGames;
        private System.Windows.Forms.Button btnExportGame;
        private System.Windows.Forms.Button btnImportGame;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportGameToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.ComponentModel.BackgroundWorker bwLoadGameToPlay;
        private System.ComponentModel.BackgroundWorker bwLoadGameToEdit;
        private System.ComponentModel.BackgroundWorker bwLoadGameToExport;
        private System.ComponentModel.BackgroundWorker bwDeleteGame;
        private System.Windows.Forms.Label lblStatus;
    }
}


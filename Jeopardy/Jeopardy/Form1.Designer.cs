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
            this.lstGamesFromDB = new System.Windows.Forms.ListBox();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGamesFromDB
            // 
            this.lstGamesFromDB.FormattingEnabled = true;
            this.lstGamesFromDB.ItemHeight = 16;
            this.lstGamesFromDB.Location = new System.Drawing.Point(90, 51);
            this.lstGamesFromDB.Name = "lstGamesFromDB";
            this.lstGamesFromDB.Size = new System.Drawing.Size(111, 148);
            this.lstGamesFromDB.TabIndex = 0;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(90, 223);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(111, 65);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(332, 223);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(111, 65);
            this.btnCreateGame.TabIndex = 2;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.lstGamesFromDB);
            this.Name = "frmMain";
            this.Text = "Jeopardy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGamesFromDB;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnCreateGame;
    }
}


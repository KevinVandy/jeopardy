namespace Jeopardy
{
    partial class Form1
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
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.lstGamesFromDB = new System.Windows.Forms.ListBox();
            this.lblGames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.Location = new System.Drawing.Point(12, 187);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(297, 164);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.Location = new System.Drawing.Point(395, 187);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(297, 164);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "Play\r\nGame";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // lstGamesFromDB
            // 
            this.lstGamesFromDB.FormattingEnabled = true;
            this.lstGamesFromDB.Location = new System.Drawing.Point(395, 48);
            this.lstGamesFromDB.Name = "lstGamesFromDB";
            this.lstGamesFromDB.Size = new System.Drawing.Size(287, 121);
            this.lstGamesFromDB.TabIndex = 2;
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.Location = new System.Drawing.Point(391, 21);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(194, 24);
            this.lblGames.TabIndex = 3;
            this.lblGames.Text = "Select a game to play:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 363);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.lstGamesFromDB);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnCreateGame);
            this.Name = "Form1";
            this.Text = "Welcome to Jeopardy!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.ListBox lstGamesFromDB;
        private System.Windows.Forms.Label lblGames;
    }
}


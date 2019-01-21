namespace Jeopardy
{
    partial class frmHelp
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
            this.okButton = new System.Windows.Forms.Button();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblPlayHelp = new System.Windows.Forms.Label();
            this.lblCreateHelp = new System.Windows.Forms.Label();
            this.lblEditHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(352, 260);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.Location = new System.Drawing.Point(16, 28);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(101, 24);
            this.lblPlay.TabIndex = 1;
            this.lblPlay.Text = "Play Game";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(16, 94);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(121, 24);
            this.lblCreate.TabIndex = 2;
            this.lblCreate.Text = "Create Game";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(16, 165);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(98, 24);
            this.lblEdit.TabIndex = 3;
            this.lblEdit.Text = "Edit Game";
            // 
            // lblPlayHelp
            // 
            this.lblPlayHelp.Location = new System.Drawing.Point(163, 28);
            this.lblPlayHelp.Name = "lblPlayHelp";
            this.lblPlayHelp.Size = new System.Drawing.Size(264, 42);
            this.lblPlayHelp.TabIndex = 4;
            this.lblPlayHelp.Text = "Select game from list, then click this button to start game.";
            // 
            // lblCreateHelp
            // 
            this.lblCreateHelp.Location = new System.Drawing.Point(166, 94);
            this.lblCreateHelp.Name = "lblCreateHelp";
            this.lblCreateHelp.Size = new System.Drawing.Size(261, 40);
            this.lblCreateHelp.TabIndex = 5;
            this.lblCreateHelp.Text = "Click this button to go to the Create Game form and create a new game from scratc" +
    "h.";
            // 
            // lblEditHelp
            // 
            this.lblEditHelp.Location = new System.Drawing.Point(166, 165);
            this.lblEditHelp.Name = "lblEditHelp";
            this.lblEditHelp.Size = new System.Drawing.Size(261, 51);
            this.lblEditHelp.TabIndex = 6;
            this.lblEditHelp.Text = "Select game from list, then click this button to go to the Create form and edit f" +
    "acets of selected game.";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 295);
            this.Controls.Add(this.lblEditHelp);
            this.Controls.Add(this.lblCreateHelp);
            this.Controls.Add(this.lblPlayHelp);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.okButton);
            this.Name = "frmHelp";
            this.Text = "frmHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblPlayHelp;
        private System.Windows.Forms.Label lblCreateHelp;
        private System.Windows.Forms.Label lblEditHelp;
    }
}
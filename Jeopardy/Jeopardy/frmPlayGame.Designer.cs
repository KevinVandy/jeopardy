namespace Jeopardy
{
    partial class frmPlayGame
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
            this.pnlGameboard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGameboard
            // 
            this.pnlGameboard.Location = new System.Drawing.Point(13, 13);
            this.pnlGameboard.Name = "pnlGameboard";
            this.pnlGameboard.Size = new System.Drawing.Size(775, 425);
            this.pnlGameboard.TabIndex = 0;
            // 
            // frmPlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGameboard);
            this.Name = "frmPlayGame";
            this.Text = "Jeopardy!";
            this.Load += new System.EventHandler(this.frmPlayGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameboard;
    }
}
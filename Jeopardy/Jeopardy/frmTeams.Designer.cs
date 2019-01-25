namespace Jeopardy
{
    partial class frmTeams
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumberOfTeams = new System.Windows.Forms.NumericUpDown();
            this.pnlFirstTeam = new System.Windows.Forms.Panel();
            this.txtFirstTeam = new System.Windows.Forms.TextBox();
            this.lblFirstTeam = new System.Windows.Forms.Label();
            this.pnlSecondTeam = new System.Windows.Forms.Panel();
            this.txtSecondTeam = new System.Windows.Forms.TextBox();
            this.lblSecondTeam = new System.Windows.Forms.Label();
            this.pnlThirdTeam = new System.Windows.Forms.Panel();
            this.txtThirdTeam = new System.Windows.Forms.TextBox();
            this.lblThirdTeam = new System.Windows.Forms.Label();
            this.pnlFourthTeam = new System.Windows.Forms.Panel();
            this.txtFourthTeam = new System.Windows.Forms.TextBox();
            this.lblFourthTeam = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTeams)).BeginInit();
            this.pnlFirstTeam.SuspendLayout();
            this.pnlSecondTeam.SuspendLayout();
            this.pnlThirdTeam.SuspendLayout();
            this.pnlFourthTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many teams?:";
            // 
            // nudNumberOfTeams
            // 
            this.nudNumberOfTeams.Location = new System.Drawing.Point(298, 22);
            this.nudNumberOfTeams.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumberOfTeams.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumberOfTeams.Name = "nudNumberOfTeams";
            this.nudNumberOfTeams.ReadOnly = true;
            this.nudNumberOfTeams.Size = new System.Drawing.Size(46, 20);
            this.nudNumberOfTeams.TabIndex = 1;
            this.nudNumberOfTeams.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumberOfTeams.ValueChanged += new System.EventHandler(this.nudNumberOfTeams_ValueChanged);
            // 
            // pnlFirstTeam
            // 
            this.pnlFirstTeam.Controls.Add(this.txtFirstTeam);
            this.pnlFirstTeam.Controls.Add(this.lblFirstTeam);
            this.pnlFirstTeam.Location = new System.Drawing.Point(18, 70);
            this.pnlFirstTeam.Name = "pnlFirstTeam";
            this.pnlFirstTeam.Size = new System.Drawing.Size(382, 81);
            this.pnlFirstTeam.TabIndex = 2;
            // 
            // txtFirstTeam
            // 
            this.txtFirstTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstTeam.Location = new System.Drawing.Point(133, 20);
            this.txtFirstTeam.Multiline = true;
            this.txtFirstTeam.Name = "txtFirstTeam";
            this.txtFirstTeam.Size = new System.Drawing.Size(224, 37);
            this.txtFirstTeam.TabIndex = 1;
            this.txtFirstTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstTeam
            // 
            this.lblFirstTeam.AutoSize = true;
            this.lblFirstTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstTeam.Location = new System.Drawing.Point(13, 20);
            this.lblFirstTeam.Name = "lblFirstTeam";
            this.lblFirstTeam.Size = new System.Drawing.Size(113, 37);
            this.lblFirstTeam.TabIndex = 0;
            this.lblFirstTeam.Text = "Team:";
            // 
            // pnlSecondTeam
            // 
            this.pnlSecondTeam.Controls.Add(this.txtSecondTeam);
            this.pnlSecondTeam.Controls.Add(this.lblSecondTeam);
            this.pnlSecondTeam.Location = new System.Drawing.Point(18, 157);
            this.pnlSecondTeam.Name = "pnlSecondTeam";
            this.pnlSecondTeam.Size = new System.Drawing.Size(382, 81);
            this.pnlSecondTeam.TabIndex = 3;
            // 
            // txtSecondTeam
            // 
            this.txtSecondTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondTeam.Location = new System.Drawing.Point(133, 20);
            this.txtSecondTeam.Multiline = true;
            this.txtSecondTeam.Name = "txtSecondTeam";
            this.txtSecondTeam.Size = new System.Drawing.Size(224, 37);
            this.txtSecondTeam.TabIndex = 1;
            this.txtSecondTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSecondTeam
            // 
            this.lblSecondTeam.AutoSize = true;
            this.lblSecondTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondTeam.Location = new System.Drawing.Point(13, 20);
            this.lblSecondTeam.Name = "lblSecondTeam";
            this.lblSecondTeam.Size = new System.Drawing.Size(113, 37);
            this.lblSecondTeam.TabIndex = 0;
            this.lblSecondTeam.Text = "Team:";
            // 
            // pnlThirdTeam
            // 
            this.pnlThirdTeam.Controls.Add(this.txtThirdTeam);
            this.pnlThirdTeam.Controls.Add(this.lblThirdTeam);
            this.pnlThirdTeam.Location = new System.Drawing.Point(18, 244);
            this.pnlThirdTeam.Name = "pnlThirdTeam";
            this.pnlThirdTeam.Size = new System.Drawing.Size(382, 81);
            this.pnlThirdTeam.TabIndex = 4;
            this.pnlThirdTeam.Visible = false;
            // 
            // txtThirdTeam
            // 
            this.txtThirdTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdTeam.Location = new System.Drawing.Point(133, 20);
            this.txtThirdTeam.Multiline = true;
            this.txtThirdTeam.Name = "txtThirdTeam";
            this.txtThirdTeam.Size = new System.Drawing.Size(224, 37);
            this.txtThirdTeam.TabIndex = 1;
            this.txtThirdTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblThirdTeam
            // 
            this.lblThirdTeam.AutoSize = true;
            this.lblThirdTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdTeam.Location = new System.Drawing.Point(13, 20);
            this.lblThirdTeam.Name = "lblThirdTeam";
            this.lblThirdTeam.Size = new System.Drawing.Size(113, 37);
            this.lblThirdTeam.TabIndex = 0;
            this.lblThirdTeam.Text = "Team:";
            // 
            // pnlFourthTeam
            // 
            this.pnlFourthTeam.Controls.Add(this.txtFourthTeam);
            this.pnlFourthTeam.Controls.Add(this.lblFourthTeam);
            this.pnlFourthTeam.Location = new System.Drawing.Point(18, 331);
            this.pnlFourthTeam.Name = "pnlFourthTeam";
            this.pnlFourthTeam.Size = new System.Drawing.Size(382, 81);
            this.pnlFourthTeam.TabIndex = 5;
            this.pnlFourthTeam.Visible = false;
            // 
            // txtFourthTeam
            // 
            this.txtFourthTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFourthTeam.Location = new System.Drawing.Point(133, 20);
            this.txtFourthTeam.Multiline = true;
            this.txtFourthTeam.Name = "txtFourthTeam";
            this.txtFourthTeam.Size = new System.Drawing.Size(224, 37);
            this.txtFourthTeam.TabIndex = 1;
            this.txtFourthTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFourthTeam
            // 
            this.lblFourthTeam.AutoSize = true;
            this.lblFourthTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourthTeam.Location = new System.Drawing.Point(13, 20);
            this.lblFourthTeam.Name = "lblFourthTeam";
            this.lblFourthTeam.Size = new System.Drawing.Size(113, 37);
            this.lblFourthTeam.TabIndex = 0;
            this.lblFourthTeam.Text = "Team:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(242, 434);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(158, 38);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 484);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlFourthTeam);
            this.Controls.Add(this.pnlThirdTeam);
            this.Controls.Add(this.pnlSecondTeam);
            this.Controls.Add(this.pnlFirstTeam);
            this.Controls.Add(this.nudNumberOfTeams);
            this.Controls.Add(this.label1);
            this.Name = "frmTeams";
            this.Text = "Team Information";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTeams)).EndInit();
            this.pnlFirstTeam.ResumeLayout(false);
            this.pnlFirstTeam.PerformLayout();
            this.pnlSecondTeam.ResumeLayout(false);
            this.pnlSecondTeam.PerformLayout();
            this.pnlThirdTeam.ResumeLayout(false);
            this.pnlThirdTeam.PerformLayout();
            this.pnlFourthTeam.ResumeLayout(false);
            this.pnlFourthTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumberOfTeams;
        private System.Windows.Forms.Panel pnlFirstTeam;
        private System.Windows.Forms.TextBox txtFirstTeam;
        private System.Windows.Forms.Label lblFirstTeam;
        private System.Windows.Forms.Panel pnlSecondTeam;
        private System.Windows.Forms.TextBox txtSecondTeam;
        private System.Windows.Forms.Label lblSecondTeam;
        private System.Windows.Forms.Panel pnlThirdTeam;
        private System.Windows.Forms.TextBox txtThirdTeam;
        private System.Windows.Forms.Label lblThirdTeam;
        private System.Windows.Forms.Panel pnlFourthTeam;
        private System.Windows.Forms.TextBox txtFourthTeam;
        private System.Windows.Forms.Label lblFourthTeam;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
    }
}
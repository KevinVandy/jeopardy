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
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.pnlTeamOne = new System.Windows.Forms.Panel();
            this.nudTeamOne = new System.Windows.Forms.NumericUpDown();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.pnlTeamTwo = new System.Windows.Forms.Panel();
            this.nudTeamTwo = new System.Windows.Forms.NumericUpDown();
            this.lblTeamTwo = new System.Windows.Forms.Label();
            this.pnlTeamThree = new System.Windows.Forms.Panel();
            this.nudTeamThree = new System.Windows.Forms.NumericUpDown();
            this.lblTeamThree = new System.Windows.Forms.Label();
            this.pnlTeamFour = new System.Windows.Forms.Panel();
            this.nudTeamFour = new System.Windows.Forms.NumericUpDown();
            this.lblTeamFour = new System.Windows.Forms.Label();
            this.gbxScoreBoard = new System.Windows.Forms.GroupBox();
            this.cboQuestionTimeLimit = new System.Windows.Forms.ComboBox();
            this.lblQuestionTimeLimit = new System.Windows.Forms.Label();
            this.pnlTeamOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamOne)).BeginInit();
            this.pnlTeamTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamTwo)).BeginInit();
            this.pnlTeamThree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamThree)).BeginInit();
            this.pnlTeamFour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamFour)).BeginInit();
            this.gbxScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameboard
            // 
            this.pnlGameboard.Location = new System.Drawing.Point(28, 260);
            this.pnlGameboard.Name = "pnlGameboard";
            this.pnlGameboard.Size = new System.Drawing.Size(1182, 425);
            this.pnlGameboard.TabIndex = 0;
            // 
            // pnlCategories
            // 
            this.pnlCategories.Location = new System.Drawing.Point(28, 155);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(1182, 100);
            this.pnlCategories.TabIndex = 1;
            // 
            // pnlTeamOne
            // 
            this.pnlTeamOne.Controls.Add(this.nudTeamOne);
            this.pnlTeamOne.Controls.Add(this.lblTeamOne);
            this.pnlTeamOne.Location = new System.Drawing.Point(192, 7);
            this.pnlTeamOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTeamOne.Name = "pnlTeamOne";
            this.pnlTeamOne.Size = new System.Drawing.Size(246, 113);
            this.pnlTeamOne.TabIndex = 2;
            this.pnlTeamOne.Visible = false;
            // 
            // nudTeamOne
            // 
            this.nudTeamOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamOne.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTeamOne.Location = new System.Drawing.Point(156, 79);
            this.nudTeamOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudTeamOne.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTeamOne.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudTeamOne.Name = "nudTeamOne";
            this.nudTeamOne.ReadOnly = true;
            this.nudTeamOne.Size = new System.Drawing.Size(90, 32);
            this.nudTeamOne.TabIndex = 1;
            this.nudTeamOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTeamOne.ThousandsSeparator = true;
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOne.Location = new System.Drawing.Point(2, 7);
            this.lblTeamOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(91, 26);
            this.lblTeamOne.TabIndex = 0;
            this.lblTeamOne.Text = "Team 1";
            // 
            // pnlTeamTwo
            // 
            this.pnlTeamTwo.Controls.Add(this.nudTeamTwo);
            this.pnlTeamTwo.Controls.Add(this.lblTeamTwo);
            this.pnlTeamTwo.Location = new System.Drawing.Point(440, 7);
            this.pnlTeamTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTeamTwo.Name = "pnlTeamTwo";
            this.pnlTeamTwo.Size = new System.Drawing.Size(246, 113);
            this.pnlTeamTwo.TabIndex = 3;
            this.pnlTeamTwo.Visible = false;
            // 
            // nudTeamTwo
            // 
            this.nudTeamTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamTwo.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTeamTwo.Location = new System.Drawing.Point(156, 79);
            this.nudTeamTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudTeamTwo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTeamTwo.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudTeamTwo.Name = "nudTeamTwo";
            this.nudTeamTwo.ReadOnly = true;
            this.nudTeamTwo.Size = new System.Drawing.Size(90, 32);
            this.nudTeamTwo.TabIndex = 1;
            this.nudTeamTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTeamTwo.ThousandsSeparator = true;
            // 
            // lblTeamTwo
            // 
            this.lblTeamTwo.AutoSize = true;
            this.lblTeamTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwo.Location = new System.Drawing.Point(2, 7);
            this.lblTeamTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamTwo.Name = "lblTeamTwo";
            this.lblTeamTwo.Size = new System.Drawing.Size(91, 26);
            this.lblTeamTwo.TabIndex = 0;
            this.lblTeamTwo.Text = "Team 2";
            // 
            // pnlTeamThree
            // 
            this.pnlTeamThree.Controls.Add(this.nudTeamThree);
            this.pnlTeamThree.Controls.Add(this.lblTeamThree);
            this.pnlTeamThree.Location = new System.Drawing.Point(688, 7);
            this.pnlTeamThree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTeamThree.Name = "pnlTeamThree";
            this.pnlTeamThree.Size = new System.Drawing.Size(246, 113);
            this.pnlTeamThree.TabIndex = 4;
            this.pnlTeamThree.Visible = false;
            // 
            // nudTeamThree
            // 
            this.nudTeamThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamThree.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTeamThree.Location = new System.Drawing.Point(154, 79);
            this.nudTeamThree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudTeamThree.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTeamThree.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudTeamThree.Name = "nudTeamThree";
            this.nudTeamThree.ReadOnly = true;
            this.nudTeamThree.Size = new System.Drawing.Size(90, 32);
            this.nudTeamThree.TabIndex = 1;
            this.nudTeamThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTeamThree.ThousandsSeparator = true;
            // 
            // lblTeamThree
            // 
            this.lblTeamThree.AutoSize = true;
            this.lblTeamThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamThree.Location = new System.Drawing.Point(2, 7);
            this.lblTeamThree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamThree.Name = "lblTeamThree";
            this.lblTeamThree.Size = new System.Drawing.Size(91, 26);
            this.lblTeamThree.TabIndex = 0;
            this.lblTeamThree.Text = "Team 3";
            // 
            // pnlTeamFour
            // 
            this.pnlTeamFour.Controls.Add(this.nudTeamFour);
            this.pnlTeamFour.Controls.Add(this.lblTeamFour);
            this.pnlTeamFour.Location = new System.Drawing.Point(936, 7);
            this.pnlTeamFour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTeamFour.Name = "pnlTeamFour";
            this.pnlTeamFour.Size = new System.Drawing.Size(246, 113);
            this.pnlTeamFour.TabIndex = 5;
            this.pnlTeamFour.Visible = false;
            // 
            // nudTeamFour
            // 
            this.nudTeamFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTeamFour.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTeamFour.Location = new System.Drawing.Point(154, 79);
            this.nudTeamFour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudTeamFour.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudTeamFour.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudTeamFour.Name = "nudTeamFour";
            this.nudTeamFour.ReadOnly = true;
            this.nudTeamFour.Size = new System.Drawing.Size(90, 32);
            this.nudTeamFour.TabIndex = 1;
            this.nudTeamFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTeamFour.ThousandsSeparator = true;
            // 
            // lblTeamFour
            // 
            this.lblTeamFour.AutoSize = true;
            this.lblTeamFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamFour.Location = new System.Drawing.Point(2, 7);
            this.lblTeamFour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamFour.Name = "lblTeamFour";
            this.lblTeamFour.Size = new System.Drawing.Size(91, 26);
            this.lblTeamFour.TabIndex = 0;
            this.lblTeamFour.Text = "Team 4";
            // 
            // gbxScoreBoard
            // 
            this.gbxScoreBoard.Controls.Add(this.cboQuestionTimeLimit);
            this.gbxScoreBoard.Controls.Add(this.lblQuestionTimeLimit);
            this.gbxScoreBoard.Controls.Add(this.pnlTeamOne);
            this.gbxScoreBoard.Controls.Add(this.pnlTeamFour);
            this.gbxScoreBoard.Controls.Add(this.pnlTeamTwo);
            this.gbxScoreBoard.Controls.Add(this.pnlTeamThree);
            this.gbxScoreBoard.Location = new System.Drawing.Point(28, 30);
            this.gbxScoreBoard.Name = "gbxScoreBoard";
            this.gbxScoreBoard.Size = new System.Drawing.Size(1182, 120);
            this.gbxScoreBoard.TabIndex = 2;
            this.gbxScoreBoard.TabStop = false;
            this.gbxScoreBoard.Text = "Score Board";
            // 
            // cboQuestionTimeLimit
            // 
            this.cboQuestionTimeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuestionTimeLimit.FormattingEnabled = true;
            this.cboQuestionTimeLimit.Items.AddRange(new object[] {
            "30 seconds",
            "1 minute",
            "90 seconds",
            "2 minutes",
            "3 minutes"});
            this.cboQuestionTimeLimit.Location = new System.Drawing.Point(19, 51);
            this.cboQuestionTimeLimit.Name = "cboQuestionTimeLimit";
            this.cboQuestionTimeLimit.Size = new System.Drawing.Size(148, 28);
            this.cboQuestionTimeLimit.TabIndex = 37;
            // 
            // lblQuestionTimeLimit
            // 
            this.lblQuestionTimeLimit.AutoSize = true;
            this.lblQuestionTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTimeLimit.Location = new System.Drawing.Point(15, 27);
            this.lblQuestionTimeLimit.Name = "lblQuestionTimeLimit";
            this.lblQuestionTimeLimit.Size = new System.Drawing.Size(152, 20);
            this.lblQuestionTimeLimit.TabIndex = 36;
            this.lblQuestionTimeLimit.Text = "Question Time Limit:";
            // 
            // frmPlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1222, 766);
            this.Controls.Add(this.gbxScoreBoard);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.pnlGameboard);
            this.Name = "frmPlayGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jeopardy!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPlayGame_Load);
            this.ResizeEnd += new System.EventHandler(this.frmPlayGame_ResizeEnd);
            this.pnlTeamOne.ResumeLayout(false);
            this.pnlTeamOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamOne)).EndInit();
            this.pnlTeamTwo.ResumeLayout(false);
            this.pnlTeamTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamTwo)).EndInit();
            this.pnlTeamThree.ResumeLayout(false);
            this.pnlTeamThree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamThree)).EndInit();
            this.pnlTeamFour.ResumeLayout(false);
            this.pnlTeamFour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamFour)).EndInit();
            this.gbxScoreBoard.ResumeLayout(false);
            this.gbxScoreBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameboard;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Panel pnlTeamOne;
        private System.Windows.Forms.NumericUpDown nudTeamOne;
        private System.Windows.Forms.Label lblTeamOne;
        private System.Windows.Forms.Panel pnlTeamTwo;
        private System.Windows.Forms.NumericUpDown nudTeamTwo;
        private System.Windows.Forms.Label lblTeamTwo;
        private System.Windows.Forms.Panel pnlTeamThree;
        private System.Windows.Forms.NumericUpDown nudTeamThree;
        private System.Windows.Forms.Label lblTeamThree;
        private System.Windows.Forms.Panel pnlTeamFour;
        private System.Windows.Forms.NumericUpDown nudTeamFour;
        private System.Windows.Forms.Label lblTeamFour;
        private System.Windows.Forms.GroupBox gbxScoreBoard;
        private System.Windows.Forms.ComboBox cboQuestionTimeLimit;
        private System.Windows.Forms.Label lblQuestionTimeLimit;
    }
}
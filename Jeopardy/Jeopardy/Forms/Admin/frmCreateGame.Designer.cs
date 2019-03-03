namespace Jeopardy
{
    partial class frmCreateGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateGame));
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberCategories = new System.Windows.Forms.Label();
            this.nudNumQuestionCategory = new System.Windows.Forms.NumericUpDown();
            this.nudNumCategories = new System.Windows.Forms.NumericUpDown();
            this.cboQuestionTimeLimit = new System.Windows.Forms.ComboBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblQuestionTimeLimit = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblDefault1 = new System.Windows.Forms.Label();
            this.lblDefault2 = new System.Windows.Forms.Label();
            this.bwInsertGame = new System.ComponentModel.BackgroundWorker();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumQuestions = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumQuestionCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCategories)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Questions Per Category:";
            // 
            // lblNumberCategories
            // 
            this.lblNumberCategories.AutoSize = true;
            this.lblNumberCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberCategories.Location = new System.Drawing.Point(79, 197);
            this.lblNumberCategories.Name = "lblNumberCategories";
            this.lblNumberCategories.Size = new System.Drawing.Size(256, 29);
            this.lblNumberCategories.TabIndex = 46;
            this.lblNumberCategories.Text = "Number of Categories:";
            // 
            // nudNumQuestionCategory
            // 
            this.nudNumQuestionCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudNumQuestionCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumQuestionCategory.Location = new System.Drawing.Point(341, 264);
            this.nudNumQuestionCategory.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNumQuestionCategory.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNumQuestionCategory.Name = "nudNumQuestionCategory";
            this.nudNumQuestionCategory.ReadOnly = true;
            this.nudNumQuestionCategory.Size = new System.Drawing.Size(66, 35);
            this.nudNumQuestionCategory.TabIndex = 3;
            this.nudNumQuestionCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumQuestionCategory.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumQuestionCategory.ValueChanged += new System.EventHandler(this.nudNumQuestionCategory_ValueChanged);
            // 
            // nudNumCategories
            // 
            this.nudNumCategories.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudNumCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumCategories.Location = new System.Drawing.Point(341, 195);
            this.nudNumCategories.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNumCategories.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNumCategories.Name = "nudNumCategories";
            this.nudNumCategories.ReadOnly = true;
            this.nudNumCategories.Size = new System.Drawing.Size(66, 35);
            this.nudNumCategories.TabIndex = 2;
            this.nudNumCategories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumCategories.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudNumCategories.ValueChanged += new System.EventHandler(this.nudNumCategories_ValueChanged);
            // 
            // cboQuestionTimeLimit
            // 
            this.cboQuestionTimeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuestionTimeLimit.FormattingEnabled = true;
            this.cboQuestionTimeLimit.Items.AddRange(new object[] {
            "30 seconds",
            "1 minute",
            "90 seconds",
            "2 minutes",
            "3 minutes"});
            this.cboQuestionTimeLimit.Location = new System.Drawing.Point(341, 125);
            this.cboQuestionTimeLimit.Name = "cboQuestionTimeLimit";
            this.cboQuestionTimeLimit.Size = new System.Drawing.Size(269, 37);
            this.cboQuestionTimeLimit.TabIndex = 1;
            this.cboQuestionTimeLimit.SelectedIndexChanged += new System.EventHandler(this.cboQuestionTimeLimit_SelectedIndexChanged);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.Location = new System.Drawing.Point(180, 59);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(155, 29);
            this.lblGameName.TabIndex = 40;
            this.lblGameName.Text = "Game Name:";
            // 
            // lblQuestionTimeLimit
            // 
            this.lblQuestionTimeLimit.AutoSize = true;
            this.lblQuestionTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTimeLimit.Location = new System.Drawing.Point(100, 128);
            this.lblQuestionTimeLimit.Name = "lblQuestionTimeLimit";
            this.lblQuestionTimeLimit.Size = new System.Drawing.Size(235, 29);
            this.lblQuestionTimeLimit.TabIndex = 42;
            this.lblQuestionTimeLimit.Text = "Question Time Limit:";
            // 
            // txtGameName
            // 
            this.txtGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameName.Location = new System.Drawing.Point(341, 56);
            this.txtGameName.MaxLength = 50;
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(269, 35);
            this.txtGameName.TabIndex = 0;
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.Location = new System.Drawing.Point(341, 547);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(269, 54);
            this.btnCreateGame.TabIndex = 4;
            this.btnCreateGame.Text = "Create New Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(25, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(269, 54);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHint.Location = new System.Drawing.Point(155, 504);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(347, 24);
            this.lblHint.TabIndex = 50;
            this.lblHint.Text = "You can also change these settings later";
            // 
            // lblDefault1
            // 
            this.lblDefault1.AutoSize = true;
            this.lblDefault1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefault1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDefault1.Location = new System.Drawing.Point(531, 201);
            this.lblDefault1.Name = "lblDefault1";
            this.lblDefault1.Size = new System.Drawing.Size(79, 24);
            this.lblDefault1.TabIndex = 51;
            this.lblDefault1.Text = "(Default)";
            // 
            // lblDefault2
            // 
            this.lblDefault2.AutoSize = true;
            this.lblDefault2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefault2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDefault2.Location = new System.Drawing.Point(531, 270);
            this.lblDefault2.Name = "lblDefault2";
            this.lblDefault2.Size = new System.Drawing.Size(79, 24);
            this.lblDefault2.TabIndex = 6;
            this.lblDefault2.Text = "(Default)";
            // 
            // bwInsertGame
            // 
            this.bwInsertGame.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwInsertGame_DoWork);
            this.bwInsertGame.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwInsertGame_RunWorkerCompleted);
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlPreview.Location = new System.Drawing.Point(341, 320);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(269, 152);
            this.pnlPreview.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(417, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Columns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(417, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "Rows";
            // 
            // lblNumQuestions
            // 
            this.lblNumQuestions.AutoSize = true;
            this.lblNumQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQuestions.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumQuestions.Location = new System.Drawing.Point(57, 378);
            this.lblNumQuestions.Name = "lblNumQuestions";
            this.lblNumQuestions.Size = new System.Drawing.Size(255, 46);
            this.lblNumQuestions.TabIndex = 56;
            this.lblNumQuestions.Text = "30 Questions";
            this.lblNumQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 29);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.tutorialToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // frmCreateGame
            // 
            this.AcceptButton = this.btnCreateGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 643);
            this.Controls.Add(this.lblNumQuestions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.lblDefault2);
            this.Controls.Add(this.lblDefault1);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberCategories);
            this.Controls.Add(this.nudNumQuestionCategory);
            this.Controls.Add(this.nudNumCategories);
            this.Controls.Add(this.cboQuestionTimeLimit);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.lblQuestionTimeLimit);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCreateGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create a Game!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateGame_FormClosing);
            this.Load += new System.EventHandler(this.frmCreateGameStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumQuestionCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCategories)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberCategories;
        private System.Windows.Forms.NumericUpDown nudNumQuestionCategory;
        private System.Windows.Forms.NumericUpDown nudNumCategories;
        private System.Windows.Forms.ComboBox cboQuestionTimeLimit;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblQuestionTimeLimit;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblDefault1;
        private System.Windows.Forms.Label lblDefault2;
        private System.ComponentModel.BackgroundWorker bwInsertGame;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumQuestions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
    }
}
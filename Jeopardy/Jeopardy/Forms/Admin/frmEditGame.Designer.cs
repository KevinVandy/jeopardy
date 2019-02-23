namespace Jeopardy
{
    partial class frmEditGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditGame));
            this.gbxQuestions = new System.Windows.Forms.GroupBox();
            this.gbxCategories = new System.Windows.Forms.GroupBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuestionTimeLimit = new System.Windows.Forms.Label();
            this.cboQuestionTimeLimit = new System.Windows.Forms.ComboBox();
            this.gbxGameInfo = new System.Windows.Forms.GroupBox();
            this.lblNumberEmptyQuestions = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumberFinishedQuestions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberQuestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberCategories = new System.Windows.Forms.Label();
            this.nudNumQuestionCategory = new System.Windows.Forms.NumericUpDown();
            this.nudNumCategories = new System.Windows.Forms.NumericUpDown();
            this.bwLoadGame = new System.ComponentModel.BackgroundWorker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslblSaveState = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsQuestions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.bwAddCategory = new System.ComponentModel.BackgroundWorker();
            this.bwRemoveCategory = new System.ComponentModel.BackgroundWorker();
            this.bwAddQuestions = new System.ComponentModel.BackgroundWorker();
            this.bwRemoveQuestions = new System.ComponentModel.BackgroundWorker();
            this.bwUpdateNumCategories = new System.ComponentModel.BackgroundWorker();
            this.bwUpdateNumQuestionsPerCategory = new System.ComponentModel.BackgroundWorker();
            this.bwUpdateGameName = new System.ComponentModel.BackgroundWorker();
            this.bwUpdateTimeLimit = new System.ComponentModel.BackgroundWorker();
            this.bwUpdateCategory = new System.ComponentModel.BackgroundWorker();
            this.bwUpdateQuestion = new System.ComponentModel.BackgroundWorker();
            this.bwDeleteChoices = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.gbxGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumQuestionCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCategories)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.cmsQuestions.SuspendLayout();
            this.cmsCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxQuestions
            // 
            this.gbxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxQuestions.Location = new System.Drawing.Point(23, 341);
            this.gbxQuestions.Name = "gbxQuestions";
            this.gbxQuestions.Size = new System.Drawing.Size(1005, 516);
            this.gbxQuestions.TabIndex = 30;
            this.gbxQuestions.TabStop = false;
            this.gbxQuestions.Text = "Questions";
            // 
            // gbxCategories
            // 
            this.gbxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategories.Location = new System.Drawing.Point(23, 198);
            this.gbxCategories.Name = "gbxCategories";
            this.gbxCategories.Size = new System.Drawing.Size(1005, 128);
            this.gbxCategories.TabIndex = 30;
            this.gbxCategories.TabStop = false;
            this.gbxCategories.Text = "Categories";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.Location = new System.Drawing.Point(15, 34);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(103, 20);
            this.lblGameName.TabIndex = 31;
            this.lblGameName.Text = "Game Name:";
            // 
            // txtGameName
            // 
            this.txtGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameName.Location = new System.Drawing.Point(124, 31);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(188, 26);
            this.txtGameName.TabIndex = 32;
            this.txtGameName.DoubleClick += new System.EventHandler(this.txtGameName_DoubleClick);
            this.txtGameName.Leave += new System.EventHandler(this.txtGameName_Leave);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1079, 27);
            this.menuStrip.TabIndex = 33;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportGameToolStripMenuItem,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // exportGameToolStripMenuItem
            // 
            this.exportGameToolStripMenuItem.Name = "exportGameToolStripMenuItem";
            this.exportGameToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.exportGameToolStripMenuItem.Text = "Export To File";
            this.exportGameToolStripMenuItem.Click += new System.EventHandler(this.exportGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(156, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.exitToolStripMenuItem.Text = "Save and Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.tutorialToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.tutorialToolStripMenuItem.Text = "Help";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lblQuestionTimeLimit
            // 
            this.lblQuestionTimeLimit.AutoSize = true;
            this.lblQuestionTimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTimeLimit.Location = new System.Drawing.Point(15, 86);
            this.lblQuestionTimeLimit.Name = "lblQuestionTimeLimit";
            this.lblQuestionTimeLimit.Size = new System.Drawing.Size(152, 20);
            this.lblQuestionTimeLimit.TabIndex = 34;
            this.lblQuestionTimeLimit.Text = "Question Time Limit:";
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
            this.cboQuestionTimeLimit.Location = new System.Drawing.Point(173, 83);
            this.cboQuestionTimeLimit.Name = "cboQuestionTimeLimit";
            this.cboQuestionTimeLimit.Size = new System.Drawing.Size(139, 28);
            this.cboQuestionTimeLimit.TabIndex = 35;
            this.cboQuestionTimeLimit.SelectedIndexChanged += new System.EventHandler(this.cboQuestionTimeLimit_SelectedIndexChanged);
            // 
            // gbxGameInfo
            // 
            this.gbxGameInfo.Controls.Add(this.lblNumberEmptyQuestions);
            this.gbxGameInfo.Controls.Add(this.label6);
            this.gbxGameInfo.Controls.Add(this.lblNumberFinishedQuestions);
            this.gbxGameInfo.Controls.Add(this.label4);
            this.gbxGameInfo.Controls.Add(this.lblNumberQuestions);
            this.gbxGameInfo.Controls.Add(this.label1);
            this.gbxGameInfo.Controls.Add(this.label2);
            this.gbxGameInfo.Controls.Add(this.lblNumberCategories);
            this.gbxGameInfo.Controls.Add(this.nudNumQuestionCategory);
            this.gbxGameInfo.Controls.Add(this.nudNumCategories);
            this.gbxGameInfo.Controls.Add(this.cboQuestionTimeLimit);
            this.gbxGameInfo.Controls.Add(this.lblGameName);
            this.gbxGameInfo.Controls.Add(this.lblQuestionTimeLimit);
            this.gbxGameInfo.Controls.Add(this.txtGameName);
            this.gbxGameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGameInfo.Location = new System.Drawing.Point(23, 55);
            this.gbxGameInfo.MinimumSize = new System.Drawing.Size(1000, 0);
            this.gbxGameInfo.Name = "gbxGameInfo";
            this.gbxGameInfo.Size = new System.Drawing.Size(1005, 128);
            this.gbxGameInfo.TabIndex = 36;
            this.gbxGameInfo.TabStop = false;
            this.gbxGameInfo.Text = "Game Information";
            // 
            // lblNumberEmptyQuestions
            // 
            this.lblNumberEmptyQuestions.AutoSize = true;
            this.lblNumberEmptyQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberEmptyQuestions.Location = new System.Drawing.Point(954, 86);
            this.lblNumberEmptyQuestions.Name = "lblNumberEmptyQuestions";
            this.lblNumberEmptyQuestions.Size = new System.Drawing.Size(18, 20);
            this.lblNumberEmptyQuestions.TabIndex = 45;
            this.lblNumberEmptyQuestions.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Unfinished Questions:";
            // 
            // lblNumberFinishedQuestions
            // 
            this.lblNumberFinishedQuestions.AutoSize = true;
            this.lblNumberFinishedQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberFinishedQuestions.Location = new System.Drawing.Point(738, 86);
            this.lblNumberFinishedQuestions.Name = "lblNumberFinishedQuestions";
            this.lblNumberFinishedQuestions.Size = new System.Drawing.Size(18, 20);
            this.lblNumberFinishedQuestions.TabIndex = 43;
            this.lblNumberFinishedQuestions.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Finished Questions:";
            // 
            // lblNumberQuestions
            // 
            this.lblNumberQuestions.AutoSize = true;
            this.lblNumberQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberQuestions.Location = new System.Drawing.Point(517, 86);
            this.lblNumberQuestions.Name = "lblNumberQuestions";
            this.lblNumberQuestions.Size = new System.Drawing.Size(27, 20);
            this.lblNumberQuestions.TabIndex = 41;
            this.lblNumberQuestions.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Number of Questions: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Number of Questions Per Category:";
            // 
            // lblNumberCategories
            // 
            this.lblNumberCategories.AutoSize = true;
            this.lblNumberCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberCategories.Location = new System.Drawing.Point(347, 34);
            this.lblNumberCategories.Name = "lblNumberCategories";
            this.lblNumberCategories.Size = new System.Drawing.Size(168, 20);
            this.lblNumberCategories.TabIndex = 38;
            this.lblNumberCategories.Text = "Number of Categories:";
            // 
            // nudNumQuestionCategory
            // 
            this.nudNumQuestionCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudNumQuestionCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumQuestionCategory.Location = new System.Drawing.Point(848, 29);
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
            this.nudNumQuestionCategory.Size = new System.Drawing.Size(46, 29);
            this.nudNumQuestionCategory.TabIndex = 37;
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
            this.nudNumCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumCategories.Location = new System.Drawing.Point(521, 29);
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
            this.nudNumCategories.Size = new System.Drawing.Size(46, 29);
            this.nudNumCategories.TabIndex = 36;
            this.nudNumCategories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumCategories.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudNumCategories.ValueChanged += new System.EventHandler(this.nudNumCategories_ValueChanged);
            // 
            // bwLoadGame
            // 
            this.bwLoadGame.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadGame_DoWork);
            this.bwLoadGame.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadGame_RunWorkerCompleted);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblSaveState});
            this.statusStrip.Location = new System.Drawing.Point(0, 827);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(1079, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 38;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tslblSaveState
            // 
            this.tslblSaveState.Name = "tslblSaveState";
            this.tslblSaveState.Size = new System.Drawing.Size(104, 17);
            this.tslblSaveState.Text = "All Changes Saved";
            // 
            // cmsQuestions
            // 
            this.cmsQuestions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsQuestions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsQuestions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditQuestion,
            this.tsmiDeleteQuestion});
            this.cmsQuestions.Name = "cmsQuestions";
            this.cmsQuestions.Size = new System.Drawing.Size(125, 56);
            // 
            // tsmiEditQuestion
            // 
            this.tsmiEditQuestion.Name = "tsmiEditQuestion";
            this.tsmiEditQuestion.Size = new System.Drawing.Size(124, 26);
            this.tsmiEditQuestion.Text = "Edit";
            this.tsmiEditQuestion.Click += new System.EventHandler(this.tsmiEditQuestion_Click);
            // 
            // tsmiDeleteQuestion
            // 
            this.tsmiDeleteQuestion.Name = "tsmiDeleteQuestion";
            this.tsmiDeleteQuestion.Size = new System.Drawing.Size(124, 26);
            this.tsmiDeleteQuestion.Text = "Delete";
            this.tsmiDeleteQuestion.Click += new System.EventHandler(this.tsmiDeleteQuestion_Click);
            // 
            // cmsCategories
            // 
            this.cmsCategories.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsCategories.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditCategory,
            this.tsmiDeleteCategory});
            this.cmsCategories.Name = "cmsCategories";
            this.cmsCategories.Size = new System.Drawing.Size(125, 56);
            // 
            // tsmiEditCategory
            // 
            this.tsmiEditCategory.Name = "tsmiEditCategory";
            this.tsmiEditCategory.Size = new System.Drawing.Size(124, 26);
            this.tsmiEditCategory.Text = "Edit";
            this.tsmiEditCategory.Click += new System.EventHandler(this.tsmiEditCategory_Click);
            // 
            // tsmiDeleteCategory
            // 
            this.tsmiDeleteCategory.Name = "tsmiDeleteCategory";
            this.tsmiDeleteCategory.Size = new System.Drawing.Size(124, 26);
            this.tsmiDeleteCategory.Text = "Delete";
            this.tsmiDeleteCategory.Click += new System.EventHandler(this.tsmiDeleteCategory_Click);
            // 
            // bwAddCategory
            // 
            this.bwAddCategory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAddCategory_DoWork);
            this.bwAddCategory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAddCategory_RunWorkerCompleted);
            // 
            // bwRemoveCategory
            // 
            this.bwRemoveCategory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRemoveCategory_DoWork);
            this.bwRemoveCategory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRemoveCategory_RunWorkerCompleted);
            // 
            // bwAddQuestions
            // 
            this.bwAddQuestions.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAddQuestions_DoWork);
            this.bwAddQuestions.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAddQuestions_RunWorkerCompleted);
            // 
            // bwRemoveQuestions
            // 
            this.bwRemoveQuestions.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRemoveQuestions_DoWork);
            this.bwRemoveQuestions.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRemoveQuestions_RunWorkerCompleted);
            // 
            // bwUpdateNumCategories
            // 
            this.bwUpdateNumCategories.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdateNumCategories_DoWork);
            this.bwUpdateNumCategories.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdateNumCategories_RunWorkerCompleted);
            // 
            // bwUpdateNumQuestionsPerCategory
            // 
            this.bwUpdateNumQuestionsPerCategory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdateNumQuestionsPerCategory_DoWork);
            this.bwUpdateNumQuestionsPerCategory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdateNumQuestionsPerCategory_RunWorkerCompleted);
            // 
            // bwUpdateGameName
            // 
            this.bwUpdateGameName.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdateGameName_DoWork);
            // 
            // bwUpdateTimeLimit
            // 
            this.bwUpdateTimeLimit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdateTimeLimit_DoWork);
            this.bwUpdateTimeLimit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdateTimeLimit_RunWorkerCompleted);
            // 
            // bwUpdateCategory
            // 
            this.bwUpdateCategory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdateCategory_DoWork);
            this.bwUpdateCategory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdateCategory_RunWorkerCompleted);
            // 
            // bwUpdateQuestion
            // 
            this.bwUpdateQuestion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdateQuestion_DoWork);
            this.bwUpdateQuestion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdateQuestion_RunWorkerCompleted);
            // 
            // bwDeleteChoices
            // 
            this.bwDeleteChoices.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDeleteChoices_DoWork);
            this.bwDeleteChoices.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDeleteChoices_RunWorkerCompleted);
            // 
            // frmEditGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 849);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbxGameInfo);
            this.Controls.Add(this.gbxCategories);
            this.Controls.Add(this.gbxQuestions);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(360, 239);
            this.Name = "frmEditGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditGame_FormClosing);
            this.Load += new System.EventHandler(this.frmCreateGame_Load);
            this.ResizeEnd += new System.EventHandler(this.frmCreateGame_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmCreateGame_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbxGameInfo.ResumeLayout(false);
            this.gbxGameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumQuestionCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCategories)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.cmsQuestions.ResumeLayout(false);
            this.cmsCategories.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxQuestions;
        private System.Windows.Forms.GroupBox gbxCategories;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.Label lblQuestionTimeLimit;
        private System.Windows.Forms.ComboBox cboQuestionTimeLimit;
        private System.Windows.Forms.GroupBox gbxGameInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberCategories;
        private System.Windows.Forms.NumericUpDown nudNumQuestionCategory;
        private System.Windows.Forms.NumericUpDown nudNumCategories;
        private System.ComponentModel.BackgroundWorker bwLoadGame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label lblNumberEmptyQuestions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumberFinishedQuestions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslblSaveState;
        private System.Windows.Forms.ContextMenuStrip cmsQuestions;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditQuestion;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteQuestion;
        private System.Windows.Forms.ContextMenuStrip cmsCategories;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteCategory;
        private System.ComponentModel.BackgroundWorker bwAddCategory;
        private System.ComponentModel.BackgroundWorker bwRemoveCategory;
        private System.ComponentModel.BackgroundWorker bwAddQuestions;
        private System.ComponentModel.BackgroundWorker bwRemoveQuestions;
        private System.ComponentModel.BackgroundWorker bwUpdateNumCategories;
        private System.ComponentModel.BackgroundWorker bwUpdateNumQuestionsPerCategory;
        private System.ComponentModel.BackgroundWorker bwUpdateGameName;
        private System.ComponentModel.BackgroundWorker bwUpdateTimeLimit;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.ComponentModel.BackgroundWorker bwUpdateCategory;
        private System.ComponentModel.BackgroundWorker bwUpdateQuestion;
        private System.ComponentModel.BackgroundWorker bwDeleteChoices;
    }
}
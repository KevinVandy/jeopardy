namespace Jeopardy
{
    partial class frmEditQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditQuestion));
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.rdoFillInTheBlank = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTypes = new System.Windows.Forms.Panel();
            this.rdoTrueFalse = new System.Windows.Forms.RadioButton();
            this.rdoMultipleChoice = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtChoiceA = new System.Windows.Forms.TextBox();
            this.txtChoiceC = new System.Windows.Forms.TextBox();
            this.txtChoiceD = new System.Windows.Forms.TextBox();
            this.txtChoiceB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoChoiceD = new System.Windows.Forms.RadioButton();
            this.rdoChoiceB = new System.Windows.Forms.RadioButton();
            this.rdoChoiceC = new System.Windows.Forms.RadioButton();
            this.rdoChoiceA = new System.Windows.Forms.RadioButton();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importQuestionFromOtherGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bwCreateChoices = new System.ComponentModel.BackgroundWorker();
            this.bwRemoveChoices = new System.ComponentModel.BackgroundWorker();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblLimitWarning = new System.Windows.Forms.Label();
            this.lblCloseWarning = new System.Windows.Forms.Label();
            this.pnlTypes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.AutoSize = true;
            this.lblCategoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryTitle.Location = new System.Drawing.Point(24, 53);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Size = new System.Drawing.Size(215, 37);
            this.lblCategoryTitle.TabIndex = 0;
            this.lblCategoryTitle.Text = "Category Title";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(835, 50);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(69, 37);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question:";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionText.Location = new System.Drawing.Point(147, 183);
            this.txtQuestionText.MaxLength = 300;
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(763, 127);
            this.txtQuestionText.TabIndex = 0;
            this.txtQuestionText.TextChanged += new System.EventHandler(this.txtQuestionText_TextChanged);
            // 
            // rdoFillInTheBlank
            // 
            this.rdoFillInTheBlank.AutoSize = true;
            this.rdoFillInTheBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFillInTheBlank.Location = new System.Drawing.Point(13, 17);
            this.rdoFillInTheBlank.Name = "rdoFillInTheBlank";
            this.rdoFillInTheBlank.Size = new System.Drawing.Size(194, 33);
            this.rdoFillInTheBlank.TabIndex = 0;
            this.rdoFillInTheBlank.TabStop = true;
            this.rdoFillInTheBlank.Text = "Fill In the Blank";
            this.rdoFillInTheBlank.UseVisualStyleBackColor = true;
            this.rdoFillInTheBlank.CheckedChanged += new System.EventHandler(this.rdoType_CheckChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answer:";
            // 
            // pnlTypes
            // 
            this.pnlTypes.Controls.Add(this.rdoTrueFalse);
            this.pnlTypes.Controls.Add(this.rdoMultipleChoice);
            this.pnlTypes.Controls.Add(this.rdoFillInTheBlank);
            this.pnlTypes.Location = new System.Drawing.Point(147, 110);
            this.pnlTypes.Name = "pnlTypes";
            this.pnlTypes.Size = new System.Drawing.Size(764, 67);
            this.pnlTypes.TabIndex = 7;
            // 
            // rdoTrueFalse
            // 
            this.rdoTrueFalse.AutoSize = true;
            this.rdoTrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrueFalse.Location = new System.Drawing.Point(551, 17);
            this.rdoTrueFalse.Name = "rdoTrueFalse";
            this.rdoTrueFalse.Size = new System.Drawing.Size(161, 33);
            this.rdoTrueFalse.TabIndex = 2;
            this.rdoTrueFalse.TabStop = true;
            this.rdoTrueFalse.Text = "True / False";
            this.rdoTrueFalse.UseVisualStyleBackColor = true;
            this.rdoTrueFalse.CheckedChanged += new System.EventHandler(this.rdoType_CheckChanged);
            // 
            // rdoMultipleChoice
            // 
            this.rdoMultipleChoice.AutoSize = true;
            this.rdoMultipleChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMultipleChoice.Location = new System.Drawing.Point(280, 17);
            this.rdoMultipleChoice.Name = "rdoMultipleChoice";
            this.rdoMultipleChoice.Size = new System.Drawing.Size(198, 33);
            this.rdoMultipleChoice.TabIndex = 1;
            this.rdoMultipleChoice.TabStop = true;
            this.rdoMultipleChoice.Text = "Multiple Choice";
            this.rdoMultipleChoice.UseVisualStyleBackColor = true;
            this.rdoMultipleChoice.CheckedChanged += new System.EventHandler(this.rdoType_CheckChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(147, 643);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(212, 51);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(699, 643);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(212, 51);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtChoiceA
            // 
            this.txtChoiceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceA.Location = new System.Drawing.Point(84, 18);
            this.txtChoiceA.Multiline = true;
            this.txtChoiceA.Name = "txtChoiceA";
            this.txtChoiceA.Size = new System.Drawing.Size(296, 101);
            this.txtChoiceA.TabIndex = 0;
            this.txtChoiceA.TextChanged += new System.EventHandler(this.txtChoiceA_TextChanged);
            // 
            // txtChoiceC
            // 
            this.txtChoiceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceC.Location = new System.Drawing.Point(84, 132);
            this.txtChoiceC.Multiline = true;
            this.txtChoiceC.Name = "txtChoiceC";
            this.txtChoiceC.Size = new System.Drawing.Size(296, 101);
            this.txtChoiceC.TabIndex = 2;
            this.txtChoiceC.TextChanged += new System.EventHandler(this.txtChoiceC_TextChanged);
            // 
            // txtChoiceD
            // 
            this.txtChoiceD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceD.Location = new System.Drawing.Point(468, 132);
            this.txtChoiceD.Multiline = true;
            this.txtChoiceD.Name = "txtChoiceD";
            this.txtChoiceD.Size = new System.Drawing.Size(296, 101);
            this.txtChoiceD.TabIndex = 3;
            this.txtChoiceD.TextChanged += new System.EventHandler(this.txtChoiceD_TextChanged);
            // 
            // txtChoiceB
            // 
            this.txtChoiceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceB.Location = new System.Drawing.Point(467, 18);
            this.txtChoiceB.Multiline = true;
            this.txtChoiceB.Name = "txtChoiceB";
            this.txtChoiceB.Size = new System.Drawing.Size(296, 101);
            this.txtChoiceB.TabIndex = 1;
            this.txtChoiceB.TextChanged += new System.EventHandler(this.txtChoiceB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Choices:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoChoiceD);
            this.panel1.Controls.Add(this.rdoChoiceB);
            this.panel1.Controls.Add(this.rdoChoiceC);
            this.panel1.Controls.Add(this.rdoChoiceA);
            this.panel1.Controls.Add(this.txtChoiceA);
            this.panel1.Controls.Add(this.txtChoiceD);
            this.panel1.Controls.Add(this.txtChoiceB);
            this.panel1.Controls.Add(this.txtChoiceC);
            this.panel1.Location = new System.Drawing.Point(147, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 240);
            this.panel1.TabIndex = 1;
            // 
            // rdoChoiceD
            // 
            this.rdoChoiceD.AutoSize = true;
            this.rdoChoiceD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoiceD.Location = new System.Drawing.Point(417, 158);
            this.rdoChoiceD.Name = "rdoChoiceD";
            this.rdoChoiceD.Size = new System.Drawing.Size(45, 33);
            this.rdoChoiceD.TabIndex = 6;
            this.rdoChoiceD.TabStop = true;
            this.rdoChoiceD.Text = "d";
            this.rdoChoiceD.UseVisualStyleBackColor = true;
            this.rdoChoiceD.CheckedChanged += new System.EventHandler(this.rdoChoices_CheckedChanged);
            // 
            // rdoChoiceB
            // 
            this.rdoChoiceB.AutoSize = true;
            this.rdoChoiceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoiceB.Location = new System.Drawing.Point(417, 53);
            this.rdoChoiceB.Name = "rdoChoiceB";
            this.rdoChoiceB.Size = new System.Drawing.Size(45, 33);
            this.rdoChoiceB.TabIndex = 2;
            this.rdoChoiceB.TabStop = true;
            this.rdoChoiceB.Text = "b";
            this.rdoChoiceB.UseVisualStyleBackColor = true;
            this.rdoChoiceB.CheckedChanged += new System.EventHandler(this.rdoChoices_CheckedChanged);
            // 
            // rdoChoiceC
            // 
            this.rdoChoiceC.AutoSize = true;
            this.rdoChoiceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoiceC.Location = new System.Drawing.Point(35, 158);
            this.rdoChoiceC.Name = "rdoChoiceC";
            this.rdoChoiceC.Size = new System.Drawing.Size(43, 33);
            this.rdoChoiceC.TabIndex = 4;
            this.rdoChoiceC.TabStop = true;
            this.rdoChoiceC.Text = "c";
            this.rdoChoiceC.UseVisualStyleBackColor = true;
            this.rdoChoiceC.CheckedChanged += new System.EventHandler(this.rdoChoices_CheckedChanged);
            // 
            // rdoChoiceA
            // 
            this.rdoChoiceA.AutoSize = true;
            this.rdoChoiceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoiceA.Location = new System.Drawing.Point(34, 53);
            this.rdoChoiceA.Name = "rdoChoiceA";
            this.rdoChoiceA.Size = new System.Drawing.Size(44, 33);
            this.rdoChoiceA.TabIndex = 0;
            this.rdoChoiceA.TabStop = true;
            this.rdoChoiceA.Text = "a";
            this.rdoChoiceA.UseVisualStyleBackColor = true;
            this.rdoChoiceA.CheckedChanged += new System.EventHandler(this.rdoChoices_CheckedChanged);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(147, 574);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(763, 35);
            this.txtAnswer.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(955, 29);
            this.menuStrip.TabIndex = 21;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importQuestionFromOtherGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveAndExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importQuestionFromOtherGameToolStripMenuItem
            // 
            this.importQuestionFromOtherGameToolStripMenuItem.Name = "importQuestionFromOtherGameToolStripMenuItem";
            this.importQuestionFromOtherGameToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.importQuestionFromOtherGameToolStripMenuItem.Text = "Import Question From Other Game";
            this.importQuestionFromOtherGameToolStripMenuItem.Click += new System.EventHandler(this.importQuestionFromOtherGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(321, 6);
            // 
            // saveAndExitToolStripMenuItem
            // 
            this.saveAndExitToolStripMenuItem.Name = "saveAndExitToolStripMenuItem";
            this.saveAndExitToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.saveAndExitToolStripMenuItem.Text = "Save and Exit";
            this.saveAndExitToolStripMenuItem.Click += new System.EventHandler(this.saveAndExitToolStripMenuItem_Click);
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
            // bwCreateChoices
            // 
            this.bwCreateChoices.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCreateChoices_DoWork);
            this.bwCreateChoices.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCreateChoices_RunWorkerCompleted);
            // 
            // bwRemoveChoices
            // 
            this.bwRemoveChoices.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRemoveChoices_DoWork);
            this.bwRemoveChoices.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRemoveChoices_RunWorkerCompleted);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(423, 643);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(212, 51);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblLimitWarning
            // 
            this.lblLimitWarning.AutoSize = true;
            this.lblLimitWarning.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLimitWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLimitWarning.Location = new System.Drawing.Point(679, 278);
            this.lblLimitWarning.Name = "lblLimitWarning";
            this.lblLimitWarning.Size = new System.Drawing.Size(224, 29);
            this.lblLimitWarning.TabIndex = 23;
            this.lblLimitWarning.Text = "Max 300 Characters";
            this.lblLimitWarning.Visible = false;
            // 
            // lblCloseWarning
            // 
            this.lblCloseWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCloseWarning.AutoSize = true;
            this.lblCloseWarning.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCloseWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCloseWarning.Location = new System.Drawing.Point(675, 9);
            this.lblCloseWarning.Name = "lblCloseWarning";
            this.lblCloseWarning.Size = new System.Drawing.Size(268, 20);
            this.lblCloseWarning.TabIndex = 40;
            this.lblCloseWarning.Text = "Cannot Close yet. Save in progress...";
            this.lblCloseWarning.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCloseWarning.Visible = false;
            // 
            // frmEditQuestion
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(955, 727);
            this.Controls.Add(this.lblCloseWarning);
            this.Controls.Add(this.lblLimitWarning);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuestionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblCategoryTitle);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 697);
            this.Name = "frmEditQuestion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Question";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditQuestion_FormClosing);
            this.Load += new System.EventHandler(this.frmEditQuestion_Load);
            this.pnlTypes.ResumeLayout(false);
            this.pnlTypes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.RadioButton rdoFillInTheBlank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTypes;
        private System.Windows.Forms.RadioButton rdoTrueFalse;
        private System.Windows.Forms.RadioButton rdoMultipleChoice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtChoiceA;
        private System.Windows.Forms.TextBox txtChoiceC;
        private System.Windows.Forms.TextBox txtChoiceD;
        private System.Windows.Forms.TextBox txtChoiceB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoChoiceD;
        private System.Windows.Forms.RadioButton rdoChoiceB;
        private System.Windows.Forms.RadioButton rdoChoiceC;
        private System.Windows.Forms.RadioButton rdoChoiceA;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importQuestionFromOtherGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bwCreateChoices;
        private System.ComponentModel.BackgroundWorker bwRemoveChoices;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAndExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblLimitWarning;
        private System.Windows.Forms.Label lblCloseWarning;
    }
}
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
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTypes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(26, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(763, 127);
            this.textBox1.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(68, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 599);
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
            this.pnlTypes.Location = new System.Drawing.Point(148, 265);
            this.pnlTypes.Name = "pnlTypes";
            this.pnlTypes.Size = new System.Drawing.Size(775, 67);
            this.pnlTypes.TabIndex = 7;
            // 
            // rdoTrueFalse
            // 
            this.rdoTrueFalse.AutoSize = true;
            this.rdoTrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrueFalse.Location = new System.Drawing.Point(595, 17);
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
            this.rdoMultipleChoice.Location = new System.Drawing.Point(289, 17);
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
            this.btnCancel.Location = new System.Drawing.Point(148, 654);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(741, 654);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(170, 44);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
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
            this.txtChoiceA.TabIndex = 1;
            // 
            // txtChoiceC
            // 
            this.txtChoiceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceC.Location = new System.Drawing.Point(84, 132);
            this.txtChoiceC.Multiline = true;
            this.txtChoiceC.Name = "txtChoiceC";
            this.txtChoiceC.Size = new System.Drawing.Size(296, 101);
            this.txtChoiceC.TabIndex = 5;
            // 
            // txtChoiceD
            // 
            this.txtChoiceD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceD.Location = new System.Drawing.Point(468, 132);
            this.txtChoiceD.Multiline = true;
            this.txtChoiceD.Name = "txtChoiceD";
            this.txtChoiceD.Size = new System.Drawing.Size(296, 101);
            this.txtChoiceD.TabIndex = 7;
            // 
            // txtChoiceB
            // 
            this.txtChoiceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceB.Location = new System.Drawing.Point(467, 18);
            this.txtChoiceB.Multiline = true;
            this.txtChoiceB.Name = "txtChoiceB";
            this.txtChoiceB.Size = new System.Drawing.Size(296, 101);
            this.txtChoiceB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 450);
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
            this.panel1.Location = new System.Drawing.Point(148, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 240);
            this.panel1.TabIndex = 19;
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
            this.txtAnswer.Location = new System.Drawing.Point(148, 596);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(763, 35);
            this.txtAnswer.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(340, 50);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(395, 40);
            this.btnCopy.TabIndex = 20;
            this.btnCopy.Text = "Import From Other Game";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // frmEditQuestion
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(955, 729);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblCategoryTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "frmEditQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditQuestion";
            this.Load += new System.EventHandler(this.frmEditQuestion_Load);
            this.pnlTypes.ResumeLayout(false);
            this.pnlTypes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}
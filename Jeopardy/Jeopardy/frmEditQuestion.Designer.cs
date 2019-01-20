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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdoChoiceB = new System.Windows.Forms.RadioButton();
            this.rdoChoiceC = new System.Windows.Forms.RadioButton();
            this.rdoChoiceA = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlTypes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.AutoSize = true;
            this.lblCategoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryTitle.Location = new System.Drawing.Point(25, 26);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Size = new System.Drawing.Size(215, 37);
            this.lblCategoryTitle.TabIndex = 0;
            this.lblCategoryTitle.Text = "Category Title";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(735, 26);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(69, 37);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(147, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(763, 127);
            this.textBox1.TabIndex = 3;
            // 
            // rdoFillInTheBlank
            // 
            this.rdoFillInTheBlank.AutoSize = true;
            this.rdoFillInTheBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFillInTheBlank.Location = new System.Drawing.Point(13, 19);
            this.rdoFillInTheBlank.Name = "rdoFillInTheBlank";
            this.rdoFillInTheBlank.Size = new System.Drawing.Size(194, 33);
            this.rdoFillInTheBlank.TabIndex = 4;
            this.rdoFillInTheBlank.TabStop = true;
            this.rdoFillInTheBlank.Text = "Fill In the Blank";
            this.rdoFillInTheBlank.UseVisualStyleBackColor = true;
            this.rdoFillInTheBlank.CheckedChanged += new System.EventHandler(this.rdoType_Change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 554);
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
            this.pnlTypes.Location = new System.Drawing.Point(147, 223);
            this.pnlTypes.Name = "pnlTypes";
            this.pnlTypes.Size = new System.Drawing.Size(763, 77);
            this.pnlTypes.TabIndex = 7;
            // 
            // rdoTrueFalse
            // 
            this.rdoTrueFalse.AutoSize = true;
            this.rdoTrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrueFalse.Location = new System.Drawing.Point(595, 19);
            this.rdoTrueFalse.Name = "rdoTrueFalse";
            this.rdoTrueFalse.Size = new System.Drawing.Size(161, 33);
            this.rdoTrueFalse.TabIndex = 6;
            this.rdoTrueFalse.TabStop = true;
            this.rdoTrueFalse.Text = "True / False";
            this.rdoTrueFalse.UseVisualStyleBackColor = true;
            this.rdoTrueFalse.CheckedChanged += new System.EventHandler(this.rdoType_Change);
            // 
            // rdoMultipleChoice
            // 
            this.rdoMultipleChoice.AutoSize = true;
            this.rdoMultipleChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMultipleChoice.Location = new System.Drawing.Point(289, 19);
            this.rdoMultipleChoice.Name = "rdoMultipleChoice";
            this.rdoMultipleChoice.Size = new System.Drawing.Size(198, 33);
            this.rdoMultipleChoice.TabIndex = 5;
            this.rdoMultipleChoice.TabStop = true;
            this.rdoMultipleChoice.Text = "Multiple Choice";
            this.rdoMultipleChoice.UseVisualStyleBackColor = true;
            this.rdoMultipleChoice.CheckedChanged += new System.EventHandler(this.rdoType_Change);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(32, 616);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(742, 616);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(170, 40);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtChoiceA
            // 
            this.txtChoiceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceA.Location = new System.Drawing.Point(84, 3);
            this.txtChoiceA.Multiline = true;
            this.txtChoiceA.Name = "txtChoiceA";
            this.txtChoiceA.Size = new System.Drawing.Size(278, 84);
            this.txtChoiceA.TabIndex = 11;
            // 
            // txtChoiceC
            // 
            this.txtChoiceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceC.Location = new System.Drawing.Point(84, 117);
            this.txtChoiceC.Multiline = true;
            this.txtChoiceC.Name = "txtChoiceC";
            this.txtChoiceC.Size = new System.Drawing.Size(278, 84);
            this.txtChoiceC.TabIndex = 13;
            // 
            // txtChoiceD
            // 
            this.txtChoiceD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceD.Location = new System.Drawing.Point(486, 117);
            this.txtChoiceD.Multiline = true;
            this.txtChoiceD.Name = "txtChoiceD";
            this.txtChoiceD.Size = new System.Drawing.Size(278, 84);
            this.txtChoiceD.TabIndex = 15;
            // 
            // txtChoiceB
            // 
            this.txtChoiceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoiceB.Location = new System.Drawing.Point(485, 3);
            this.txtChoiceB.Multiline = true;
            this.txtChoiceB.Name = "txtChoiceB";
            this.txtChoiceB.Size = new System.Drawing.Size(278, 84);
            this.txtChoiceB.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Choices:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.rdoChoiceB);
            this.panel1.Controls.Add(this.rdoChoiceC);
            this.panel1.Controls.Add(this.rdoChoiceA);
            this.panel1.Controls.Add(this.txtChoiceA);
            this.panel1.Controls.Add(this.txtChoiceD);
            this.panel1.Controls.Add(this.txtChoiceB);
            this.panel1.Controls.Add(this.txtChoiceC);
            this.panel1.Location = new System.Drawing.Point(147, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 207);
            this.panel1.TabIndex = 19;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(435, 143);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 33);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "d";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdoChoiceB
            // 
            this.rdoChoiceB.AutoSize = true;
            this.rdoChoiceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoiceB.Location = new System.Drawing.Point(434, 31);
            this.rdoChoiceB.Name = "rdoChoiceB";
            this.rdoChoiceB.Size = new System.Drawing.Size(45, 33);
            this.rdoChoiceB.TabIndex = 20;
            this.rdoChoiceB.TabStop = true;
            this.rdoChoiceB.Text = "b";
            this.rdoChoiceB.UseVisualStyleBackColor = true;
            // 
            // rdoChoiceC
            // 
            this.rdoChoiceC.AutoSize = true;
            this.rdoChoiceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoiceC.Location = new System.Drawing.Point(35, 143);
            this.rdoChoiceC.Name = "rdoChoiceC";
            this.rdoChoiceC.Size = new System.Drawing.Size(43, 33);
            this.rdoChoiceC.TabIndex = 19;
            this.rdoChoiceC.TabStop = true;
            this.rdoChoiceC.Text = "c";
            this.rdoChoiceC.UseVisualStyleBackColor = true;
            // 
            // rdoChoiceA
            // 
            this.rdoChoiceA.AutoSize = true;
            this.rdoChoiceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoiceA.Location = new System.Drawing.Point(34, 31);
            this.rdoChoiceA.Name = "rdoChoiceA";
            this.rdoChoiceA.Size = new System.Drawing.Size(44, 33);
            this.rdoChoiceA.TabIndex = 18;
            this.rdoChoiceA.TabStop = true;
            this.rdoChoiceA.Text = "a";
            this.rdoChoiceA.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(147, 551);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(763, 35);
            this.textBox2.TabIndex = 22;
            // 
            // frmEditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 670);
            this.Controls.Add(this.textBox2);
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
            this.Name = "frmEditQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditQuestion";
            this.pnlTypes.ResumeLayout(false);
            this.pnlTypes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdoChoiceB;
        private System.Windows.Forms.RadioButton rdoChoiceC;
        private System.Windows.Forms.RadioButton rdoChoiceA;
        private System.Windows.Forms.TextBox textBox2;
    }
}
namespace Jeopardy
{
    partial class frmMultipleChoice
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
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdoFirstChoice = new System.Windows.Forms.RadioButton();
            this.rdoSecondChoice = new System.Windows.Forms.RadioButton();
            this.rdoThirdChoice = new System.Windows.Forms.RadioButton();
            this.rdoFourthChoice = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(13, 13);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(76, 25);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "label1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(204, 286);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(235, 45);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdoFirstChoice
            // 
            this.rdoFirstChoice.AutoSize = true;
            this.rdoFirstChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFirstChoice.Location = new System.Drawing.Point(18, 71);
            this.rdoFirstChoice.Name = "rdoFirstChoice";
            this.rdoFirstChoice.Size = new System.Drawing.Size(14, 13);
            this.rdoFirstChoice.TabIndex = 3;
            this.rdoFirstChoice.TabStop = true;
            this.rdoFirstChoice.UseVisualStyleBackColor = true;
            // 
            // rdoSecondChoice
            // 
            this.rdoSecondChoice.AutoSize = true;
            this.rdoSecondChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSecondChoice.Location = new System.Drawing.Point(18, 127);
            this.rdoSecondChoice.Name = "rdoSecondChoice";
            this.rdoSecondChoice.Size = new System.Drawing.Size(14, 13);
            this.rdoSecondChoice.TabIndex = 4;
            this.rdoSecondChoice.TabStop = true;
            this.rdoSecondChoice.UseVisualStyleBackColor = true;
            // 
            // rdoThirdChoice
            // 
            this.rdoThirdChoice.AutoSize = true;
            this.rdoThirdChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThirdChoice.Location = new System.Drawing.Point(18, 183);
            this.rdoThirdChoice.Name = "rdoThirdChoice";
            this.rdoThirdChoice.Size = new System.Drawing.Size(14, 13);
            this.rdoThirdChoice.TabIndex = 5;
            this.rdoThirdChoice.TabStop = true;
            this.rdoThirdChoice.UseVisualStyleBackColor = true;
            // 
            // rdoFourthChoice
            // 
            this.rdoFourthChoice.AutoSize = true;
            this.rdoFourthChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFourthChoice.Location = new System.Drawing.Point(18, 239);
            this.rdoFourthChoice.Name = "rdoFourthChoice";
            this.rdoFourthChoice.Size = new System.Drawing.Size(14, 13);
            this.rdoFourthChoice.TabIndex = 6;
            this.rdoFourthChoice.TabStop = true;
            this.rdoFourthChoice.UseVisualStyleBackColor = true;
            // 
            // frmMultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 342);
            this.Controls.Add(this.rdoFourthChoice);
            this.Controls.Add(this.rdoThirdChoice);
            this.Controls.Add(this.rdoSecondChoice);
            this.Controls.Add(this.rdoFirstChoice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblQuestionText);
            this.Name = "frmMultipleChoice";
            this.Text = "Jeopardy!";
            this.Load += new System.EventHandler(this.frmMultipleChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoFirstChoice;
        private System.Windows.Forms.RadioButton rdoSecondChoice;
        private System.Windows.Forms.RadioButton rdoThirdChoice;
        private System.Windows.Forms.RadioButton rdoFourthChoice;
    }
}
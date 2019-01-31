namespace Jeopardy
{
    partial class frmFillInTheBlank
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(46, 9);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(99, 32);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "label1";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(13, 218);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(132, 32);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Answer?";
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAnswer.Location = new System.Drawing.Point(312, 202);
            this.txtUserAnswer.Multiline = true;
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(476, 48);
            this.txtUserAnswer.TabIndex = 2;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(13, 287);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(231, 32);
            this.lblCorrectAnswer.TabIndex = 3;
            this.lblCorrectAnswer.Text = "Correct Answer:";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorrectAnswer.Location = new System.Drawing.Point(312, 271);
            this.txtCorrectAnswer.Multiline = true;
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.ReadOnly = true;
            this.txtCorrectAnswer.Size = new System.Drawing.Size(476, 48);
            this.txtCorrectAnswer.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(268, 356);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(264, 82);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmFillInTheBlank
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestionText);
            this.Name = "frmFillInTheBlank";
            this.Text = "Jeopardy!";
            this.Load += new System.EventHandler(this.frmFillInTheBlank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.Button btnSubmit;
    }
}
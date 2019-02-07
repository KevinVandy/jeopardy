namespace Jeopardy
{
    partial class frmReviewWrongQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReviewWrongQuestions));
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnRevealAnswer = new System.Windows.Forms.Button();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(33, 23);
            this.lblQuestionText.MaximumSize = new System.Drawing.Size(900, 250);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(900, 228);
            this.lblQuestionText.TabIndex = 12;
            this.lblQuestionText.Text = resources.GetString("lblQuestionText.Text");
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(364, 461);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(246, 59);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // btnRevealAnswer
            // 
            this.btnRevealAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevealAnswer.Location = new System.Drawing.Point(698, 318);
            this.btnRevealAnswer.Name = "btnRevealAnswer";
            this.btnRevealAnswer.Size = new System.Drawing.Size(246, 59);
            this.btnRevealAnswer.TabIndex = 14;
            this.btnRevealAnswer.Text = "Show Answer";
            this.btnRevealAnswer.UseVisualStyleBackColor = true;
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorrectAnswer.Location = new System.Drawing.Point(31, 326);
            this.txtCorrectAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.ReadOnly = true;
            this.txtCorrectAnswer.Size = new System.Drawing.Size(654, 44);
            this.txtCorrectAnswer.TabIndex = 15;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(31, 461);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(246, 59);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(697, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 59);
            this.button2.TabIndex = 17;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(433, 398);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(96, 37);
            this.lblIndex.TabIndex = 18;
            this.lblIndex.Text = "1 of 5";
            // 
            // frmReviewWrongQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 551);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.btnRevealAnswer);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblQuestionText);
            this.Name = "frmReviewWrongQuestions";
            this.Text = "frmReviewWrongQuestions";
            this.Load += new System.EventHandler(this.frmReviewWrongQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnRevealAnswer;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblIndex;
    }
}
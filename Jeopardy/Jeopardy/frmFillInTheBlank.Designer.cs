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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFillInTheBlank));
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnOverwrite = new System.Windows.Forms.Button();
            this.lblCorrectIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(69, 368);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(259, 46);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Your Answer:";
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAnswer.Location = new System.Drawing.Point(356, 364);
            this.txtUserAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserAnswer.Multiline = true;
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(476, 48);
            this.txtUserAnswer.TabIndex = 2;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(33, 453);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(307, 46);
            this.lblCorrectAnswer.TabIndex = 3;
            this.lblCorrectAnswer.Text = "Correct Answer:";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorrectAnswer.Location = new System.Drawing.Point(356, 449);
            this.txtCorrectAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorrectAnswer.Multiline = true;
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.ReadOnly = true;
            this.txtCorrectAnswer.Size = new System.Drawing.Size(476, 48);
            this.txtCorrectAnswer.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(919, 364);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(312, 50);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(31, 23);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionText.MaximumSize = new System.Drawing.Size(1200, 308);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(1191, 240);
            this.lblQuestionText.TabIndex = 11;
            this.lblQuestionText.Text = resources.GetString("lblQuestionText.Text");
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(581, 615);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(101, 46);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "1:00";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(43, 594);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(312, 66);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(917, 604);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(312, 66);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnOverwrite
            // 
            this.btnOverwrite.Enabled = false;
            this.btnOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverwrite.Location = new System.Drawing.Point(919, 451);
            this.btnOverwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOverwrite.Name = "btnOverwrite";
            this.btnOverwrite.Size = new System.Drawing.Size(312, 50);
            this.btnOverwrite.TabIndex = 15;
            this.btnOverwrite.Text = "Overwrite";
            this.btnOverwrite.UseVisualStyleBackColor = true;
            this.btnOverwrite.Click += new System.EventHandler(this.btnOverwrite_Click);
            // 
            // lblCorrectIncorrect
            // 
            this.lblCorrectIncorrect.AutoSize = true;
            this.lblCorrectIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectIncorrect.Location = new System.Drawing.Point(927, 290);
            this.lblCorrectIncorrect.Name = "lblCorrectIncorrect";
            this.lblCorrectIncorrect.Size = new System.Drawing.Size(304, 44);
            this.lblCorrectIncorrect.TabIndex = 16;
            this.lblCorrectIncorrect.Text = "Correct/Incorrect";
            this.lblCorrectIncorrect.Visible = false;
            // 
            // frmFillInTheBlank
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 767);
            this.Controls.Add(this.lblCorrectIncorrect);
            this.Controls.Add(this.btnOverwrite);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFillInTheBlank";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jeopardy!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFillInTheBlank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnOverwrite;
        private System.Windows.Forms.Label lblCorrectIncorrect;
    }
}
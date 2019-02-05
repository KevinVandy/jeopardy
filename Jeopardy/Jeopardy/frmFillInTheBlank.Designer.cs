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
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(52, 299);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(211, 37);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Your Answer:";
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAnswer.Location = new System.Drawing.Point(267, 296);
            this.txtUserAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserAnswer.Multiline = true;
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(358, 40);
            this.txtUserAnswer.TabIndex = 2;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(25, 368);
            this.lblCorrectAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(247, 37);
            this.lblCorrectAnswer.TabIndex = 3;
            this.lblCorrectAnswer.Text = "Correct Answer:";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorrectAnswer.Location = new System.Drawing.Point(267, 365);
            this.txtCorrectAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorrectAnswer.Multiline = true;
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.ReadOnly = true;
            this.txtCorrectAnswer.Size = new System.Drawing.Size(358, 40);
            this.txtCorrectAnswer.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(689, 296);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(234, 109);
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
            this.lblQuestionText.Location = new System.Drawing.Point(23, 19);
            this.lblQuestionText.MaximumSize = new System.Drawing.Size(900, 250);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(900, 228);
            this.lblQuestionText.TabIndex = 11;
            this.lblQuestionText.Text = resources.GetString("lblQuestionText.Text");
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(436, 500);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(82, 37);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "1:00";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(32, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(234, 54);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(688, 491);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(234, 54);
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
            // frmFillInTheBlank
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 623);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}
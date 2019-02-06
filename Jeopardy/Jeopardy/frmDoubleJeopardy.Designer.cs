namespace Jeopardy
{
    partial class frmDoubleJeopardy
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPoints = new System.Windows.Forms.TrackBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.nudPoints = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Double!";
            // 
            // tbPoints
            // 
            this.tbPoints.LargeChange = 500;
            this.tbPoints.Location = new System.Drawing.Point(123, 90);
            this.tbPoints.Maximum = 1000;
            this.tbPoints.Minimum = 100;
            this.tbPoints.Name = "tbPoints";
            this.tbPoints.Size = new System.Drawing.Size(447, 45);
            this.tbPoints.SmallChange = 100;
            this.tbPoints.TabIndex = 1;
            this.tbPoints.TickFrequency = 100;
            this.tbPoints.Value = 100;
            this.tbPoints.Scroll += new System.EventHandler(this.tbPoints_Scroll);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(32, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(193, 44);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(512, 178);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(193, 44);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(25, 82);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(69, 37);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "100";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(599, 82);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(87, 37);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "1000";
            // 
            // nudPoints
            // 
            this.nudPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPoints.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPoints.Location = new System.Drawing.Point(305, 177);
            this.nudPoints.Name = "nudPoints";
            this.nudPoints.ReadOnly = true;
            this.nudPoints.Size = new System.Drawing.Size(120, 44);
            this.nudPoints.TabIndex = 6;
            this.nudPoints.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPoints.ValueChanged += new System.EventHandler(this.nudPoints_ValueChanged);
            // 
            // frmDoubleJeopardy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 250);
            this.Controls.Add(this.nudPoints);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbPoints);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoubleJeopardy";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Double Jeopardy!";
            this.Load += new System.EventHandler(this.frmDoubleJeopardy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbPoints;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown nudPoints;
    }
}
namespace Jeopardy.Forms.Admin
{
    partial class frmTroubleshooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTroubleshooter));
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRepair
            // 
            this.btnRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepair.Location = new System.Drawing.Point(7, 341);
            this.btnRepair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(318, 57);
            this.btnRepair.TabIndex = 0;
            this.btnRepair.Text = "Compact and Repair";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(8, 561);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(318, 57);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Factory Reset";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MaximumSize = new System.Drawing.Size(700, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 104);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MaximumSize = new System.Drawing.Size(700, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(690, 104);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(458, 561);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(274, 57);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.Location = new System.Drawing.Point(9, 143);
            this.btnInstall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(318, 57);
            this.btnInstall.TabIndex = 6;
            this.btnInstall.Text = "Install Access Runtime";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MaximumSize = new System.Drawing.Size(700, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(693, 104);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // frmTroubleshooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(772, 645);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnRepair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmTroubleshooter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Troubleshooting";
            this.Load += new System.EventHandler(this.frmTroubleshooter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label label3;
    }
}
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Jeopardy.Forms.Admin
{
    public partial class frmTroubleshooter : Form
    {
        public frmTroubleshooter()
        {
            InitializeComponent();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to reset the database to just the default games that came pre-installed? You may lose progress on any games that you created or edited. Consider Exporting any games that you want to save to an XML file.", "Factory Reset Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if(dialogResult == DialogResult.Yes)
            {
                if (DB_Conn.RestoreDBFromBackup())
                {
                    btnRestore.Enabled = false;
                    btnRepair.Enabled = false;
                    MessageBox.Show("Database restore successfully", "Success");
                }
                else
                {
                    MessageBox.Show("Database could not be restored. You may need to re-install this program.", "Failure to Restore");
                }
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {

            if (DB_Conn.CompactAndRepair())
            {
                btnRepair.Enabled = false;
            }
            else
            {
                MessageBox.Show("The database could not be Compacted and Repaired. You will need to open up the games.accdb file in access if you want to still compact and repair. Refer to the Help manual for more instructions.", "Failure to Optimize", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInstall_Click_1(object sender, EventArgs e)
        {
            DB_Conn.InstallAccessRuntime();

        }


    }
}

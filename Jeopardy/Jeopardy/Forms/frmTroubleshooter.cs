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

        private void frmTroubleshooter_Load(object sender, EventArgs e)
        {
            EnableAllControls();
        }

        private void btnInstall_Click_1(object sender, EventArgs e)
        {
            DisableAllControls();
            DB_Conn.InstallAccessRuntime();
            EnableAllControls();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            DisableAllControls();
            if (DB_Conn.CompactAndRepair())
            {
                MessageBox.Show("Successfully Compacted and Repaired the games database file.", "Success");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("The database could not be Compacted and Repaired. You will need to open up the games.accdb file in Access if you want to still compact and repair. \n\nDo you want to open the folder where the database is located so that you can open it in Access?\n\nWarning. Don't delete anything in this folder!", "Failure to Optimize", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

                if(dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Jeopardy2019");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Could not find the folder:\n" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Jeopardy2019");
                        Console.Write(ex.ToString());
                    }
                }
            }

            EnableAllControls();
            btnRepair.Enabled = false;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DisableAllControls();

            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to reset the database to just the default games that came pre-installed? You may lose progress on any games that you created or edited. Consider Exporting any games that you want to save to an XML file.", "Factory Reset Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if(dialogResult == DialogResult.Yes)
            {
                if (DB_Conn.RestoreDBFromBackup())
                {
                    
                    MessageBox.Show("Database restore successfully", "Success");
                }
                else
                {
                    MessageBox.Show("Database could not be restored. You may need to re-install this program.", "Failure to Restore");
                }
            }

            EnableAllControls();
            btnRestore.Enabled = false;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //MARK: Menu Bar Item Event Handlers
        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_Conn.OpenHelpFile();
        }

        //MARK: Other Private Functions
        private void DisableAllControls()
        {
            btnInstall.Enabled = false;
            btnRepair.Enabled = false;
            btnRestore.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void EnableAllControls()
        {
            btnInstall.Enabled = true;
            btnRepair.Enabled = true;
            btnRestore.Enabled = true;
            btnCancel.Enabled = true;
        }
    }
}

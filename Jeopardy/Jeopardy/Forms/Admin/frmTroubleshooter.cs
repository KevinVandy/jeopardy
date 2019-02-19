using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            DB_Conn.CompactAndRepair();
        }
    }
}

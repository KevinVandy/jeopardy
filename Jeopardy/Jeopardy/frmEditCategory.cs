using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmEditCategory : Form
    {
        int gameId;
        Category newCategory;

        public frmEditCategory(int theGameId)
        {
            gameId = theGameId;

            InitializeComponent();
        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            newCategory = new Category();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportCategory importCategoryForm = new frmImportCategory();
            DialogResult dialogResult = importCategoryForm.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newCategory.GameId = gameId;
            newCategory.Title = txtTitle.Text;
            newCategory.Subtitle = txtSubtitle.Text;
            
            if(ValidateData.ValidateCategoryTitle(newCategory.Title) && ValidateData.ValidateCategorySubtitle(newCategory.Subtitle))
            {
                DB_Insert.InsertCategory(newCategory);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

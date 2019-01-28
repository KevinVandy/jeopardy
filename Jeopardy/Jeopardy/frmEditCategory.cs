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
        Category category;

        public frmEditCategory(Category theCategory)
        {
            category = theCategory;

            InitializeComponent();
        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            txtTitle.Text = category.Title;
            txtSubtitle.Text = category.Subtitle;

            txtTitle.Focus();
            txtTitle.SelectAll();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportCategory importCategoryForm = new frmImportCategory();
            DialogResult dialogResult = importCategoryForm.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                //TODO
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(ValidateData.ValidateCategoryTitle(txtTitle.Text) && ValidateData.ValidateCategorySubtitle(txtSubtitle.Text))
            {
                category.Title = txtTitle.Text;
                category.Subtitle = txtSubtitle.Text;

                //DB_Insert.InsertCategory(newCategory); change to update
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}

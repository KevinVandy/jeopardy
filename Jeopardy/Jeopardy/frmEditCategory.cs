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

        //MARK: Button Event Handlers
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(ValidateData.ValidateCategoryTitle(txtTitle.Text) && ValidateData.ValidateCategorySubtitle(txtSubtitle.Text))
            {
                category.Title = txtTitle.Text;
                category.Subtitle = txtSubtitle.Text;

                if (!DB_Update.UpdateCategory(category))
                {
                    MessageBox.Show("Updating Category Failed");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportCategory importCategoryForm = new frmImportCategory();
            DialogResult dialogResult = importCategoryForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                category.Title = importCategoryForm.selectedCategory.Title;
                category.Subtitle = importCategoryForm.selectedCategory.Subtitle;

                if (importCategoryForm.selectedCategory.Questions.Count > 0) //only import questions if there are any
                {
                    //only imports questions to the max size of the grid and the max size of the other game grid
                    for (int i = 0; i < category.Questions.Count && i < importCategoryForm.selectedCategory.Questions.Count; i++) 
                    {
                        category.Questions[i].Type = importCategoryForm.selectedCategory.Questions[i].Type;
                        category.Questions[i].QuestionText = importCategoryForm.selectedCategory.Questions[i].QuestionText;
                        category.Questions[i].Answer = importCategoryForm.selectedCategory.Questions[i].Answer;

                        DB_Update.UpdateQuestion(category.Questions[i]);

                        if (importCategoryForm.selectedCategory.Questions[i].Type == "mc") //if is multiple choice
                        {
                            category.Questions[i].Choices = importCategoryForm.selectedCategory.Questions[i].Choices;

                            for(int j = 0; j < 4; j++)
                            {
                                DB_Update.UpdateChoice(category.Questions[i].Choices[j]);
                            }
                        }
                    }
                }

                frmEditCategory_Load(sender, e);
            }
        }

        private void importCategoryFromOtherGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnImport_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

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
                        //if going from multiple choice to another type, delete the choices
                        if(category.Questions[i].Type == "mc" && importCategoryForm.selectedCategory.Questions[i].Type != "mc")
                        {
                            for(int j = 0; j < 4 && j < category.Questions[i].Choices.Count; j++)
                            {
                                DB_Delete.DeleteChoice(category.Questions[i].Choices[j].Id);
                            }
                        }
                        // going from other type of question to multiple choice, make the choices
                        else if(category.Questions[i].Type != "mc" && importCategoryForm.selectedCategory.Questions[i].Type == "mc")
                        {
                            category.Questions[i].Choices = new List<Choice>(new Choice[4]);
                            for (int j = 0; j < 4 && j < category.Questions[i].Choices.Count; j++)
                            {
                                category.Questions[i].Choices[j] = new Choice();
                                category.Questions[i].Choices[j].QuestionId = (int)category.Questions[i].Id;
                                category.Questions[i].Choices[j].Index = j;
                                category.Questions[i].Choices[j].Text = importCategoryForm.selectedCategory.Questions[i].Choices[j].Text;
                                category.Questions[i].Choices[j].Id = DB_Insert.InsertChoice(category.Questions[i].Choices[j]);
                            }
                        }
                        //if both are multiple choice, just do a simple update
                        else if (category.Questions[i].Type == "mc" && importCategoryForm.selectedCategory.Questions[i].Type == "mc")
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                category.Questions[i].Choices[j].Text = importCategoryForm.selectedCategory.Questions[i].Choices[j].Text;
                                DB_Update.UpdateChoice(category.Questions[i].Choices[j]);
                            }
                        }

                        //set the other new properties of the importing questions. This needs to go after the previous code
                        category.Questions[i].Type = importCategoryForm.selectedCategory.Questions[i].Type;
                        category.Questions[i].QuestionText = importCategoryForm.selectedCategory.Questions[i].QuestionText;
                        category.Questions[i].Answer = importCategoryForm.selectedCategory.Questions[i].Answer;

                        //update the question (import the question)
                        DB_Update.UpdateQuestion(category.Questions[i]);
                    }
                }

                frmEditCategory_Load(sender, e); //reload form and new info should show
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

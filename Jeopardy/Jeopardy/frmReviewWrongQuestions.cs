﻿using System;
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
    public partial class frmReviewWrongQuestions : Form
    {
        List<Question> WrongQuestions;

        public frmReviewWrongQuestions(List<Question> wrongQuestions, Team[] teams)
        {
            WrongQuestions = wrongQuestions;
            InitializeComponent();
        }

        private void frmReviewWrongQuestions_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NTier.StudentManager;

namespace NTier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 查询ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void 添加新学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStudentForm insf = new InputStudentForm();
            insf.ShowDialog();
        }
    }
}
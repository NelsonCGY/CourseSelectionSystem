using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.CourseManager
{
    public partial class CourseSearchForm : Form
    {
        string courseNo;
        public CourseSearchForm()
        {
            InitializeComponent();           
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
            CourseManagerAction.loadAllCourse(lv, tb1.Text, tb2.Text);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            AddTeacherCourseForm  atcf = new AddTeacherCourseForm ();
            atcf.b = lv.SelectedItems[0].SubItems[0].Text;
            atcf.StartPosition = FormStartPosition.CenterScreen;
            atcf.Show();            
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一条信息", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(458, 464);
                courseNo = lv.SelectedItems[0].SubItems[0].Text;
                Course  c = new Course(courseNo , "");
                CourseManagerAction cma = new CourseManagerAction();
                cma.setCourse(c);
                cma.loadOpenedCourse (lv1);
            }
        }

        private void CourseSearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}

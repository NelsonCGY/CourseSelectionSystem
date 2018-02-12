using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.CourseManager
{
   
    public partial class StudentListForm : Form
    {
        public string a, c;
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            string teacherCourseNo = a;
            string courseName = c;
            tb1.Text = teacherCourseNo;
            tb2.Text = courseName;
            CourseManagerAction cma = new CourseManagerAction();
            cma.loadOpenedCourseStudent(lv, teacherCourseNo);           
        }
    }
}

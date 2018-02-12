using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.CourseManager
{
    public partial class AddTeacherCourseForm : Form
    {
        public string b;
        public AddTeacherCourseForm()
        {
            InitializeComponent();
        }

        private void AddTeacherCourseForm_Load(object sender, EventArgs e)
        {
            CourseSearchForm csf=new CourseSearchForm ();
            string courseNo = b;
            Course c = new Course(courseNo, "");
            CourseManagerAction cma = new CourseManagerAction();
            cma.setCourse(c);
            cma.loadOpenedCourseDetail(lv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string courseNo = b;
            CourseManagerAction cma = new CourseManagerAction();
            cma.openCourse(courseNo, tb1.Text, tb2.Text, tb3.Text);
            Course c = new Course(courseNo, "");
            cma.setCourse(c);
            cma.loadOpenedCourseDetail(lv);
        }
    }
}

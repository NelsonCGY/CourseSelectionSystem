using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.CourseManager
{
    public partial class UpdateCourseForm : Form
    {
        public UpdateCourseForm()
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
            if (lv.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一条信息", "Error", MessageBoxButtons.OK);
                return;
            }
                string courseNo = lv.SelectedItems[0].Text.ToString();
                Course c = new Course(courseNo, "");
                CourseManagerAction cma = new CourseManagerAction();
                cma.setCourse(c);
                if (cma.CourseDelete())
                    MessageBox.Show("该学生记录已删除！", "提示信息", MessageBoxButtons.OK);
                else
                    MessageBox.Show("删除失败！", "提示信息", MessageBoxButtons.OK);
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
                this.ClientSize = new System.Drawing.Size(460, 425);
                tb3.Text = lv.SelectedItems[0].SubItems[0].Text;
                tb4.Text = lv.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            Course c = new Course(tb3.Text, tb4.Text);
            CourseManagerAction cma = new CourseManagerAction();
            cma.setCourse (c);
            if (cma.CourseUpdate ())
                MessageBox.Show("修改成功！", "提示信息", MessageBoxButtons.OK);
            else
                MessageBox.Show("修改失败！", "提示信息", MessageBoxButtons.OK);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.CourseManager
{
    public partial class SearchOpenedCourseForm : Form
    {
        public SearchOpenedCourseForm()
        {
            InitializeComponent();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
            CourseManagerAction.loadAllOpenedCourse(lv, tb1.Text, tb3.Text,tb2.Text );
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一条信息", "Error", MessageBoxButtons.OK);
                return;
            }
                string teacherCourseNo = lv.SelectedItems[0].Text.ToString();
                CourseManagerAction cma = new CourseManagerAction();               
                if (cma.OpenedCourseDelete(teacherCourseNo))
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
                this.ClientSize = new System.Drawing.Size(394, 410);
                tb4.Text = lv.SelectedItems[0].SubItems[0].Text;
                tb5.Text = lv.SelectedItems[0].SubItems[1].Text;
                tb6.Text = lv.SelectedItems[0].SubItems[2].Text;
                tb7.Text = lv.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一条信息", "Error", MessageBoxButtons.OK);
                return;
            }
            StudentListForm  slf = new StudentListForm ();
            slf.a = lv.SelectedItems[0].SubItems[0].Text;
            slf.c = lv.SelectedItems[0].SubItems[1].Text;
            slf.StartPosition = FormStartPosition.CenterScreen;
            slf.Show();            
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (tb4.Text  == "")
            {
                MessageBox.Show("请输入修改信息", "Error", MessageBoxButtons.OK);
                return;
            }
            CourseManagerAction cma = new CourseManagerAction();
            cma.OpenedCourseUpdate(tb4.Text, tb5.Text, tb6.Text, tb7.Text);            
        }
    }
}

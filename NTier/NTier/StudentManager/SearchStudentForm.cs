using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.StudentManager
{
    public partial class SearchStudentForm : Form
    {
        public SearchStudentForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvStudentList.Items.Clear();
            StudentManagerAction.loadAllStudent(lvStudentList, tbStudentNo.Text, tbStudentName.Text);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvStudentList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一条信息", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(548, 540);
                string studentNo = lvStudentList.SelectedItems[0].Text.ToString();
                textBox1.Text = "学生姓名：" + lvStudentList.SelectedItems[0].SubItems[1].Text;
                Student st = new Student(studentNo, "", "", "", "");
                StudentManagerAction sma = new StudentManagerAction();
                sma.setStudent(st);
                sma.loadSelectedCourse(lvSelectedCourse);
                sma.loadUnselectedCourse(lvUnselectedCourse);
                lvStudentList.SelectedItems[0].Selected = false;
            }
        }
    }
}

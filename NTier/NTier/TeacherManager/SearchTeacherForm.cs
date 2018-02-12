using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.TeacherManager
{
    public partial class SearchTeacherForm : Form
    {
        string workerNo;
        public SearchTeacherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvSearchTeacher.Items.Clear();
            string no = tbSearchWorkerNo.Text;
            string name = tbSearchWorkerName.Text;
            TeacherManagerAction.queryTeacher(lvSearchTeacher, no, name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvSearchTeacher.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一条信息", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(500, 422);
                workerNo = lvSearchTeacher.SelectedItems[0].SubItems[0].Text;
                tbTeacher.Text = "教师姓名：" + lvSearchTeacher.SelectedItems[0].SubItems[1].Text;
                Teacher t = new Teacher(workerNo, "", "", "");
                TeacherManagerAction tma = new TeacherManagerAction();
                tma.setTeacher(t);
                tma.queryOpenedCourse(lvSelectCourse);
                lvSearchTeacher.SelectedItems[0].Selected  = false;
            }
        }
    }
}

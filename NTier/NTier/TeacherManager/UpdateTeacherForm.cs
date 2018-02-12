using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace NTier.TeacherManager
{
    public partial class UpdateTeacherForm : Form
    {
        Hashtable ht;
        public UpdateTeacherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvSeqTeacher.Items.Clear();
            string no = tbSeqWorkerNo.Text;
            string name = tbSeqWorkerName.Text;
            TeacherManagerAction.queryTeacher(lvSeqTeacher, no, name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvSeqTeacher.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一条信息", "Error", MessageBoxButtons.OK);
                return;
            }
            for (int i = 0; i < lvSeqTeacher.SelectedItems.Count; i++)
            {
                TeacherManagerAction.TeacherDelete(lvSeqTeacher.SelectedItems[i].SubItems[0].Text);
            }
            MessageBox.Show("已删除" + lvSeqTeacher.SelectedItems.Count.ToString() + "条记录！");
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            if (lvSeqTeacher.SelectedItems.Count > 1 || lvSeqTeacher.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一条且仅一条教师信息！", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(514, 448);
                tbUpdateWorkerNo.Text = lvSeqTeacher.SelectedItems[0].SubItems[0].Text;
                tbUpdateWorkerName.Text = lvSeqTeacher.SelectedItems[0].SubItems[1].Text;
                cbUpdateSex.Text = lvSeqTeacher.SelectedItems[0].SubItems[2].Text;
                ht = TeacherManagerAction.GetDeptList();
                foreach (DictionaryEntry de in ht)
                {
                    cbUpdateDepartment.Items.Add(de.Key.ToString());
                }
                cbUpdateDepartment.Text = lvSeqTeacher.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string deptId = (string)ht[cbUpdateDepartment.Text];
            Teacher t = new Teacher(tbUpdateWorkerNo.Text, tbUpdateWorkerName.Text, cbUpdateSex.Text, deptId);
            TeacherManagerAction tma = new TeacherManagerAction();
            tma.setTeacher(t);
            if (tma.TeacherUpdate())
                MessageBox.Show("保存成功！", "提示信息", MessageBoxButtons.OK);
            else
                MessageBox.Show("失败！", "提示信息", MessageBoxButtons.OK);
        }
    }
}

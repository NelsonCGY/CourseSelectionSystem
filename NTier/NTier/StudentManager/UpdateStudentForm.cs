using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace NTier.StudentManager
{
    
    public partial class UpdateStudentForm : Form
    {
        Hashtable ht;
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbStudentNo.Enabled = false; 
            if (lvStudentList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一条信息", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(541, 462);
                tbStudentNo.Text = lvStudentList.SelectedItems[0].SubItems[0].Text;
                tbStudentName.Text = lvStudentList.SelectedItems[0].SubItems[1].Text;
                cbSex.Text = lvStudentList.SelectedItems[0].SubItems[2].Text;
                tbBirthday.Text = lvStudentList.SelectedItems[0].SubItems[3].Text;
                ht = StudentManagerAction.GetDeptList();
                foreach (DictionaryEntry de in ht)
                {
                    cbDept.Items.Add(de.Key.ToString());
                }
                cbDept.Text = lvStudentList.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string deptId = (string)ht[cbDept.Text];
            Student st = new Student(tbStudentNo.Text, tbStudentName.Text, cbSex.Text, tbBirthday.Text, deptId);
            StudentManagerAction sma = new StudentManagerAction();
            sma.setStudent(st);
            if (sma.update())
                MessageBox.Show("修改成功！", "提示信息", MessageBoxButtons.OK);
            else
                MessageBox.Show("修改失败！", "提示信息", MessageBoxButtons.OK);
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
            string studentNo = lvStudentList.SelectedItems[0].Text.ToString();
            Student st = new Student(studentNo, "", "", "", "");
            StudentManagerAction sma = new StudentManagerAction();
            sma.setStudent(st);
            if (sma.delete())
                MessageBox.Show("该学生记录已删除！", "提示信息", MessageBoxButtons.OK);
            else
                MessageBox.Show("删除失败！", "提示信息", MessageBoxButtons.OK);
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}

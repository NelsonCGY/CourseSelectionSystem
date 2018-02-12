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
    public partial class InputTeacherForm : Form
    {
        Hashtable htDept;
        public InputTeacherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNewWorkerNo.Text == "")
            {
                MessageBox.Show("工号不能为空！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TeacherManagerAction  tma = new TeacherManagerAction ();
                Teacher teacher = new Teacher(tbNewWorkerNo.Text, tbNewWorkerName.Text, cbNewSex.Text, (String)htDept[cbNewDepartment.Text]);
                tma.setTeacher(teacher);
                if (tma.TeacherInsert())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems[0].Text = tbNewWorkerNo.Text;
                    lvi.SubItems.Add(tbNewWorkerName.Text);
                    lvi.SubItems.Add(cbNewSex.Text);
                    lvi.SubItems.Add(cbNewDepartment.Text);
                    lvNewTeacher.Items.Add(lvi);
                    MessageBox.Show("添加成功！", "提示信息", MessageBoxButtons.OK);
                }

            }
            tbNewWorkerNo.Clear();
            tbNewWorkerName.Clear();
            cbNewSex.Text = "";
            cbNewDepartment.Text = "";
        }
        
        private void InputTeacherForm_Load(object sender, EventArgs e)
        {
            htDept = TeacherManagerAction.GetDeptList();
            cbNewDepartment.Items.Clear();
            foreach (DictionaryEntry entry in htDept)
            {
                cbNewDepartment.Items.Add(entry.Key);
            }
        }
    }
}

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
    public partial class InputStudentForm : Form
    {
        Hashtable htDept;
        public InputStudentForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbStudentNo.Text == "")
            {
                MessageBox.Show("学号不能为空！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StudentManagerAction sma = new StudentManagerAction();
                Student student = new Student(tbStudentNo.Text, tbStudentName.Text, cbSex.Text, tbBirthday.Text, (String)htDept[cbDept.Text]);
                sma.setStudent(student);
                if (sma.save())
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems.Clear();
                    li.SubItems[0].Text = tbStudentNo.Text;
                    li.SubItems.Add(tbStudentName.Text);
                    li.SubItems.Add(cbSex.Text);
                    li.SubItems.Add(tbBirthday.Text);
                    li.SubItems.Add(cbDept.Text);
                    lvStudentList.Items.Add(li);
                    MessageBox.Show("添加成功！", "提示信息", MessageBoxButtons.OK);
                }
                tbStudentNo.Clear();
                tbStudentName.Clear();
                tbBirthday.Clear();
                cbSex.Text = "";
                cbDept.Text = "";
            }
        }

        private void InputStudentForm_Load(object sender, EventArgs e)
        {
            htDept = StudentManagerAction.GetDeptList();
            cbDept.Items.Clear();
            foreach (DictionaryEntry entry in htDept)
            {
                cbDept.Items.Add(entry.Key);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.StudentManager
{
    public partial class InputStudentForm : Form
    {
        public InputStudentForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentManagerAction sma = new StudentManagerAction();
            Student student = new Student(tbStudentNo.Text, tbStudentName.Text,
                                                             cbSex.Text, tbBirthday.Text, cbDept.Text);
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
            }

        }
    }
}
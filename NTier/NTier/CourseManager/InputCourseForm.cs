using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.CourseManager
{
    public partial class InputCourseForm : Form
    {
        public InputCourseForm()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            if (tbcno.Text == "")
            {
                MessageBox.Show("课号不能为空！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CourseManagerAction cma = new CourseManagerAction();
                Course course = new Course(tbcno .Text ,tbcna .Text );
                cma.setCourse(course);
                if (cma.CourseInsert())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems[0].Text = tbcno.Text;
                    lvi.SubItems.Add(tbcna.Text);
                    lv.Items.Add(lvi);
                    MessageBox.Show("添加成功！", "提示信息", MessageBoxButtons.OK);
                }

            }
            tbcno.Clear();
            tbcna.Clear();
        }
    }
}

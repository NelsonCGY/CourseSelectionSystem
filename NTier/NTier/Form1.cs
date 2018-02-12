using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using NTier.StudentManager;
using NTier.TeacherManager;
using NTier.CourseManager;
using NTier.UserManager;
using NTier.ScoreManager;

namespace NTier
{
    public partial class Form1 : Form
    {
        private User user = null;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.IsMdiContainer = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("1.wav");
            sp.PlayLooping();
            LoginForm lf = new LoginForm();
            lf.StartPosition = FormStartPosition.CenterScreen;
            lf.ShowDialog();    
            user = lf.getUser();
            if (user == null)
                this.Close(); 
            else
                setMenuShow();

        }

        private void 查询ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CourseSearchForm csf = new CourseSearchForm();
            csf.MdiParent = this;
            csf.StartPosition = FormStartPosition.CenterScreen;
            csf.Show();
            csf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void 添加新学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStudentForm insf = new InputStudentForm();
            insf.MdiParent = this;
            insf.StartPosition = FormStartPosition.CenterScreen;
            insf.Show();
            insf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentForm ssf = new SearchStudentForm();
            ssf.MdiParent = this;
            ssf.StartPosition = FormStartPosition.CenterScreen;
            ssf.Show();
            ssf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudentForm usf = new UpdateStudentForm();
            usf.MdiParent = this;
            usf.StartPosition = FormStartPosition.CenterScreen;
            usf.Show();
            usf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void 添加新教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTeacherForm itf = new InputTeacherForm();
            itf.MdiParent = this;
            itf.StartPosition = FormStartPosition.CenterScreen;
            itf.Show();
            itf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void 修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateTeacherForm  utf = new UpdateTeacherForm ();
            utf.MdiParent = this;
            utf.StartPosition = FormStartPosition.CenterScreen;
            utf.Show();
            utf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchTeacherForm stf = new SearchTeacherForm();
            stf.MdiParent = this;
            stf.StartPosition = FormStartPosition.CenterScreen;
            stf.Show();
            stf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        

        private void 添加新课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputCourseForm icf = new InputCourseForm();
            icf.MdiParent = this;
            icf.StartPosition = FormStartPosition.CenterScreen;
            icf.Show();
            icf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void 修改ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateCourseForm ucf = new UpdateCourseForm();
            ucf.MdiParent = this;
            ucf.StartPosition = FormStartPosition.CenterScreen;
            ucf.Show();
            ucf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void 已开设课程查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchOpenedCourseForm socf = new SearchOpenedCourseForm();
            socf.MdiParent = this;
            socf.StartPosition = FormStartPosition.CenterScreen;
            socf.Show();
            socf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void setMenuShow()
        {
            for (int i = 0; i < menuStrip1.Items.Count; i++)
                menuStrip1.Items[i].Visible = false;         //将主菜单各项设置为不可见
            if (user.isRole("管理员"))
                角色权限管理ToolStripMenuItem.Visible = true;//角色权限管理只对管理员可见
            if (user.isRole("教务员"))
            {
                学生管理ToolStripMenuItem.Visible = true; // 学生管理对教务员可见
                教师管理ToolStripMenuItem.Visible = true; //教师管理对教务员可见
                课程管理ToolStripMenuItem.Visible = true; //课程管理对教务员可见
                成绩管理ToolStripMenuItem.Visible = true; //成绩管理对教务员可见
            }
            if (user.isRole("学生"))
            {
                课程管理ToolStripMenuItem.Visible = true; //课程管理对学生可见
                添加新课程ToolStripMenuItem.Visible = false;      //课程输入对学生不可见
                修改ToolStripMenuItem1.Visible = false;    //课程修改对学生不可见
                成绩管理ToolStripMenuItem.Visible = true; //成绩管理对学生可见
                添加新成绩ToolStripMenuItem.Visible = false;      //成绩输入对学生不可见
                修改ToolStripMenuItem3.Visible = false;      //成绩修改对学生不可见
            }
        }

        private void 角色管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加新成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改ToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;

namespace NTier.CourseManager
{
    class CourseManagerAction : DbConnection
    {
        private Course course;
        public void setCourse(Course cs)
        { 
            this.course = cs;
        }
        public bool CourseInsert()
        {
            bool saved = true;
            string sql = "insert into tblCourse(courseNo,courseName) ";
            sql += "values('" + course.courseNo + "','" + course.courseName  +  "')";
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                string s = ex.Message;
                MessageBox.Show(s);
                saved = false;
            }
            finally
            {
                conn.Close();
            }
            return saved;
        }
        public bool CourseUpdate()
        {
            bool saved = true;
            string sql = "update tblCourse set courseNo='" + course.courseNo + "',courseName='" + course .courseName  +  "'";
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                string s = ex.Message;
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saved = false;
            }
            finally
            { conn.Close(); }
            return saved;
        }
        public bool CourseDelete()
        {
            string sql = "delete from tblCourse where courseNo='" + course.courseNo  + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            bool flag = false;
            try
            {
                cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.Message, "数据库更新操作提示"); }
            finally
            { conn.Close(); }
            return flag;
        }
        public static void loadAllCourse(ListView lv, string no, string name)
        {
            string sql = "select courseNo, courseName ";
            sql += " from tblCourse  ";
            sql += " where 1=1 ";
            if (name != "")
            {
                sql += " and courseName like '%" + name + "%'";
            }
            if (no != "")
            {
                sql += " and courseNo like '%" + no + "%'";
            }
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems.Clear();
                    li.SubItems[0].Text = dbReader["courseNo"].ToString();
                    li.SubItems.Add(dbReader["courseName"].ToString());
                    lv.Items.Add(li);
                }
            }
            catch (OleDbException ex)
            {
                string s = ex.Message;
                MessageBox.Show(s);
            }
            finally
            {
                conn.Close();
            }
        }
        public void loadOpenedCourse(ListView lv)
        {
            string sql = "select tc.amount,c.courseName,c.courseNo,t.workerName ";
            sql += "from tblTeacherCourse tc,tblCourse c,tblTeacher t ";
            sql += "where tc.courseNo=c.courseNo and tc.workerNo=t.workerNo ";
            sql += "and tc.courseNo= '" + course.courseNo  + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            lv.Items.Clear();
            conn.Open();
            OleDbDataReader dbReader = cmd.ExecuteReader();
            while (dbReader.Read())
            {
                ListViewItem li = new ListViewItem();
                li.SubItems.Clear();
                li.SubItems[0].Text = dbReader["courseNo"].ToString();
                li.SubItems.Add(dbReader["courseName"].ToString());
                li.SubItems.Add(dbReader["workerName"].ToString());
                li.SubItems.Add(dbReader["amount"].ToString());
                lv.Items.Add(li);
            }
            conn.Close();
        }
        public void loadOpenedCourseDetail(ListView lv)
        {
            string sql = "select tc.amount,teacherCourseNo,c.courseName,t.workerName ";
            sql += "from tblTeacherCourse tc,tblCourse c,tblTeacher t ";
            sql += "where tc.courseNo=c.courseNo and tc.workerNo=t.workerNo ";
            sql += "and tc.courseNo= '" + course.courseNo + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            lv.Items.Clear();
            conn.Open();
            OleDbDataReader dbReader = cmd.ExecuteReader();
            while (dbReader.Read())
            {
                ListViewItem li = new ListViewItem();
                li.SubItems.Clear();
                li.SubItems[0].Text = dbReader["teacherCourseNo"].ToString();
                li.SubItems.Add(dbReader["courseName"].ToString());
                li.SubItems.Add(dbReader["workerName"].ToString());
                li.SubItems.Add(dbReader["amount"].ToString());
                lv.Items.Add(li);
            }
            conn.Close();
        }
        public void openCourse(string cNo,string wNo,string tcNo,string n)
        {
            bool flag = true;
            string sql = "insert into tblteacherCourse(courseNo,workerNo,teacherCourseNo,amount) ";
            sql += "values('" + cNo + "','" + wNo + "','" + tcNo + "','" + n + "')";
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                string s = ex.Message;
                MessageBox.Show(s);
                flag = false;
            }
            finally
            {
                conn.Close();
            }
            if (flag == true)
                MessageBox.Show("开课成功！", "提示信息", MessageBoxButtons.OK);           
        }
        public static void loadAllOpenedCourse(ListView lv,string no, string name,string course)
        {
            string sql = "select tc.amount,teacherCourseNo,c.courseNo,c.courseName,t.workerName ";
            sql += "from tblTeacherCourse tc,tblCourse c,tblTeacher t ";
            sql += "where tc.courseNo=c.courseNo and tc.workerNo=t.workerNo ";
            if (name != "")
            {
                sql += " and workerName like '%" + name + "%'";
            }
            if (no != "")
            {
                sql += " and c.courseNo like '%" + no + "%'";
            }
            if (course != "")
            {
                sql += " and courseName like '%" + course + "%'";
            }
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems.Clear();
                    li.SubItems[0].Text = dbReader["teacherCourseNo"].ToString();
                    li.SubItems.Add(dbReader["courseName"].ToString());
                    li.SubItems.Add(dbReader["workerName"].ToString());
                    li.SubItems.Add(dbReader["amount"].ToString());
                    lv.Items.Add(li);
                }
            }
            catch (OleDbException ex)
            {
                string s = ex.Message;
                MessageBox.Show(s);
            }
            finally
            {
                conn.Close();
            }
        }
        public void OpenedCourseUpdate(string no, string course, string name, string n)
        {
            bool flag = true;
            string sql = "update tblTeacherCourse set amount='" + n + "',teacherCourseNo='" + no + "'";
            sql += "where workerNo in(select t.workerNo from tblTeacherCourse tc,tblTeacher t ";
            sql += "where tc.workerNo=t.workerNo and t.workerName='" + name + "' )";
            sql += "and courseNo in(select c.courseNo from tblCourse c,tblTeacherCourse tc ";
            sql += "where tc.courseNo=c.courseNo and c.courseName='" + course + "' )";
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功！", "提示信息", MessageBoxButtons.OK);
            }
            catch (OleDbException ex)
            {
                string s = ex.Message;
                MessageBox.Show(s, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("无此课程，创建新课？", "提示信息", MessageBoxButtons.OK);
                flag = false;
            }
            finally
            { conn.Close(); }
            if (flag == false)
            {
                InputCourseForm icf = new InputCourseForm();
                icf.StartPosition = FormStartPosition.CenterScreen;
                icf.Show();
            }
        }
        public bool OpenedCourseDelete(string no)
        {
            string sql = "delete from tblTracherCourse where TeacherCourseNo='" + no + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            bool flag = false;
            try
            {
                cmd.ExecuteNonQuery();              
                flag = true;
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.Message, "数据库更新操作提示"); }
            finally
            { conn.Close(); }
            return flag;
        }
        public void loadOpenedCourseStudent(ListView lv,string no)
        {
            string sql = "select s.studentNo, studentName, sex, d.deptName ";
            sql += "from tblTeacherCourse tc,tblSelectCourse sc,tblStudent s,tblDepartment d ";
            sql += "where tc.teacherCourseNo=sc.teacherCourseNo and sc.studentNo=s.studentNo and s.deptId=d.deptId ";
            sql += "and tc.teacherCourseNo= '" + no + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            lv.Items.Clear();
            conn.Open();
            OleDbDataReader dbReader = cmd.ExecuteReader();
            while (dbReader.Read())
            {
                ListViewItem li = new ListViewItem();
                li.SubItems.Clear();
                li.SubItems[0].Text = dbReader["studentNo"].ToString();
                li.SubItems.Add(dbReader["studentName"].ToString());
                li.SubItems.Add(dbReader["sex"].ToString());
                li.SubItems.Add(dbReader["deptName"].ToString());               
                lv.Items.Add(li);
            }
            conn.Close();
        }
    }
}

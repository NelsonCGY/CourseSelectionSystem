using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace NTier.TeacherManager
{
    class TeacherManagerAction : DbConnection
    {

        private Teacher teacher;
        public void setTeacher(Teacher tr)
        {
            this.teacher = tr;
        }

        public bool TeacherInsert()
        {
            bool saved = true;
            string sql = "insert into tblTeacher(workerNo,workerName,sex,deptId) ";
            sql += "values('" + teacher.workerNo + "','" + teacher.workerName + "','" + teacher.sex + "','" + teacher.deptId + "')";
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

        public bool TeacherUpdate()
        {
            bool saved = true;
            string sql = "update tblTeacher set workerName='" + teacher.workerName + "',sex='" + teacher.sex + "',deptId='" + teacher.deptId + "' where workerNo='" + teacher.workerNo + "'";
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

        public static bool TeacherDelete(string no)
        {
            string sql = "delete from tblTeacher where workerNo='" + no + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            bool flag = false;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("数据删除操作成功！");
                flag = true;
            }
            catch (OleDbException ex)
            { MessageBox.Show(ex.Message, "数据库更新操作提示"); }
            finally
            { conn.Close(); }
            return flag;
        }

        public static void queryTeacher(ListView lv, string no, string name)
        {
            string sql = "select workerNo,workerName,sex,deptName from tblTeacher join tblDepartment on tblTeacher.deptId=tblDepartment.deptId";
            if (!no.Equals(""))
                sql += " and workerNo like '%" + no + "%'";
            if (!name.Equals(""))
                sql += " and workerName like '%" + name + "%'";
            lv.Items.Clear();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            OleDbDataReader dbReader = cmd.ExecuteReader();
            while (dbReader.Read())
            {
                ListViewItem li = new ListViewItem();
                li.SubItems[0].Text = dbReader[0].ToString();
                for (int i = 1; i < dbReader.FieldCount; i++)
                    li.SubItems.Add(dbReader[i].ToString());
                lv.Items.Add(li);
            }
            conn.Close();

        }
        public void queryOpenedCourse(ListView lv)
        {

            string sql = "select tc.teacherCourseNo,courseName,count (sc.studentNo)as 选课人数 from tblTeacherCourse tc left join tblSelectCourse sc on tc.teacherCourseNo=sc.teacherCourseNo join tblCourse c on tc.courseNo=c.courseNo join tblTeacher t on tc.workerNo=t.workerNo where t.workerNo='" + teacher.workerNo + "' group by tc.teacherCourseNo,courseName";
            lv.Items.Clear();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            OleDbDataReader dbReader = cmd.ExecuteReader();
            while (dbReader.Read())
            {
                ListViewItem li = new ListViewItem();
                li.SubItems[0].Text = dbReader[0].ToString();
                for (int i = 1; i < dbReader.FieldCount; i++)
                    li.SubItems.Add(dbReader[i].ToString());
                lv.Items.Add(li);
            }
            conn.Close();
        }
        public static Hashtable GetDeptList()
        {
            string sql = "select deptId,deptName from tblDepartment order by deptId";
            Hashtable ht = new Hashtable();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string key = reader[1].ToString();
                    string value = reader[0].ToString();
                    ht.Add(key, value);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
            }
            finally
            {
                conn.Close();
            }
            return ht;
        }
    }
}

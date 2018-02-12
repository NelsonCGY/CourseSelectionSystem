using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace NTier.StudentManager
{
    class StudentManagerAction : DbConnection 
    {
        private Student student;
        public void setStudent(Student st) 
        {
            this.student = st;
        }
        public bool save()      
        {
            bool saved = true;    
            string sql;
            sql = "insert into tblStudent(studentNo, studentName, birthday, sex, deptId) values('" + student.no;
            sql += "','" + student.name + "','" + student.birthday + "','" + student.sex;
            sql += "','" + student.deptId + "')";
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
        public static void loadAllStudent(ListView lv, string no, string name)
        {
            string sql = "select studentNo, studentName, sex, birthday, deptName ";
            sql += " from tblStudent inner join tblDepartment on tblStudent.deptId = tblDepartment.deptId ";
            sql += " where 1=1 "; 
            if (name != "")
            {
                sql += " and studentName like '%" + name + "%'"; 
            }
            if (no != "")      
            {
                sql += " and studentNo like '%" + no + "%'";  
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
                    li.SubItems[0].Text = dbReader["studentNo"].ToString();
                    li.SubItems.Add(dbReader["studentName"].ToString());
                    li.SubItems.Add(dbReader["sex"].ToString());
                    li.SubItems.Add(dbReader["birthday"].ToString());
                    li.SubItems.Add(dbReader["deptName"].ToString());
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
        public void loadSelectedCourse(ListView lv)
        {
            string sql = "select sc.teacherCourseNo,courseName,grade,workerName ";
            sql += "from tblSelectCourse sc,tblTeacherCourse tc,tblCourse c,tblTeacher t ";
            sql += "where sc.teacherCourseNo=tc.teacherCourseNo and  	   	  tc.workerNo=t.workerNo ";
            sql += "and tc.courseNo=c.courseNo and studentNo= '" + student.no + "'";
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
                li.SubItems.Add(dbReader["grade"].ToString());
                lv.Items.Add(li);
            }
            conn.Close();
        }
        public void loadUnselectedCourse(ListView lv)
        {
            string sql = "select teacherCourseNo,courseName,workerName ";
            sql += "from tblTeacherCourse tc,tblCourse c,tblTeacher t ";
            sql += "where tc.workerNo=t.workerNo ";
            sql += "and tc.courseNo=c.courseNo and teacherCourseNo not in";
            sql += " (select teacherCourseNo from tblselectCourse sc where 	    sc.studentNo= '" + student.no + "')";
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
                lv.Items.Add(li);
            }
            conn.Close();
        }
        public bool update()
        {
            bool saved = true; ;
            string sql;
            sql = "update tblStudent set studentName= '" + student.name;
            sql += "',sex='" + student.sex + "', birthday='" + student.birthday;
            sql += "',deptId='" + student.deptId + "' where studentNo='" + student.no + "'";
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
        public bool delete()      
        {
            bool deleted = true;    
            string sql;
            sql = "delete from tblStudent where studentNo like '" + student.no+"'";
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
                deleted = false;           
            }
            finally
            {
                conn.Close();    
            }
            return deleted;
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
                MessageBox.Show(ex.Message, "¥ÌŒÛÃ· æ");
            }
            finally
            {
                conn.Close();
            }
            return ht;
        }
    }
}

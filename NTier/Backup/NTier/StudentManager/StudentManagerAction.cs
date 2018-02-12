using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

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
            sql = "insert into tblStudent(studentNo, studentName, birthday, sex, 	       	    deptId)   values('" + student.no;
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
    }
}

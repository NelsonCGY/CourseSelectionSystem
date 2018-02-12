using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace NTier.UserManager
{
    class UserManagerAction : DbConnection
    {
        public static User validUser(string account, string password)
        // 传递用户的登录帐号和密码，在登录窗体中输入得到
        {
            string sql = "select * from tblAccount where accountId='" + account
                           + "' and  password='" + password + "'";  // 到表tblAccount中查询
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader dbReader = cmd.ExecuteReader();
                if (!dbReader.HasRows)  // 如果查询结果集合为空，则不存在该用户
                {
                    return null;   // 无登录的帐户和密码记录，登录失败，返回空用户
                }
            }
            catch (OleDbException ex)
            {
                string s = ex.Message;
                MessageBox.Show(s);
            }
            finally
            { conn.Close(); }
            User user = new User(account);  // 认证成功，生成用户
            sql = "select roleName ";
            sql += " from tblAccount a, tblAccountRole ar, tblRole r ";
            sql += "where a.accountId=ar.accountId and ar.roleId=r.roleId ";
            sql += " and a.accountId='" + account + "'";
            cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader dbReader = cmd.ExecuteReader();
                ArrayList al = new ArrayList();
                while (dbReader.Read())
                {
                    string roleName = dbReader["roleName"].ToString();
                    al.Add(roleName);// 每得到一个角色，就将其增加到列表中
                }
                user.assignRole(al);  // 把角色给用户
            }
            catch (OleDbException ex)
            {
                string s = ex.Message;
                MessageBox.Show(s);
            }
            finally
            { conn.Close(); }
            // 获得用户的权限列表
            sql = "select rightName ";
            sql += "from tblAccount a, tblAccountRole ar, tblRoleRight rr, tblRights  r ";
            sql += "where a.accountId=ar.accountId and ar.roleId=rr.roleId ";
            sql += "and rr.rightId = r.rightId and a.accountId='" + account + "'";
            cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader dbReader = cmd.ExecuteReader();
                ArrayList al = new ArrayList();
                while (dbReader.Read())
                {
                    string rightName = dbReader["rightName"].ToString();
                    al.Add(rightName);//每得到一个权限就将其增加到顺序表中
                }
                user.assignRight(al);  // 把权限给用户
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
            return user;
        }
      }
}

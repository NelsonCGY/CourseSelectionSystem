using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data.OleDb;
using System.Windows.Forms;

namespace NTier.UserManager
{
    public class User 
    {
        private string account;
        private ArrayList roleList = null;                        // 用户角色列表
        private ArrayList rightList = null;                      // 用户权限列表
        public User(string account)                                // 构造方法
        {
            this.account = account;
        }
        public string getAccount()
        { return account; }
        public bool hasRight(string rightName)  // 判断用户是否有指定的权限
        {
            return rightList == null ? false : rightList.Contains(rightName);
        }
        public bool isRole(string roleName)  // 判断用户是否是指定的角色
        {
            return roleList == null ? false : roleList.Contains(roleName);
        }
        public void assignRight(ArrayList rights)  // 给用户赋予权限列表
        {
            this.rightList = rights;
        }
        public void assignRole(ArrayList roles)  // 给用户赋予角色列表
        {
            this.roleList = roles;
        }
    }
}

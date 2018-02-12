using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTier.UserManager
{
    public partial class LoginForm : Form
    {
        private User user = null;
        public LoginForm()
        {
            InitializeComponent();
        }
        public User getUser()
        { 
            return this.user;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userAccount = tbUserName.Text;  //窗体中输入的用户帐号
            string password = tbUserId.Text;　//窗体中输入的用户密码
            user = UserManagerAction.validUser(userAccount, password); //                       								获取user
            if (user != null)
            { 
                this.Close(); 
            }         // 用户登录成功，自动关闭登录窗体，
            else
            {
                MessageBox.Show("登录失败，请检查用户名和密码", "Error",MessageBoxButtons.OK ); 
            }
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {  
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

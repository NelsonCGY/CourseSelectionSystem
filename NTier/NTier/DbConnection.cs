using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Xml;
using System.Windows.Forms;
using System.IO ;
using System.Collections;
namespace NTier
{
    public class DbConnection
    {
        protected static OleDbConnection conn = new OleDbConnection();
        static DbConnection ()
        {
            string s = Application.ExecutablePath;
            int dotPos = s.IndexOf("."); 
            s = s.Substring(0, dotPos);
            s += ".xml";                             
            XmlDocument doc = new XmlDocument();
            doc.Load(s);                    
            XmlNode root = doc.DocumentElement;
            XmlNode setttingNode = root.SelectSingleNode("setting");
            string server = setttingNode.SelectSingleNode("server").InnerText;
            string db = setttingNode.SelectSingleNode("db").InnerText;
            string conStr = "Provider=SQLNCLI11;Data Source=" + server + ";Integrated Security=SSPI;Initial Catalog=" + db;
            conn.ConnectionString = conStr;
        }
            /*protected static OleDbConnection conn = new OleDbConnection();
            static DbConnection()
            {
                string path = Application.StartupPath;
                try
                {
                    StreamReader sr = new StreamReader(path + "\\config.txt");
                    string[] str = sr.ReadLine().Split(' ');
                    string serverName = str[0];
                    string database = str[1];
                    conn.ConnectionString = "Provider=SQLNCLI11;Data Source=" + serverName + "; Initial Catalog=" + database + "; Integrated Security =SSPI";
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "读数据库连接配置文件");
                }
            }*/
        //Provider=SQLNCLI11;Data Source=NELSONC-PC;Integrated Security=SSPI;Initial Catalog=Ntier
    }
}

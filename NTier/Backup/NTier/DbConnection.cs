using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Xml;
using System.Windows.Forms;
namespace NTier
{
    class DbConnection
    {
        protected static OleDbConnection conn= new OleDbConnection();
        static DbConnection()
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
            string conStr = "Provider=SQLNCLI.1;";
            conStr += "Integrated Security=SSPI;";
            conStr += "Initial Catalog=" + db + ";Data Source=" + server;
            conn.ConnectionString = conStr;
        }
    }
}

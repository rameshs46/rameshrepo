using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace ParsingExcel
{
    public partial class Default : System.Web.UI.Page
    {
        OleDbConnection SqlECon;
        SqlConnection Con;

        string SqlStrCon,SqlQuery,SqlConn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void ExcelCon(string FilePath)
        {
            SqlStrCon = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=Yes;""", FilePath);
            SqlECon = new OleDbConnection(SqlStrCon);
        }

        private void Connection()
        {
            SqlConn = ConfigurationManager.ConnectionStrings["SqlCom"].ConnectionString;
            Con = new SqlConnection(SqlConn);
        }

        private void InsertExcelRecords(string FilePath)
        {
            ExcelCon(FilePath);

            SqlQuery = string.Format("Select Name,City,Address,Designation From [{0}]", "Sheet1$");
            OleDbCommand SqlCmd = new OleDbCommand(SqlQuery, SqlECon);
            SqlECon.Open();

            DataSet ds = new DataSet();
        }
        protected void Parse_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WDSync
{
    class SQL
    {

        public string server = "USCHWMTS1002";
        public string instance = "MTSSQL";
        public string database = "WDSync";
        public string security = "Integrated Security=SSPI";

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
 
        public SQL()
        {
            this.con.ConnectionString = "Server=" + this.server + "\\" + this.instance + 
                                        ";Database=" + this.database + "; " + this.security;        
        }

        public SQL(string Database)
        {
            this.con.ConnectionString = "Server=" + this.server + "\\" + this.instance +
                                        ";Database=" + Database + "; " + this.security;
        }

        public SQL(string UserName, string Password)
        {
            this.con.ConnectionString = "Server=" + this.server + "\\" + this.instance +
                                        ";Database=" + this.database + "; " + 
                                        "User Id=" + UserName + ";Password=" + Password;
        }

        public SQL(string Server, string Instance, string Database)
        {
            this.con.ConnectionString = "Server=" + Server + "\\" + Instance + 
                                        ";Database=" + Database + "; " + this.security;

        }        
        
        public SQL(string Server, string Instance, string Database, string Security)
        {
            this.con.ConnectionString = "Server=" + Server + "\\" + Instance
                                      + ";Database=" + Database + "; " + Security;
        }

        // execute any query
        public bool Execute(string query)
        {
            // construct the command
            this.cmd.CommandText = query;
            this.cmd.Connection = this.con;

            try
            {
                // execute the command
                this.cmd.ExecuteNonQuery();
                
                // return successs
                return true;
            }

            catch
            {
                // return fail
                return false;
            }
        }

        // get sql data
        public DataTable Get(string query)
        {
            // construct the command
            this.cmd.CommandText = query;
            this.cmd.Connection = this.con;

            // ready the data
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();

            // fill the data
            adap.Fill(data);
            adap.Dispose();

            // return the data
            return data.Tables[0];
        }

        // add row
        public bool Add(WD wduser)
        {
            //string database = "WDUsers";
            return false;
        }

        public bool Add(AD aduser)
        {
            //string database = "ADUsers";
            return true;
        }
    }
}

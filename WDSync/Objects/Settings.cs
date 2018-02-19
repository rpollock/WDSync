using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WDSync
{
    class Settings
    {
        public string ftphost { get; set; }
        public string ftpfinger { get; set; }
        public string ftpdll { get; set; }
        public string aduser { get; set; }
        public string adpass { get; set; }
        public string adou { get; set; }
        public string addc { get; set; }

        SQL sqlobj = new SQL();


        public Settings()
        {
            DataTable dt = sqlobj.Get("select * from Settings");


            this.ftphost = dt.Rows[0]["ftphost"].ToString();
            this.ftpfinger = dt.Rows[0]["ftpfinger"].ToString();
            this.ftpdll = dt.Rows[0]["ftpdll"].ToString();
            this.aduser = dt.Rows[0]["aduser"].ToString();
            this.adpass = dt.Rows[0]["adpass"].ToString();
            this.adou = dt.Rows[0]["adou"].ToString();
            this.addc = dt.Rows[0]["addc"].ToString();
        }

        public bool Save()
        {




            return true;
        }

        public bool Validate()
        {
            return true;
        }

        public Settings Get()
        {

            return new Settings();
        }
    }
}

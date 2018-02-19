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
        public string sqldatabase{ get; set; }
        public string sqlinstance{ get; set; }


        SQL sqlobj = new SQL();
        FTP ftpobj = new FTP();





        public bool Save()
        {




            return true;
        }

        // we need a sql server to read settings from
        public bool Validate()
        {




            return true;
        }
    }
}

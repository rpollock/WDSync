using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDSync
{
    class WDSync
    {
        static void Main(string[] args)
        {

            // connect to sql
            SQL sql = new SQL();
            Log log = new Log();


            FTP ftp = new FTP();


            Settings settings = new Settings();
            Report report = new Report();

        }
    }
}

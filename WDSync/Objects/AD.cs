using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.DirectoryServices;

namespace WDSync
{
    class AD
    {
        public string employeeID{ get; set; }
        public string employeeNumber{ get; set; }
        public string legalName{ get; set; }
        public string company{ get; set; }
        public string department{ get; set; }
        public string title{ get; set; }
        public string manager{ get; set; }
        public string physicalDeliveryOfficeName{ get; set; }
        public string st{ get; set; }
        public string c{ get; set; }
        public string l{ get; set; }
        public string streetAddress{ get; set; }
        public string postalCode{ get; set; }
        public string co{ get; set; }
        public string countryCode{ get; set; }
        public string sAMAccountName{ get; set; }
        public string description{ get; set; }
        public string distinguishedname{ get; set; }

        public AD()
        {




        }

        public string FindOne(string search)
        {
            DirectoryEntry direntry = new DirectoryEntry();

            return search;
        }

        public string FindAll(string search)
        {
            return search;
        }
    }
}

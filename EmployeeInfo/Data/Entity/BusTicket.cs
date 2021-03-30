using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.Data.Entity
{
    public class BusTicket : Base
    {
        public string pname { get; set; }
        public string paddress { get; set; }
        public string form { get; set; }
        public string to { get; set; }
        public string sitno { get; set; }
        public string amount { get; set; }
        public string comment { get; set; }
    }
}

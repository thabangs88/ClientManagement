using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Model.Request
{
    public class User
    {
        public string Username { get; set; }
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public int CompanyID { get; set; }
        public int AppID { get; set; }
        public bool Active { get; set; }

    }
}

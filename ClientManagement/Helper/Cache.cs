using ClientManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Helper
{
    public  class ContactCache
    {
        public static string Type { get; set; }
        public static string Number { get; set; }
    }
    public class AddressCache
    {
        public static string Address { get; set; }
        public static string Suburb { get; set; }
        public static string Province { get; set; }
        public static string Code { get; set; }
    }

    public class UserStatus
    {
        public static string Token { get; set; }
        public static bool isUSerOnline { get; set; }
    }

    public class SearchForClients
    {
        public static string SearchWord { get; set; }
        public static bool isSearch { get; set; }
    }
}



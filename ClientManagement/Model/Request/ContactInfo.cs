using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Model.Request
{
    public class ContactInfo
    {
        public int? ID { get; set; }
        public int ClientId { get; set; }
        public string Type { get; set; }
        public string ContactNo { get; set; }
    }
}

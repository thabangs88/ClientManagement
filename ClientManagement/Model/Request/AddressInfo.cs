using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Model.Request
{
    public class AddressInfo
    {
        public int? ID { get; set; }
        public int? ClientId { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string Province { get; set; }
        public string Code { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighborstash.Core.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetName { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string BlockNumber  { get; set; }
    }
}

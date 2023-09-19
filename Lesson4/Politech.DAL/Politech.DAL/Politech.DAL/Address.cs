using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politech.DAL
{
    public  class Address
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string StreetName { get; set; }
        public string House { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
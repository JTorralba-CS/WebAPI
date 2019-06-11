using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Contact
    {
        public Int64 ID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Phone { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Phone { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address.Book
{
    class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Contact(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}


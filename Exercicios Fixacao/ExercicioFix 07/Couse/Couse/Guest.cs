using System;
using System.Collections.Generic;
using System.Text;

namespace Couse
{
    class Guest
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Guest(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}

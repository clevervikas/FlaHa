using System;
using System.Collections.Generic;
using System.Text;

namespace FlaHa.Domain
{
    public class Customer : BaseEntity
    {
        public String Name { get; set; }
        public String Address { get; set; }
    }
}

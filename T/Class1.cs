using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test02;

namespace T
{
    public class Class1 : Inter
    {
        public string from { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Class1()
        {
            FirstName = "what";
            LastName = "when";
            from = "where";
        }
    }
}

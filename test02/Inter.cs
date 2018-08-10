using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
    public interface Inter
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    public class common : Inter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public common()
        {
            FirstName = "test";
            LastName = "test2";
        }
    }
}

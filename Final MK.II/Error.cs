using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_MK.II
{
    public class Error:Exception
    {
        public Error(string message) : base(message) { }
    }
}

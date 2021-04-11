using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DL : IActions
    {
        private string Str = string.Empty;

        public string Perform(string str)
        {
            Str = str;
            return Str;
        }
    }
}

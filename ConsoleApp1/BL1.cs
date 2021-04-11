using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BL1
    {

        private IActions _action;
        public BL1(IActions action)
        {
            _action = action;

        }

        public string DoItAgain()
        {
           return _action.Perform("From BL1");
        }
    }
}

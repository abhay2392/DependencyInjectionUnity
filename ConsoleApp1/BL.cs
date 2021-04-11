using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BL
    {
        private IActions _actions;
        public BL(IActions action)
        {
            _actions = action;

            
        }

        public void ActionIt()
        {
            _actions.Perform("From BL");
        }

    }
}

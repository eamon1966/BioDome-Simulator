using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDomeSimulator
{
    class ControlUnit
    {
        private String name = "";
        private String state = "Null";

        public ControlUnit(String name)
        {
            this.name = name;
            this.state = state;
        }

        public String GetName()
        {
            return name;
        }

        public String GetState()
        {
            return state;
        }

        public void SetState(String state)
        {
            this.state = state;
        }

        public override string ToString()
        {
            return String.Format("   {0}: Current State -> [{1}]\n", name, state);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDomeSimulator
{
    class ClimateVariables
    {
        private string name = "";
        private string state = "Null";

        public ClimateVariables(String name)
        {
            this.name = name;
            this.state = state;
        }

        public string GetName()
        {
             return name;
        }

        public string GetState()
        {
             return state;
        }

        public void SetState(string state)
        {
            this.state = state;
        }
        
        public override string ToString()
        {
            return String.Format("   {0}: Current State -> [{1}]\n" , name, state);
        }
    }
}

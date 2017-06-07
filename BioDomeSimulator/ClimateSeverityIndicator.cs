using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDomeSimulator
{
    class ClimateSeverityIndicator
    {
        private string name = "MyCode";
        private string state = "Null";

        public ClimateSeverityIndicator(String name)
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
            return String.Format("   {0}: Control Load Severity -> [{1}]\n", name, state);
        }
    }
}

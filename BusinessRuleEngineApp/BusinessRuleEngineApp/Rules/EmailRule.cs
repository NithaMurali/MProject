using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
    class EmailRule : IRule
    {
        void IRule.ApplyRule(string itemName)
        {
            Console.WriteLine("{0}:  Email sent to owner!", itemName);
        }
    }
}

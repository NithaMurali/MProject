using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
    class NewMembershipRule : IRule
    {
        void IRule.ApplyRule(string itemName)
        {
            Console.WriteLine("{0}: Membership activated!", itemName);
        }
    }
}

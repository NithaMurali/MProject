using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
    public class UpgradeMembershipRule : IRule
    {
        string ruleApplied = "";

        string IRule.ApplyRule(string itemName)
        {
            ruleApplied = string.Format("{0}: Upgrade applied!", itemName);
            Console.WriteLine(ruleApplied);
            return ruleApplied;
        }
    }
}

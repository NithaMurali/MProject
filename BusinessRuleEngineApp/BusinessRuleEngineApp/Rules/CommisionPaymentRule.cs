using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
    public class CommisionPaymentRule : IRule
    {
        string ruleApplied = "";

        string IRule.ApplyRule(string itemName)
        {
            ruleApplied = String.Format("{0}:  Commission payment to agent generated!", itemName);
            Console.WriteLine(ruleApplied);
            return ruleApplied;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
    public class PhysicalProductRule : IRule
    {
        string ruleApplied = "";

        string IRule.ApplyRule(string itemName)
        {
            ruleApplied = String.Format("{0}: Packing slip generated for shipping", itemName);
            Console.WriteLine(ruleApplied);
            return ruleApplied;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
   
    public class BookRule: IRule
    {
        string ruleApplied= "created a duplicate packing slip for the royalty department!";

        string IRule.ApplyRule(string itemName)
        {
            ruleApplied = string.Format("{0}:  {1}", itemName, ruleApplied);
            Console.WriteLine(ruleApplied);
            return ruleApplied;

        }
    }
}

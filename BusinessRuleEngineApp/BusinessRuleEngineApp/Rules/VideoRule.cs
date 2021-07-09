using BusinessRuleEngineApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
    public class VideoRule : IRule
    {
        string ruleApplied = "";

        string IRule.ApplyRule(string itemName)
        {
            if (ComplimentaryVideoMap.GetComplimentaryVideoMap().complimentaryVideoMap.TryGetValue(itemName, out string complVideo))
            {
                ruleApplied = string.Format("{0}: Adding {1} to packing slip!", itemName, complVideo);
            }
            else
            {
                ruleApplied = string.Format("{0}: Rule applied!", itemName);
            }
            Console.WriteLine(ruleApplied);
            return ruleApplied;
        }
    }
}

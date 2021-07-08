using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
    public class CommisionPaymentRule : IRule
    {
        void IRule.ApplyRule(string itemName)
        {
            Console.WriteLine("{0}:  Commission payment to agent generated!", itemName);
        }
    }
}

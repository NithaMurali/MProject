using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
    public class PhysicalProductRule : IRule
    {
        void IRule.ApplyRule(string itemName)
        {
            Console.WriteLine("{0}: Packing slip generated for shipping", itemName);
        }
    }
}

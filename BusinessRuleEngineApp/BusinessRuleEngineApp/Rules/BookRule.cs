using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Rules
{
   
    public class BookRule: IRule
    {
        void IRule.ApplyRule(string itemName)
        {
            Console.WriteLine("{0}:  created a duplicate packing slip for the royalty department!", itemName);
        }
    }
}

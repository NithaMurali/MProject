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
        
       void IRule.ApplyRule(string itemName)
        {
            if(ComplimentaryVideoMap.GetComplimentaryVideoMap().complimentaryVideoMap.TryGetValue(itemName, out string complVideo))
            {
                Console.WriteLine("{0}: Adding {1} to packing slip!", itemName, complVideo);

            }
            else
                Console.WriteLine("{0}: Rule applied!",  itemName);
        }
    }
}

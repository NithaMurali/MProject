using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp
{
    public interface IRule
    {
        void ApplyRule(string itemName);
    }
}

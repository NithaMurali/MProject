using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Data.Interfaces
{
    public interface IItem
    {


        void applyRule();
        void AddRule(IRule rule);
    }
}

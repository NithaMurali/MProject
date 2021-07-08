using BusinessRuleEngineApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Data
{
    class PhysicalProduct : IItem
    {
        public PhysicalProduct(string itemName)
        {
            this.Name = itemName;
            Rules = new List<IRule>();
        }
        string Name { get; set; }
        List<IRule> Rules { get; set; }

        void IItem.applyRule()
        {
            foreach(IRule rule in Rules)
            {
                rule.ApplyRule(Name);   
            }
        }

        void IItem.AddRule(IRule rule)
        {
            Rules.Add(rule);
        }
    }
}

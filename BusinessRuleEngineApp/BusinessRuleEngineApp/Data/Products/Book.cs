using BusinessRuleEngineApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Data.Products
{
    public class Book : IItem
    {
        public Book(string Name)
        {
            this.Name = Name;
            Rules = new List<IRule>();

        }
        string Name { get; set; }
        List<IRule> Rules { get; set; }


        void IItem.applyRule()
        {
            foreach (IRule rule in Rules)
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


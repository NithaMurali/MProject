using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRuleEngineApp.Data.Interfaces;
using BusinessRuleEngineApp.Data.Products;
using BusinessRuleEngineApp.Rules;
using BusinessRuleEngineApp.Data;

namespace BusinessRuleEngineApp
{
    public class PaymentEngine
    {
        public List<IItem> inputCartItems;
        /*Arguments: None
        Description: Adds products to the cart*/
        public void InitializeProducts(List<IItem> cartItems)
        {

            inputCartItems = cartItems;
        }

        public void ProcessPayments()
        {
            //After payment processing, apply the payment rule for each item in cart
            foreach (IItem item in inputCartItems)
            {
                item.applyRule();
            }
        }
    }
}

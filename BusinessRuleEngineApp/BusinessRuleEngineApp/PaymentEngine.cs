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
    class PaymentEngine
    {
        public static List<IItem> cartItems;
        /*Arguments: None
        Description: Adds products to the cart*/
        public static void InitializeProducts()
        {
            cartItems = new List<IItem>();
            IItem phyProdItem = new PhysicalProduct("Physical Product");
            phyProdItem.AddRule(new PhysicalProductRule());
            phyProdItem.AddRule(new CommisionPaymentRule());
            cartItems.Add(phyProdItem);

            IItem videoItem = new Video("Learning to Ski");
            videoItem.AddRule(new VideoRule());
            cartItems.Add(videoItem);

            IItem bookItem = new Book("Book");
            bookItem.AddRule(new BookRule());
            bookItem.AddRule(new CommisionPaymentRule());
            cartItems.Add(bookItem);

            IItem newMembershipItem = new NewMembership("New Registration");
            newMembershipItem.AddRule(new NewMembershipRule());
            newMembershipItem.AddRule(new EmailRule());
            cartItems.Add(newMembershipItem);

            IItem upgradeMembershipItem = new UpgradeMembership("Upgrade Membership");
            upgradeMembershipItem.AddRule(new UpgradeMembershipRule());
            upgradeMembershipItem.AddRule(new EmailRule());
            cartItems.Add(upgradeMembershipItem);

        }

        public static void ProcessPayments()
        {
            //After payment processing, apply the payment rule for each item in cart
            foreach (IItem item in cartItems)
            {
                item.applyRule();
            }
        }
    }
}

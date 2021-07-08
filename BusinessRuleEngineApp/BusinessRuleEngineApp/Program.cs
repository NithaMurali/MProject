using BusinessRuleEngineApp.Data;
using BusinessRuleEngineApp.Data.Interfaces;
using BusinessRuleEngineApp.Data.Products;
using BusinessRuleEngineApp.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp
{
    class Program
    {
        static List<IItem> cartItems;
        static void Main(string[] args)
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

            PaymentEngine paymentEngine = new PaymentEngine();
            //add elements to cart
            paymentEngine.InitializeProducts(cartItems);
            //process payments for items in cart
            paymentEngine.ProcessPayments();
            Console.ReadLine();

        }

       
    }
   
}

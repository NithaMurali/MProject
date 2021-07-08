using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRuleEngineApp;
using BusinessRuleEngineApp.Data.Products;
using BusinessRuleEngineApp.Data.Interfaces;
using BusinessRuleEngineApp.Rules;
using System.Collections.Generic;
using BusinessRuleEngineApp.Data;

namespace BusinessRuleEngineTestProject
{
    [TestClass]
    public class PaymentEngineTest
    {
        [TestMethod]
        void Test_ProcessPayments()
        {
            //Arrange
            List<IItem>  cartItems = new List<IItem>();
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
            //Act

            //Assert
           // paymentEngine.InitializeProducts();
        }
    }
}

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
        void Test_InitializeProductsWithEmptyCart()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();
            PaymentEngine paymentEngine = new PaymentEngine();

            //Act
            paymentEngine.InitializeProducts(cartItems);

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void Test_InitializeProductsWithAllProductType()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();
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
            paymentEngine.InitializeProducts(cartItems);

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void Test_InitializeProductsWithProductWithnWithoutRule()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();
            IItem phyProdItem = new PhysicalProduct("Physical Product");
            cartItems.Add(phyProdItem);

            IItem videoItem = new Video("Learning to Ski");
            cartItems.Add(videoItem);

            IItem bookItem = new Book("Book");
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
            paymentEngine.InitializeProducts(cartItems);

            //Assert
            //check if the returned value has the required string
        }


        [TestMethod]
        void Test_ProcessPaymentsWithEmptyCart()
        {



            //Arrange
            PaymentEngine paymentEngine = new PaymentEngine();
            List<IItem> cartItems = new List<IItem>();

            //Act
            paymentEngine.InitializeProducts(cartItems);
            paymentEngine.ProcessPayments();

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void Test_ProcessPaymentsWithAllProductType()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();
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
            paymentEngine.InitializeProducts(cartItems);
            paymentEngine.ProcessPayments();

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void TestProcessPaymentsWithProductWithnWithoutRule()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();
            IItem phyProdItem = new PhysicalProduct("Physical Product");
            cartItems.Add(phyProdItem);

            IItem videoItem = new Video("Learning to Ski");
            cartItems.Add(videoItem);

            IItem bookItem = new Book("Book");
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
            paymentEngine.InitializeProducts(cartItems);
            paymentEngine.ProcessPayments();

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void TestProcessPaymentsForVidoeWithoutComplimentaryVideo()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();

            IItem videoItem = new Video("FIFA Video");
            videoItem.AddRule(new VideoRule());
            cartItems.Add(videoItem);

            PaymentEngine paymentEngine = new PaymentEngine();


            //Act
            paymentEngine.InitializeProducts(cartItems);
            paymentEngine.ProcessPayments();

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void TestProcessPaymentsForVidoeLearningSKI()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();

            IItem videoItem = new Video("Learning to Ski");
            videoItem.AddRule(new VideoRule());
            cartItems.Add(videoItem);

            PaymentEngine paymentEngine = new PaymentEngine();


            //Act
            paymentEngine.InitializeProducts(cartItems);
            paymentEngine.ProcessPayments();

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void TestProcessPaymentsFoPhysicalProduct()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();

            IItem phyProdItem = new PhysicalProduct("Physical Product");
            cartItems.Add(phyProdItem);

            PaymentEngine paymentEngine = new PaymentEngine();


            //Act
            paymentEngine.InitializeProducts(cartItems);
            paymentEngine.ProcessPayments();

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void TestProcessPaymentsFoBook()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();

            IItem bookItem = new Book("Book");
            bookItem.AddRule(new BookRule());
            bookItem.AddRule(new CommisionPaymentRule());
            cartItems.Add(bookItem);

            PaymentEngine paymentEngine = new PaymentEngine();


            //Act
            paymentEngine.InitializeProducts(cartItems);
            paymentEngine.ProcessPayments();

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void Test_ProcessPaymentsForNewMembership()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();


            IItem newMembershipItem = new NewMembership("New Registration");
            newMembershipItem.AddRule(new NewMembershipRule());
            newMembershipItem.AddRule(new EmailRule());
            cartItems.Add(newMembershipItem);



            PaymentEngine paymentEngine = new PaymentEngine();


            //Act
            paymentEngine.InitializeProducts(cartItems);
            paymentEngine.ProcessPayments();

            //Assert
            //check if the returned value has the required string
        }

        [TestMethod]
        void Test_ProcessPaymentsForMembershipUpgrade()
        {
            //Arrange
            List<IItem> cartItems = new List<IItem>();

            IItem upgradeMembershipItem = new UpgradeMembership("Upgrade Membership");
            upgradeMembershipItem.AddRule(new UpgradeMembershipRule());
            upgradeMembershipItem.AddRule(new EmailRule());
            cartItems.Add(upgradeMembershipItem);

            PaymentEngine paymentEngine = new PaymentEngine();


            //Act
            paymentEngine.InitializeProducts(cartItems);
            paymentEngine.ProcessPayments();

            //Assert
            //check if the returned value has the required string
        }
    }





}

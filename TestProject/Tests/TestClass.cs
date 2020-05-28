using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjectLibrary.PageObjects.AutomationPractice.ContactUs;
using PageObjectLibrary.Utils;
using System;
using System.IO;
using System.Reflection;
using TestProject.Hooks;

namespace TestProject.Tests
{
    [TestClass]
    public class TestClass: Hook
    { 
        [TestMethod]
        public void ContactUsFormIsSentWithValidData()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var iconPath = Path.Combine(outPutDirectory, @"resources\TextFile.txt");
            string icon_path = new Uri(iconPath).LocalPath;
            var contactUsPage = navigationSteps.GoToContactUsPage();            
            contactUsPage.FillContactUsForm(ContactUsPage.Options.ByText, "Customer service", "daniel.terceros@test.com",
                "1234", icon_path, "My product did not arrive as expected");

            string actualMessage = contactUsPage.GetConfirmationLabel();
            string expectedMessage = "Your message has been successfully sent to our team.";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void ContactUsFormIsNotSentWithInvalidData()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var iconPath = Path.Combine(outPutDirectory, @"resources\TextFile.txt");
            string icon_path = new Uri(iconPath).LocalPath;
            var contactUsPage = navigationSteps.GoToContactUsPage();
            contactUsPage.FillContactUsForm(ContactUsPage.Options.ByText, "Customer service", "invalid email",
                "1234", icon_path , "My product did not arrive as expected");

            string actualMessage = contactUsPage.GetErrorLabel();
            string expectedMessage = "Invalid email address.";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]

        public void ShopADressUsingValidData()
        {
            var SignInPage = navigationSteps.GoToSignInPage();
            var myAcountPage = SignInPage.FilloutForm("joaquinjqn2@test.com", "Test1234");
            var purchaseSummaryPage = navigationSteps.navigateToPurchaseSummaryPage();
            string expectedResultProductPrice = purchaseSummaryPage.GetPriceFromSummaryPage();
            var orderHistoryPage = navigationSteps.navigateToOrderHistoryPage();
            orderHistoryPage.ShowDetails();

            string ActualResultProductPrice = orderHistoryPage.GetTotalPriceFromOrderHistory();

            Assert.AreEqual(expectedResultProductPrice, ActualResultProductPrice);
        }

        [TestMethod]
        public void createNewAccount()
        {
            GenereateNewEmailAddress g = new GenereateNewEmailAddress();
            var SignInPage = navigationSteps.GoToSignInPage();
            var createNewAccountPage = SignInPage.CreateNewAccount(g.GenerateEmail());
            string expectedResult = "Joaquin Gonzales";
            var MyAccountPage = createNewAccountPage.FillOutNewAccountForm("Joaquin", "Gonzales", "Test123", "26", "7", "1990", "Joaquin", "Gonzales", "AssureSoft", "America Av.", "Cocha", "Louisiana", "00000", "21", "Test Other Information","4471939","73773296","TestAlias");
            string ActualResult = MyAccountPage.ReturnAccountName();

            Assert.AreEqual(expectedResult, ActualResult);
        }
    }
}

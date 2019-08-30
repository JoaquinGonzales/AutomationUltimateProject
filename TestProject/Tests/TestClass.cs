using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjectLibrary.PageObjects.AutomationPractice.ContactUs;
using PageObjectLibrary.Utils;
using TestProject.Hooks;

namespace TestProject.Tests
{
    [TestClass]
    public class TestClass: Hook
    { 
        [TestMethod]
        public void ContactUsFormIsSentWithValidData()
        {
            var contactUsPage = navigationSteps.GoToContactUsPage();            
            contactUsPage.FillContactUsForm(ContactUsPage.Options.ByText, "Customer service", "daniel.terceros@test.com",
                "1234", @"C:\Users\joaquin.gonzales\Desktop\test.txt", "My product did not arrive as expected");

            string actualMessage = contactUsPage.GetConfirmationLabel();
            string expectedMessage = "Your message has been successfully sent to our team.";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void ContactUsFormIsNotSentWithInvalidData()
        {
            var contactUsPage = navigationSteps.GoToContactUsPage();
            contactUsPage.FillContactUsForm(ContactUsPage.Options.ByText, "Customer service", "invalid email",
                "1234", @"C:\Users\joaquin.gonzales\Desktop\test.txt", "My product did not arrive as expected");

            string actualMessage = contactUsPage.GetErrorLabel();
            string expectedMessage = "Invalid email address.";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]

        public void ShopADressUsingValidData()
        {
            var SignInPage = navigationSteps.GoToSignInPage();
            var myAcountPage = SignInPage.filloutForm("joaquinjqn2@test.com", "Test1234");
            var purchaseSummaryPage = navigationSteps.navigateToPurchaseSummaryPage();
            string expectedResultProductPrice = purchaseSummaryPage.getPriceFromSummaryPage();
            var orderHistoryPage = navigationSteps.navigateToOrderHistoryPage();
            orderHistoryPage.showDetails();

            string ActualResultProductPrice = orderHistoryPage.getTotalPriceFromOrderHistory();

            Assert.AreEqual(expectedResultProductPrice, ActualResultProductPrice);
        }

        [TestMethod]
        public void createNewAccount()
        {
            GenereateNewEmailAddress g = new GenereateNewEmailAddress();
            var SignInPage = navigationSteps.GoToSignInPage();
            var createNewAccountPage = SignInPage.createNewAccount(g.generateEmail());
            string expectedResult = "Joaquin Gonzales";
            var MyAccountPage = createNewAccountPage.fillOutNewAccountForm("Joaquin", "Gonzales", "Test123", "26", "7", "1990", "Joaquin", "Gonzales", "AssureSoft", "America Av.", "Cocha", "Louisiana", "00000", "21", "Test Other Information","4471939","73773296","TestAlias");
            string ActualResult = MyAccountPage.returnAccountName();

            Assert.AreEqual(expectedResult, ActualResult);
        }
    }
}

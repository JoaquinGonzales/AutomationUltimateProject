using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice;
using PageObjectLibrary.PageObjects.AutomationPractice.ContactUs;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses.Purchase_a_Dress;
using PageObjectLibrary.PageObjects.AutomationPractice.Menu;
using PageObjectLibrary.PageObjects.AutomationPractice.My_Account;
using PageObjectLibrary.PageObjects.AutomationPractice.Orders;

namespace PageObjectLibrary.Steps.AutomationPractice.Navigation
{
    public class NavigationSteps: BaseStep
    {
        HomePage homePage = new HomePage();
        public NavigationSteps()
        {
            NavigateToInitialSite();
        }

        public ContactUsPage GoToContactUsPage()
        {      
            var contactUsPage = homePage.ClickContactUs();            
            return contactUsPage;
        }

        public SignInPage GoToSignInPage()
        {
            return homePage.ClickSignInButton();
        }

        public PurchaseSummaryPage navigateToPurchaseSummaryPage()
        {
            var myAccountPage = new MyAccountPage();
            var casualDressesPage = myAccountPage.NavigateToMyDresses();
            return casualDressesPage.SelectFisrtProduct();
        }

        public OrderHistoryPage navigateToOrderHistoryPage()
        {
            var purchaseSummaryPage = new PurchaseSummaryPage();
            var purchaseAddressPage = purchaseSummaryPage.ClickProcceedCheckoutButton();
            var purchaseShippingPage = purchaseAddressPage.ClickOnProceedButton();
            var purchasePaymentPage = purchaseShippingPage.ClickOnProceedButton();
            var myAccountPage = purchasePaymentPage.GoToMyAccountPage();
            return myAccountPage.GoToOrderHistory();
        }

    }
}

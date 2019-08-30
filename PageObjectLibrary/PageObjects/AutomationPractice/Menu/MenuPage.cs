using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.ContactUs;
using PageObjectLibrary.PageObjects.AutomationPractice.My_Account;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Menu
{
    public class MenuPage: BasePage
    {
        private IWebElement contactUsButton => GetDriver().FindElement(By.XPath("//a[@title='Contact Us']"));  
        private IWebElement signInButton => GetDriver().FindElement(By.CssSelector("a[class='login']"));
        private IWebElement myAccountButton => GetDriver().FindElement(By.CssSelector("a[class='account']"));
        
        public ContactUsPage ClickContactUs()
        {
            contactUsButton.Click();
            var contactUsPage = new ContactUsPage();
            return contactUsPage;
        }

        public SignInPage ClickSignInButton()
        {
            signInButton.Click();
            var signInPage = new SignInPage();
            return signInPage;
        }

        public MyAccountPage clickOnMyAccountPage()
        {
            myAccountButton.Click();
            return new MyAccountPage();
        }
 

    }
}

using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.My_Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Menu
{
    public class SignInPage:BasePage
    {
        private IWebElement emailField => GetDriver().FindElement(By.Id("email"));
        private IWebElement passwordField => GetDriver().FindElement(By.Id("passwd"));
        private IWebElement signInButton => GetDriver().FindElement(By.Id("SubmitLogin"));
        private IWebElement emailAddressforNewAccount => GetDriver().FindElement(By.Id("email_create"));
        private IWebElement createNewAccountButton => GetDriver().FindElement(By.Id("SubmitCreate"));

        public void setEmailAddress(string email)
        {
            emailField.SendKeys(email);
        }

        public void setPassword(string password)
        {
            passwordField.SendKeys(password);
        }

        public void clickSubmitButton()
        {
            signInButton.Click();
        }

        public MyAccountPage filloutForm(string email, string password)
        {
            setEmailAddress(email);
            setPassword(password);
            clickSubmitButton();
            return new MyAccountPage();
        }

        public void clickCreateNewAccountButton()
        {
            createNewAccountButton.Click();
        }
        public CreateNewAccountPage createNewAccount(string emailAddress)
        {
            emailAddressforNewAccount.SendKeys(emailAddress);
            clickCreateNewAccountButton();
            return new CreateNewAccountPage();
        }
        
    }
}

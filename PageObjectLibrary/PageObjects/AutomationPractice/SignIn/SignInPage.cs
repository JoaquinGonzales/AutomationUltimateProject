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

        public void SetEmailAddress(string email)
        {
            emailField.SendKeys(email);
        }

        public void SetPassword(string password)
        {
            passwordField.SendKeys(password);
        }

        public void ClickSubmitButton()
        {
            signInButton.Click();
        }

        public MyAccountPage FilloutForm(string email, string password)
        {
            SetEmailAddress(email);
            SetPassword(password);
            ClickSubmitButton();
            return new MyAccountPage();
        }

        public void ClickCreateNewAccountButton()
        {
            createNewAccountButton.Click();
        }
        public CreateNewAccountPage CreateNewAccount(string emailAddress)
        {
            emailAddressforNewAccount.SendKeys(emailAddress);
            ClickCreateNewAccountButton();
            return new CreateNewAccountPage();
        }
        
    }
}

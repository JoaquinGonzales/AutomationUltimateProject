using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.Menu;
using PageObjectLibrary.PageObjects.AutomationPractice.My_Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Dresses.Purchase_a_Dress
{
    public class PurchasePaymentPage:BasePage
    {
        private IWebElement payByBankWireButton => GetDriver().FindElement(By.CssSelector("a[class='bankwire']"));
        private IWebElement confirmOrderButton => GetDriver().FindElement(By.XPath("//span[text()='I confirm my order']"));
        private IWebElement confirmationMessage => GetDriver().FindElement(By.CssSelector("p[class='cheque-indent']"));

        public void SelectPayByBankWire()
        {
            payByBankWireButton.Click();
        }

        public void ConfirmOrder()
        {
            confirmOrderButton.Click();
        }

        public string ReturnConfirmationMessage()
        {
            return confirmationMessage.Text;
        }

        public MyAccountPage GoToMyAccountPage()
        {
            var menupage = new MenuPage();
            return menupage.ClickOnMyAccountPage();
        }
    }
}

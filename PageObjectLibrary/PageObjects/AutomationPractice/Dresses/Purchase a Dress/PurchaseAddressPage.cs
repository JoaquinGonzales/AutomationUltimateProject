using OpenQA.Selenium;
using PageObjectLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Dresses.Purchase_a_Dress
{
    public class PurchaseAddressPage:BasePage
    {
        private IWebElement proceedButton => GetDriver().FindElement(By.CssSelector("button[name='processAddress']"));

        public PurchaseShippingPage ClickOnProceedButton()
        {
            proceedButton.Click();
            return new PurchaseShippingPage();
        }
    }
}

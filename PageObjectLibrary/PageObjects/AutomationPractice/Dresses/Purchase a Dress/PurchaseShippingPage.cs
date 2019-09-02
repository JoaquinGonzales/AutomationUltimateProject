using OpenQA.Selenium;
using PageObjectLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Dresses.Purchase_a_Dress
{
    public class PurchaseShippingPage:BasePage
    {
        private IWebElement proceedCheckoutButton => GetDriver().FindElement(By.CssSelector("button[name='processCarrier']"));

        private IWebElement termOfServicesCheckBox => GetDriver().FindElement(By.CssSelector("input[id='cgv']"));

        public void AcceptTermsOfServicesCheckBox()
        {
            termOfServicesCheckBox.Click();
        }

        public PurchasePaymentPage ClickOnProceedButton()
        {
            AcceptTermsOfServicesCheckBox();
            proceedCheckoutButton.Click();
            return new PurchasePaymentPage();
        }
    }
}

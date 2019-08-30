using OpenQA.Selenium;
using PageObjectLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Dresses.Purchase_a_Dress
{
    public class PurchaseSummaryPage:BasePage
    {
        private IWebElement priceInSummary => GetDriver().FindElement(By.CssSelector("td[data-title='Unit price'] span span"));
        private IWebElement proceedCheckOutButton => GetDriver().FindElement(By.CssSelector("p[class='cart_navigation clearfix'] a[title='Proceed to checkout']"));


        public string getPriceFromSummaryPage()
        {
            return priceInSummary.Text;
        }
        public PurchaseAddressPage clickProcceedCheckoutButton()
        {
            proceedCheckOutButton.Click();
            return new PurchaseAddressPage();
        }
    }
}

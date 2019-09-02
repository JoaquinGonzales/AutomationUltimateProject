using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses.Purchase_a_Dress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Dresses
{
    public class ProductSelectionPage : BasePage
    {
        private IWebElement addToCartButton => GetDriver().FindElement(By.XPath("//p[@id='add_to_cart']/button"));

        private IWebElement proceedToCheckoutButton => GetDriver().FindElement(By.CssSelector("a[title='Proceed to checkout']"));

        public void AddFirstProductToCart()
        {
            addToCartButton.Click();
        }
        public PurchaseSummaryPage ClickProceedToCheckOutButton()
        {
            AddFirstProductToCart();
            proceedToCheckoutButton.Click();
            return new PurchaseSummaryPage();
        }
    }
}


using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses.Purchase_a_Dress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects
{
    public class CasualDressesPage:BasePage
    {
        private IWebElement casualDressFirst => GetDriver().FindElement(By.CssSelector("a[title = 'Add to cart']"));
        private IWebElement image => GetDriver().FindElement(By.CssSelector("a[class='product_img_link'] img"));
        private IWebElement addToCart => GetDriver().FindElement(By.CssSelector("a[title='Proceed to checkout']"));
        
        public void clickAddProductButton()
        {
            actions.MoveToElement(image).Perform();
           /* var casualDressFirst = GetDriver().FindElement(By.CssSelector("a[title = 'Add to cart']"));
            actions.MoveToElement(casualDressFirst).Perform();*/
            casualDressFirst.Click();
        }

        public PurchaseSummaryPage selectFisrtProduct()
        {
            clickAddProductButton();
            addToCart.Click();
            return new PurchaseSummaryPage();
        }
    }
}

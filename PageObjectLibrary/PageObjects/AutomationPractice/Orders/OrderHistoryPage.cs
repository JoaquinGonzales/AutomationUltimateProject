
using OpenQA.Selenium;
using PageObjectLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Orders
{
    public class OrderHistoryPage: BasePage
    {

        private IWebElement displayOrderDetails => GetDriver().FindElement(By.CssSelector("a[class='color-myaccount']"));
        private IWebElement totalPriceLabel => GetDriver().FindElement(By.XPath("//tr[@class='item']/td[@class='price'][2]"));

      

        public void showDetails()
        {
            displayOrderDetails.Click();
        }

        public string getTotalPriceFromOrderHistory()
        {
            actions.MoveToElement(totalPriceLabel).Perform();
            return totalPriceLabel.Text;
        }
    }
}

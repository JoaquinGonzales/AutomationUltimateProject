using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.Menu;
using PageObjectLibrary.PageObjects.AutomationPractice.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.My_Account
{

    public class MyAccountPage : BasePage
    {
        private MenuBarPage menuBarPage;
        private IWebElement myOrderHistoryButton => GetDriver().FindElement(By.CssSelector("a[title='Orders']"));
        private IWebElement accountButton => GetDriver().FindElement(By.XPath("//a[@class='account']/span"));

        public CasualDressesPage NavigateToMyDresses()
        {
            menuBarPage = new MenuBarPage();
            return menuBarPage.GoToCasualAddressOption();
        }

        public OrderHistoryPage GoToOrderHistory()
        {
            myOrderHistoryButton.Click();
            return new OrderHistoryPage();
        }
        public string ReturnAccountName()
        {
            return accountButton.Text;
        }   
    }
}

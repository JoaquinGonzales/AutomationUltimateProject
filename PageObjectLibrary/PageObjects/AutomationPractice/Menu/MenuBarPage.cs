using OpenQA.Selenium;
using PageObjectLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Menu
{
    public class MenuBarPage:BasePage
    {
        IWebElement womenNavigationBarOption => GetDriver().FindElement(By.CssSelector("a[title='Women']"));
        IWebElement casualDressesOption => GetDriver().FindElement(By.CssSelector("a[title='Casual Dresses']"));

        public void MoveMouseOverWomenOption()
        {
            actions.MoveToElement(womenNavigationBarOption).Perform();
        }
        public void SelectCasualDressOption()
        {
            casualDressesOption.Click();
        }

        public CasualDressesPage GoToCasualAddressOption()
        {
            MoveMouseOverWomenOption();
            SelectCasualDressOption();
            return new CasualDressesPage();
        }

    }
}

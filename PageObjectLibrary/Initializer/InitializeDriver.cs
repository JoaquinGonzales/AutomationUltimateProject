using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using PageObjectLibrary.Base;
using System;
using System.IO;
using System.Reflection;

namespace PageObjectLibrary.Initializer
{
    public class InitializeDriver: BaseDriver
    {
        public void OpenBrowser()
        {
            string browserType = "Chrome";
            switch(browserType)
            {
                case "Chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--start-maximized");
                    chromeOptions.AddArgument("--incognito");
                    SetDriver(new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions));
                    break;
                case "Firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("--start-maximized");
                    firefoxOptions.AddArgument("--incognito");
                    SetDriver(new FirefoxDriver(@"C:\SeleniumWebDrivers", firefoxOptions));
                    break;
                    ////other browsers
            }
            //implicit timeouts
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GetDriver().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        }

        public void CloseBrowser()
        {
            GetDriver().Close();
            GetDriver().Quit();
        }
    }
}

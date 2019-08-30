using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjectLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.My_Account
{
    public class CreateNewAccountPage:BasePage
    {
        //private IWebElement radioButton => GetDriver().FindElement(By.XPath("//div[@class='radio']/span/input[@id='id_gender1']"));
        private IWebElement firstNameField => GetDriver().FindElement(By.Id("customer_firstname"));
        private IWebElement lastNameField => GetDriver().FindElement(By.Name("customer_lastname"));
        private IWebElement passwordField => GetDriver().FindElement(By.XPath("//input[@data-validate='isPasswd']"));
        private IWebElement dayDropDown => GetDriver().FindElement(By.Id("days"));
        private IWebElement monthDropDown => GetDriver().FindElement(By.Id("months"));
        private IWebElement yearDropDown => GetDriver().FindElement(By.Id("years"));
        private IWebElement newsLetterCheckBox => GetDriver().FindElement(By.Name("newsletter"));
        private IWebElement otherCheckBox => GetDriver().FindElement(By.Id("optin"));
        private IWebElement firstName => GetDriver().FindElement(By.Id("firstname"));
        private IWebElement lastName => GetDriver().FindElement(By.Id("lastname"));
        private IWebElement company => GetDriver().FindElement(By.Id("company"));
        private IWebElement adrressField => GetDriver().FindElement(By.Id("address1"));
        private IWebElement cityField => GetDriver().FindElement(By.Name("city"));
        private IWebElement stateDropDown => GetDriver().FindElement(By.Id("id_state"));
        private IWebElement zipCodefield => GetDriver().FindElement(By.Id("postcode"));
        private IWebElement selectCountryDropDown => GetDriver().FindElement(By.Id("id_country"));
        private IWebElement otherInformationfield => GetDriver().FindElement(By.Name("other"));
        private IWebElement homePhonefield => GetDriver().FindElement(By.Name("phone"));
        private IWebElement cellNumberfield => GetDriver().FindElement(By.Id("phone_mobile"));
        private IWebElement aliasField => GetDriver().FindElement(By.Id("alias"));
        private IWebElement sendAccountButton => GetDriver().FindElement(By.Id("submitAccount"));
        public void selectGender()
        {
            /*var radioButton = GetDriver().FindElement(By.XPath("//div[@class='radio']/span/input[@id='id_gender1']"));
            wait.Until(ExpectedConditions.ElementToBeClickable(radioButton));*/
            var radouButton = GetDriver().FindElement(By.XPath("//div[@class='radio']/span/input[@id='id_gender1']"));
            actions.Click(radouButton).Perform();
            //radioButton.Click();
        }

        public void fillOutCustomerFirstName(string firstName)
        {
            firstNameField.SendKeys(firstName);
        }

        public void fillOutCustomerLastName(string lastName)
        {
            lastNameField.SendKeys(lastName);
        }

        public void fillOutPassword(string password)
        {
            passwordField.SendKeys(password);
        }

        public void selectDays(string days)
        {
            SelectElement selectForDay = new SelectElement(dayDropDown);
            selectForDay.SelectByValue(days);
        }

        public void selectMonth(string month)
        {
            SelectElement SelectForMonth = new SelectElement(monthDropDown);
            SelectForMonth.SelectByValue(month);
        }

        public void selectYear(string year)
        {
            SelectElement SelectForYear = new SelectElement(yearDropDown);
            SelectForYear.SelectByValue(year);
        }

        public void checkNewLetterCheckBox()
        {
            newsLetterCheckBox.Click();
        }

        public void checkOtherCheckBox()
        {
            otherCheckBox.Click();
        }

        public void fillOutFirstName(string fname)
        {
            firstName.SendKeys(fname);
        }

        public void fillOutLastName(string lname)
        {
            lastName.SendKeys(lname);
        }

        public void fillOutCompany(string companyName)
        {
            company.SendKeys(companyName);
        }

        public void fillOutAddress(string address)
        {
            adrressField.SendKeys(address);
        }

        public void fillOutCity(string city)
        {
            cityField.SendKeys(city);
        }

        public void selectStateDropDown(string state)
        {
            SelectElement selectState = new SelectElement(stateDropDown);
            selectState.SelectByText(state);
        }

        public void fillOutZipCode(string zipCode)
        {
            zipCodefield.SendKeys(zipCode);
        }

        public void chooseCountryDropDown(string country)
        {
            SelectElement selectCountry = new SelectElement(selectCountryDropDown);
            selectCountry.SelectByValue(country);
        }

        public void fillOutOtherInformation(string otherInformation)
        {
            otherInformationfield.SendKeys(otherInformation);
        }

        public void fillOutPhoneField(string phone)
        {
            homePhonefield.SendKeys(phone);
        }

        public void fillOutCellNumber(string cellnumber)
        {
            cellNumberfield.SendKeys(cellnumber);
        }

        public void fillOutAliasField(string alias)
        {
            aliasField.SendKeys(alias);
        }

        public void clickSendNewAccountButton()
        {
            sendAccountButton.Click();
        }
        public MyAccountPage fillOutNewAccountForm(string customerFirstName, string customerLastName, string password, string day, string month, string year,string firstName, string lastName, string companyName, string address, string city, string state, string postalCode, string countryCode, string otherInfo, string phone, string cellPhone, string alias)
        {
            selectGender();
            fillOutCustomerFirstName(customerFirstName);
            fillOutCustomerLastName(customerLastName);
            fillOutPassword(password);
            selectDays(day);
            selectMonth(month);
            selectYear(year);
            checkNewLetterCheckBox();
            checkOtherCheckBox();
            fillOutFirstName(firstName);
            fillOutLastName(lastName);
            fillOutCompany(companyName);
            fillOutAddress(address);
            fillOutCity(city);
            selectStateDropDown(state);
            fillOutZipCode(postalCode);
            chooseCountryDropDown(countryCode);
            fillOutOtherInformation(otherInfo);
            fillOutPhoneField(phone);
            fillOutCellNumber(cellPhone);
            fillOutAliasField(alias);
            clickSendNewAccountButton();
            return new MyAccountPage();
        }
    }
}

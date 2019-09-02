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
        public void SelectGender()
        {
            var radouButton = GetDriver().FindElement(By.XPath("//div[@class='radio']/span/input[@id='id_gender1']"));
            actions.Click(radouButton).Perform();  
        }

        public void FillOutCustomerFirstName(string firstName)
        {
            firstNameField.SendKeys(firstName);
        }

        public void FillOutCustomerLastName(string lastName)
        {
            lastNameField.SendKeys(lastName);
        }

        public void FillOutPassword(string password)
        {
            passwordField.SendKeys(password);
        }

        public void SelectDays(string days)
        {
            SelectElement selectForDay = new SelectElement(dayDropDown);
            selectForDay.SelectByValue(days);
        }

        public void SelectMonth(string month)
        {
            SelectElement SelectForMonth = new SelectElement(monthDropDown);
            SelectForMonth.SelectByValue(month);
        }

        public void SelectYear(string year)
        {
            SelectElement SelectForYear = new SelectElement(yearDropDown);
            SelectForYear.SelectByValue(year);
        }

        public void CheckNewLetterCheckBox()
        {
            newsLetterCheckBox.Click();
        }

        public void CheckOtherCheckBox()
        {
            otherCheckBox.Click();
        }

        public void FillOutFirstName(string fname)
        {
            firstName.SendKeys(fname);
        }

        public void FillOutLastName(string lname)
        {
            lastName.SendKeys(lname);
        }

        public void FillOutCompany(string companyName)
        {
            company.SendKeys(companyName);
        }

        public void FillOutAddress(string address)
        {
            adrressField.SendKeys(address);
        }

        public void FillOutCity(string city)
        {
            cityField.SendKeys(city);
        }

        public void SelectStateDropDown(string state)
        {
            SelectElement selectState = new SelectElement(stateDropDown);
            selectState.SelectByText(state);
        }

        public void FillOutZipCode(string zipCode)
        {
            zipCodefield.SendKeys(zipCode);
        }

        public void ChooseCountryDropDown(string country)
        {
            SelectElement selectCountry = new SelectElement(selectCountryDropDown);
            selectCountry.SelectByValue(country);
        }

        public void FillOutOtherInformation(string otherInformation)
        {
            otherInformationfield.SendKeys(otherInformation);
        }

        public void FillOutPhoneField(string phone)
        {
            homePhonefield.SendKeys(phone);
        }

        public void FillOutCellNumber(string cellnumber)
        {
            cellNumberfield.SendKeys(cellnumber);
        }

        public void FillOutAliasField(string alias)
        {
            aliasField.SendKeys(alias);
        }

        public void ClickSendNewAccountButton()
        {
            sendAccountButton.Click();
        }
        public MyAccountPage FillOutNewAccountForm(string customerFirstName, string customerLastName, string password, string day, string month, string year,string firstName, string lastName, string companyName, string address, string city, string state, string postalCode, string countryCode, string otherInfo, string phone, string cellPhone, string alias)
        {
            SelectGender();
            FillOutCustomerFirstName(customerFirstName);
            FillOutCustomerLastName(customerLastName);
            FillOutPassword(password);
            SelectDays(day);
            SelectMonth(month);
            SelectYear(year);
            CheckNewLetterCheckBox();
            CheckOtherCheckBox();
            FillOutFirstName(firstName);
            FillOutLastName(lastName);
            FillOutCompany(companyName);
            FillOutAddress(address);
            FillOutCity(city);
            SelectStateDropDown(state);
            FillOutZipCode(postalCode);
            ChooseCountryDropDown(countryCode);
            FillOutOtherInformation(otherInfo);
            FillOutPhoneField(phone);
            FillOutCellNumber(cellPhone);
            FillOutAliasField(alias);
            ClickSendNewAccountButton();
            return new MyAccountPage();
        }
    }
}

using OpenQA.Selenium;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;
using WorkshopBDD.ComponentHelper;

namespace WorkshopBDD_SpecFlow.StepDefinitions
{
    [Binding]
    public class CreditCardValidatorStepDefinitions
    {
        private string workshopURL = "http://localhost/exam/Workshop.html";
        private string paymentConfirmedURL = "http://localhost/exam/paymentConfirmed.html";

        #region RegexValidation

        private string creditCardNumberRegex = @"^[0-9]{16}$";
        private string expirationDateRegex = @"^[0-9]{2}/[0-9]{4}$";
        private string cvcRegex = @"^[0-9]{3}$";

        #endregion

        #region Webelement

        private By creditCardNumber = By.Id("creditCardNumber");
        private By expirationDate = By.Id("expirationDate");
        private By cvc = By.Id("cvc");
        private By submitCard = By.Id("submitCard");

        #endregion

        #region Action

        public void submitForm()
        {
            ButtonHelper.ClickButton(submitCard);
        }

        #endregion

        [Given(@"user fills the three inputs ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenUserFillsTheThreeInputs(string creditCardNumberParam, string expirationDateParam, string cvcParam)
        {
            TextBoxHelper.TypeInTextBox(creditCardNumber, creditCardNumberParam);
            TextBoxHelper.TypeInTextBox(expirationDate, expirationDateParam);
            TextBoxHelper.TypeInTextBox(cvc, cvcParam);
        }

        [Given(@"credit card number is sixteen digits long")]
        public void GivenCreditCardNumberIsSixteenDigitsLong()
        {
            string value = GenericHelper.GetElement(creditCardNumber).GetAttribute("value");

            Assert.IsTrue(Regex.Match(value, creditCardNumberRegex, RegexOptions.IgnoreCase).Success);
        }

        [Given(@"expiration date is at format MM/YYYY")]
        public void GivenExpirationDateIsAtFormatMMYYYY()
        {
            string value = GenericHelper.GetElement(expirationDate).GetAttribute("value");

            Assert.IsTrue(Regex.Match(value, expirationDateRegex, RegexOptions.IgnoreCase).Success);
        }

        [Given(@"cvc is three digits long")]
        public void GivenCvcIsThreeDigitsLong()
        {
            string value = GenericHelper.GetElement(cvc).GetAttribute("value");

            Assert.IsTrue(Regex.Match(value, cvcRegex, RegexOptions.IgnoreCase).Success);
        }

        [When(@"submit button is pressed")]
        public void WhenSubmitButtonIsPressed()
        {
            submitForm();
        }

        [Then(@"user is on page paymentConfirmed")]
        public void ThenUserIsOnPagePaymentConfirmed()
        {
            Assert.AreEqual(PageHelper.GetPageUrl(), paymentConfirmedURL);
        }

        [Given(@"credit card number is not sixteen digits long")]
        public void GivenCreditCardNumberIsNotSixteenDigitsLong()
        {
            string value = GenericHelper.GetElement(creditCardNumber).GetAttribute("value");

            Assert.IsFalse(Regex.Match(value, creditCardNumberRegex, RegexOptions.IgnoreCase).Success);
        }

        [Given(@"expiration date is not at format MM/YYYY")]
        public void GivenExpirationDateIsNotAtFormatMMYYYY()
        {
            string value = GenericHelper.GetElement(expirationDate).GetAttribute("value");

            Assert.IsFalse(Regex.Match(value, expirationDateRegex, RegexOptions.IgnoreCase).Success);
        }

        [Given(@"cvc is not three digits long")]
        public void GivenCvcIsNotThreeDigitsLong()
        {
            string value = GenericHelper.GetElement(cvc).GetAttribute("value");

            Assert.IsFalse(Regex.Match(value, cvcRegex, RegexOptions.IgnoreCase).Success);
        }

        [Then(@"user is on homePage")]
        public void ThenUserIsOnHomePage()
        {
            Assert.AreEqual(PageHelper.GetPageUrl(), workshopURL);
        }
    }
}

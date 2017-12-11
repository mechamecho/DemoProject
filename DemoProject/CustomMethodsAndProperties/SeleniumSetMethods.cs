using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoProject
{
    public static class SeleniumSetMethods
    {
        public static void CapitalizeInput(this IWebElement element, string value)
        {

            string upperCaseData = value.ToUpper();
            element.EnterTextInTextField(upperCaseData[0] + upperCaseData.Substring(1).ToLower());
        }

        /// <summary>
        /// Extended method for entering the text in textfield
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterTextInTextField(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        /// <summary>
        /// Click a button, Checkbox etc
        /// </summary>
        /// <param name="element"></param>
        public static void ClickElement(this IWebElement element)
        {
            element.Click();
        }

        /// <summary>
        ///Selecting a drop down element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectOptionFromDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}

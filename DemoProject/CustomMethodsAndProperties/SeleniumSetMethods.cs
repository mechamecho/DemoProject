using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoProject.CustomMethodsAndProperties
{
    public static class SeleniumSetMethods
    {
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

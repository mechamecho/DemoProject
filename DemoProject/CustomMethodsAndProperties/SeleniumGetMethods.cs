using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoProject.CustomMethodsAndProperties
{
    public static class SeleniumGetMethods
    {
        public static string GetTextEnteredInTextField(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDropDown(this IWebElement element)
        {
            return new SelectElement(element).SelectedOption.Text; 
        }
    }
}

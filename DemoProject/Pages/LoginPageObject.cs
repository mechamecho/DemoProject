using DemoProject.CustomMethodsAndProperties;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoProject.Pages
{
    public class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(DriverClass.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement UsernameTextField { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement PasswordTextField { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement LoginBtn { get; set; }

        public EAUserFormPageObject Login(string username, string password)
        {
            FillLoginForm(username, password);
            return ClickLoginBtn();
        }

        public void FillLoginForm(string username, string password)
        {
            //Enter the Username in the Username field
            UsernameTextField.EnterTextInTextField(username);
    
            //Enter the password in the password field
            PasswordTextField.EnterTextInTextField(password);
        }

        public EAUserFormPageObject ClickLoginBtn()
        {
            //Click button
            LoginBtn.Submit();
            return new EAUserFormPageObject();
        }
    }



}

using System;
using System.Collections;
using DemoProject.CustomMethodsAndProperties;
using NUnit.Framework;
using DemoProject.Pages;
using OpenQA.Selenium.Chrome;

//CareerDevs QA
//comment 
//Caitlyn pentakill
namespace DemoProject.Tests.LoginPageTests
{
    [TestFixture]
    internal class LoginPageTest
    {
        //Declaring LoginPageObject in the global scope
        private LoginPageObject _loginPage;

        [SetUp]
        public void Initialize()
        {
            //Initializing a new chrome driver
            DriverClass.Driver = new ChromeDriver();

            //Initializing the LoginPageObject instance
            _loginPage =new LoginPageObject();
            Console.WriteLine("Opening Browser and Maximizing screen");
            //Maximizing the browsers screensize to fullscreen
            DriverClass.Driver.Manage().Window.Maximize();
            Console.WriteLine(@"Naviagting to 'http://executeautomation.com/demosite/Login.html'");
            //Navigating to the login page
            DriverClass.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [TestCaseSource(typeof(UsernameAndPasswordSource))]

        public void FillLoginForm_Username_UsernameTextIsCorrect(string username, string password)
        {
            //string interpolation
            Console.WriteLine($"Filling out the login form with {username} and {password}");
            _loginPage.FillLoginForm(username, password);
            var expectedUsername = username.Length <= 10 ? username : username.Substring(0, 10);

            Assert.That(_loginPage.UsernameTextField.GetTextEnteredInTextField(), Is.EqualTo(expectedUsername));

        }

        [TestCaseSource(typeof(UsernameAndPasswordSource))]
        public void FillLoginForm_Password_PasswordTextIsCorrect(string username, string password)
        {
            Console.WriteLine($"Filling out the login form with {username} and {password}");
            _loginPage.FillLoginForm(username, password);
            var expectedPassword = password.Length <= 10 ? password : password.Substring(0, 10);

              //var expectedPassword;
              //if(password.Length<10)
              //{
              //      expectedPassword=password;
              //  }
              //  else
              //  {
              //     expectedPassword=password.Substring(0,10);
              //  }


            Assert.That(_loginPage.PasswordTextField.GetTextEnteredInTextField(), Is.EqualTo(expectedPassword));
        }

        public class UsernameAndPasswordSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new[] { "Nafissa", "somePassword" };
                yield return new [] { "Viktorius", "AnotherPassword with space" };
            }
        }

        [TearDown]
        //Closes the browser
        public void CleanUp()
        {
            Console.WriteLine("Closing the Browser");
            //To close the browser after typing the value
            DriverClass.Driver.Close(); 
        }
    }
}

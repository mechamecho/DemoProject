using DemoProject.CustomMethodsAndProperties;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoProject.Pages
{
    public class EAUserFormPageObject
    {
        public EAUserFormPageObject()
        {
            //To initialize the instance of this class(Page) and populate it with the given elements(properties of this class)
            PageFactory.InitElements(DriverClass.Driver, this);
        }

        //To identify the title element
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleInDropDown { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement InitialTextField { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement FirstnameTextField { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement MiddlenameTextField { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.Name, Using = "Male")]
        public IWebElement MaleRadioButton { get; set; }

        [FindsBy(How = How.Name, Using = "Female")]
        public IWebElement FemaleRadioButton { get; set; }

        [FindsBy(How = How.Name, Using = "english")]
        public IWebElement EnglishCheckbox { get; set; }

        [FindsBy(How = How.Name, Using = "Hindi")]
        public IWebElement HindiCheckbox { get; set; }

        //To select the title
        public void SelectTitle(string title)
        {
            switch (title.ToLower())
            {
                case ("mr."):
                    TitleInDropDown.SelectOptionFromDropDown("Mr.");
                    break;

                case ("ms."):
                    TitleInDropDown.SelectOptionFromDropDown("Ms.");
                    break;

            }
        }

        ////To click the Gender RadioButton
        //public void ClickGender(string gender)
        //{
        //    switch (gender.ToLower())
        //    {
        //        case ("male"):
        //            MaleRadioButton.ClickElement();
        //            break;

        //        case ("female"):
        //            FemaleRadioButton.ClickElement();
        //            break;
        //    }
        //}

        ////To click the Languages checkboxes
        //public void ClickLanguage(string[] languages)
        //{
        //    //To uncheck the default English checkbox
        //    if (!languages[0].ToLower().Equals("english"))
        //    {
        //        EnglishCheckbox.ClickElement();
        //    }
        //    if (languages[1].ToLower().Equals("hindi"))
        //    {

        //        HindiCheckbox.ClickElement();
        //    }

        //}

        public void FillUserForm(string title, string initial, string firstName, string middleName, string gender, string[] languages)
        {
            //The extended methods works directly on the IWebElement
            SelectTitle(title);
            InitialTextField.EnterTextInTextField(initial);
            //FirstnameTextField.CapitalizeInput(firstName);
            //MiddlenameTextField.CapitalizeInput(middleName);
            //ClickGender(gender);
            //ClickLanguage(languages);
        }

        public void FillAndSubmitUserForm(string title, string initial, string firstName, string middleName, string gender, string[] languages)
        {
            FillUserForm(title, initial, firstName, middleName, gender, languages);
            //SubmitForm();
        }

        //public void SubmitForm()
        //{
        //    SaveButton.ClickElement();

        //}
    }
}

using NUnit.Framework;
using Studentbeans_QA_Tech_Test.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Enra_QA_Tech_Test.StepDefinition
{
    [Binding]
    public class LoginSteps

    {
        LoginPage loginPage;

        public LoginSteps()
        {
            loginPage = new LoginPage();
        }


        [Given(@"I Navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            loginPage.NavigateToWebsite(url);
        }
        
        [Given(@"I enter a valid email ""(.*)""")]
        public void GivenIEnterAValidEmail(string email)
        {
            loginPage.EnterEmail(email);
        }
        
        [Given(@"I enter a valid password ""(.*)""")]
        public void GivenIEnterAValidPassword(string psw)
        {
            loginPage.EnterPassword(psw);
        }
        
        [When(@"I click on next")]
        public void WhenIClickOnNext()
        {
            loginPage.ClickNext();
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            Assert.That(loginPage.IsComposeButtonDisplayed);
        }

        [Given(@"I click on next")]
        public void GivenIClickOnNext()
        {
            loginPage.ClickNext1();
        }

        [Given(@"I enter an invalid password ""(.*)""")]
        public void GivenIEnterAnInvalidPassword(string invpsw)
        {
            loginPage.EnterInvalidPassword(invpsw);
        }

        [Then(@"I should get an error message")]
        public void ThenIShouldGetAnErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter an invalid email ""(.*)""")]
        public void GivenIEnterAnInvalidEmail(string invemail)
        {
            loginPage.EnterInvalidEmail(invemail);
        }

    }
}

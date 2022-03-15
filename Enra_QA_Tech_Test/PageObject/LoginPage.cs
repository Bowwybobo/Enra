using OpenQA.Selenium;
using Studentbeans_QA_Tech_Test.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Studentbeans_QA_Tech_Test.PageObject
{
    class LoginPage
    {

        public LoginPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Email => driver.FindElement(By.XPath("//*[@id='identifierId']"));

        IWebElement Next1 => driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button")); 

        IWebElement Password => driver.FindElement(By.XPath("//*[@id='password']/div[1]/div/div[1]/input"));

        IWebElement Next => driver.FindElement(By.XPath("//*[@id='passwordNext']/div/button"));

        IWebElement ConfirmComposeButtonIsDisplayed => driver.FindElement(By.XPath("//div[text()='Compose']"));





        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }



        public void EnterEmail(string email)
        {
            Email.SendKeys(email );
        }


        public void ClickNext1()
        {
            Next1.Click();
        }


        public void EnterPassword(string psw)
        {
            Thread.Sleep(5000);
            Password.SendKeys(psw);
        }


        public void ClickNext()
        {
            Next.Click();
        }


        public bool IsComposeButtonDisplayed()
        {
            Thread.Sleep(8000);
            return ConfirmComposeButtonIsDisplayed.Displayed;
        }



        public void EnterInvalidPassword(string invpsw)
        {
            Thread.Sleep(5000);
            Password.SendKeys(invpsw);
        }



        public void EnterInvalidEmail(string invemail)
        {
            Email.SendKeys(invemail);
        }

    }
}

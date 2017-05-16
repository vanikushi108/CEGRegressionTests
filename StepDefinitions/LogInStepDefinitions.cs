using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;


namespace CEGRegressionTests.StepDefinitions
{
    [Binding]
    public class LogInStepDefinitions
    {

        [BeforeScenario]
        public void Setup()
        {
            Driver.Initialize();
           // Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Close();
        }

        [Given(@"I am on the Connect home page")]
        public void GivenIAmOnTheConnectHomePage()
          {
              Driver.driver.Navigate().GoToUrl(Driver.BaseAddress);
        }

        [Given(@"I enter user name as")]
        public void GivenIEnterUserNameAs()
        {
            Driver.driver.FindElement(By.Id("userNameInput")).SendKeys("vkasala@CEG");
        }

        [Given(@"I enter Password as")]
        public void GivenIEnterPasswordAs()
        {
            Driver.driver.FindElement(By.Id("passwordInput")).SendKeys("vanithaceg123");
        }

        [When(@"I click on signIn")]
        public void WhenIClickOnSignIn()
        {
            Driver.driver.FindElement(By.Id("submitButton")).Click();
        }

        [Then(@"I should see logged in user as")]
        public void ThenIShouldSeeLoggedInUserAs()
        {
            Console.WriteLine("Vanitha");
            System.Threading.Thread.Sleep(5000);
        }


       

        }

    }
         
    

   


    



       
    


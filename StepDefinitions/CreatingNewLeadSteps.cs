using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;



namespace CEGRegressionTests.StepDefinitions
{
    [Binding]
    public class CreatingNewLeadSteps
    {
        [BeforeScenario]
        public void Setup()
        {
            Driver.Initialize();
            Driver.driver.Navigate().GoToUrl(Driver.BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Close();
        }

        [Given(@"I navigate to connect home page")]
        public void GivenINavigateToConnectHomePage()
        {

        }

        [When(@"I click On services")]
        public void WhenIClickOnServices()
        {
            Driver.driver.FindElement(By.ClassName("navTabButtonImageContainer"));
        }

        [Then(@"I select Lead from services")]
        public void ThenISelectLeadFromServices()
        {
            
            //IWait wait = new IWebDriverWait(Driver, TimeSpan.FromSeconds(4));
            //WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(4));
     
           // IWebElement element = Wait.Until(driver => driver.FindElement(By.Name("")));
           
        }
        [When(@"I click On \+New icon")]
        public void WhenIClickOnNewIcon()
        {
            ScenarioContext.Current.Pending();
        }   
    }  
}


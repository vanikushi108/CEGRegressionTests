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
        [Given(@"I am on navigate page")]
        public void GivenIamOnConnectHomePage()
        {

        }

        [Given(@"I click On services")]
        public void WhenIClickOnServices()
        {
            System.Threading.Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("homeButtonImage")).Click();
            System.Threading.Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//span[contains(@class, 'navActionButtonLabel') and text() = 'Service']")).Click();
            System.Threading.Thread.Sleep(1000);
        }

        [Then(@"I select Lead from services")]
        public void ThenISelectLeadFromServices()
        {
            Driver.driver.FindElement(By.CssSelector("#nav_leads")).Click();
            System.Threading.Thread.Sleep(3000);
        }

        [When(@"I click On \+New icon")]
        public void WhenIClickOnNewIcon()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='lead|NoRelationship|HomePageGrid|Mscrm.HomepageGrid.lead.NewRecord']/span")).Click();
            System.Threading.Thread.Sleep(1000);
        }

        [Then(@"I should see Student Application Form")]
        public void Then_I_Should_See_Student_Application_Form()
        {
        }

        [Given(@"I Enter Prefix as ""(.*)""")]
        public void GivenIEnterPrefixOfTheStudent(string prefix)
        {
            Driver.driver.SwitchTo().Frame(Driver.driver.FindElement(By.Id("contentIFrame1")));
            Driver.driver.FindElement(By.Id("ccrm_studentsalutation_i")).Click();
            Driver.driver.FindElement(By.Id("ccrm_studentsalutation_i")).SendKeys(prefix);
            Driver.driver.FindElement(By.Id("ccrm_studentsalutation_i")).SendKeys(Keys.Tab);
        }

        [Given(@"I Enter First name of the Student as ""(.*)""")]
        public void IEnterFirstNameOfTheStudent(string firstName)
        {
            Driver.driver.FindElement(By.Id("ccrm_studentfirstname_i")).Click();
            Driver.driver.FindElement(By.Id("ccrm_studentfirstname_i")).SendKeys(firstName);
            Driver.driver.FindElement(By.Id("ccrm_studentfirstname_i")).SendKeys(Keys.Tab);
        }

        [Given(@"I Enter Last name of the Student as ""(.*)""")]
        public void IEnterLastNameOfTheStudent(string lastName)
        {
            Driver.driver.FindElement(By.Id("ccrm_studentlastname_i")).Click();
            Driver.driver.FindElement(By.Id("ccrm_studentlastname_i")).SendKeys(lastName);
            Driver.driver.FindElement(By.Id("ccrm_studentlastname_i")).SendKeys(Keys.Tab);
        }

        [Given(@"I Enter Preferred name of the Student as ""(.*)""")]
        public void IEnterPreferredNameOfTheStudent(string preferredName)
        {
            Driver.driver.FindElement(By.Id("ccrm_studentpreferredname_i")).Click();
            Driver.driver.FindElement(By.Id("ccrm_studentpreferredname_i")).SendKeys(preferredName);
            Driver.driver.FindElement(By.Id("ccrm_studentpreferredname_i")).SendKeys(Keys.Tab);
        }

        [Given(@"I Enter Date Of Birth of the Student as ""(.*)""")]
        public void IEnterDateOfBirthOfTheStudent(string dob)
        {
            Driver.driver.FindElement(By.Id("ccrm_studentbirthdate_iDateInput")).Click();

            Driver.driver.FindElement(By.Id("ccrm_studentbirthdate_iDateInput")).SendKeys(dob);

        }
    }  
}


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class Feature1StepDefinitions
    {
        private IWebDriver driver;
        

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver =  new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            
            
        }

        [Then(@"Search for the Testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            driver.FindElement(By.Name("search_query")).SendKeys("Testers Talk");
            driver.FindElement(By.Name("search_query")).SendKeys(Keys.Enter);

            Thread.Sleep(5000);
            driver.Quit();
        }


    }
}

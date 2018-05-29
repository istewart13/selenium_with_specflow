using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoWebApp2.Tests
{
    public class LoanApplicationTests
    {
        [Fact]
        public void StartApplication()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // maximise browser window
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost/SeleniumTest");
            }
        }
    }
}

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

            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--user-data-dir=C:\\Users\\McDermott\\AppData\\Local\\Google\\Chrome\\User Data");

            using (IWebDriver driver = new ChromeDriver())
            {
                // maximise browser window
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost/SeleniumTest");

                IWebElement applicationButton = driver.FindElement(By.Id("startApplication"));
                applicationButton.Click();

                Assert.Equal("Start Loan Application - Loan Application", driver.Title);
            }
        }

        [Fact]
        public void SubmitApplication()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // maximise browser window
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://localhost/SeleniumTest/Home/StartLoanApplication");

                IWebElement firstNameInput = driver.FindElement(By.Id("FirstName"));
                firstNameInput.SendKeys("Sarah");

                driver.FindElement(By.Id("LastName")).SendKeys("Smith");

                driver.FindElement(By.Id("Loan")).Click();

                driver.FindElement(By.Name("TermsAcceptance")).Click();

                driver.FindElement(By.CssSelector(".btn.btn-primary")).Click();

                IWebElement confirmationNameSpan = driver.FindElement(By.Id("firstName"));

                string confirmationName = confirmationNameSpan.Text;

                Assert.Equal("Sarah", confirmationName);
            }
        }
    }
}

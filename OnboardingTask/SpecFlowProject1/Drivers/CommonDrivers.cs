using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;

namespace OnboardingMars.Drivers
{
    public class CommonDrivers
    {
        public static IWebDriver driver = new ChromeDriver();

     

        // Implicit wait
        public static void turnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void WaitForELementToExist(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                wait.Until(ExpectedConditions.ElementExists(By.Name(locatorValue)));
            }
        }

        //launch the Mars Web Portal
        public static void navigate()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            turnOnWait();
            driver.Manage().Window.Maximize();
        }

        //close the web browser
        public void close()
        {
            driver.Quit();

        }


    }
}

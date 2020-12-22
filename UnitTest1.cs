using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationIC
{
    public class Tests
    {
        IWebDriver driver;
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            //login page
            IWebElement username = driver.FindElement(By.XPath("//input [@id='UserName']"));
            username.SendKeys("hari");
            IWebElement password = driver.FindElement(By.XPath("//input [@id='Password']"));
            password.SendKeys("123123");
            IWebElement Submit = driver.FindElement(By.XPath("//input [@type='submit']"));
            Submit.Click();
            driver.Close();
            driver.Quit();


        }
       
    }

}
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Uri seleniumHubUrl = new Uri("http://localhost:4444");
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--no-sandbox"); 
        IWebDriver driver = new RemoteWebDriver(seleniumHubUrl, options); // Removed ToCapabilities() method
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://www.gillette.co.in");
        Thread.Sleep(5000); 
        IWebElement searchBox = driver.FindElement(By.CssSelector("#searchIconId"));
        searchBox.Click();
        IWebElement searchButton = driver.FindElement(By.XPath("//input[@id='search-box-input']"));
        searchButton.Click();
        searchButton.SendKeys("Razor");
        IWebElement razorElement = driver.FindElement(By.XPath("//div[@id='Razor']"));
        razorElement.Click();
        string currentUrl = driver.Url;
        Console.WriteLine("Current URL: " + currentUrl);
        driver.Quit();
    }
}

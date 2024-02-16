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
        IWebDriver driver = new RemoteWebDriver(seleniumHubUrl, options.ToCapabilities(), TimeSpan.FromSeconds(10));
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://www.gillette.co.in");
        Thread.Sleep(1000); 

        IWebElement searchBox = driver.FindElement(By.XPath("//*[@id="searchIconId"]"));
        searchBox.Click();

        searchBox.SendKeys("Razor");

        IWebElement searchButton = driver.FindElement(By.XPath("//button[@title='Search here']"));
        searchButton.Click();

        Thread.Sleep(1000);

        IWebElement razorElement = driver.FindElement(By.XPath("//div[@id='Razor']"));
        razorElement.Click();
        string currentUrl = driver.Url;
        Console.WriteLine("Current URL: " + currentUrl);

        // Closing the browser
        driver.Quit();
    }
}

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
        try
        {
            Console.WriteLine("hello111111111");
            IWebElement searchButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/header[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/a[1]/div[2]/p[1]"));
            Console.WriteLine("hellosdns");
            searchButton.Click();
            searchButton.SendKeys("Razor");
        }
        catch (System.Exception)
        {
            Console.WriteLine("hello");
            throw;
        }
        
        IWebElement razorElement = driver.FindElement(By.XPath("//div[@id='Razor']"));
        razorElement.Click();
        string currentUrl = driver.Url;
        Console.WriteLine("Current URL: " + currentUrl);
        driver.Quit();
    }
}

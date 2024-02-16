using OpenQA.Selenium;

namespace YourNamespace
{
    public class RazorUI
    {
        public static By SearchBox = By.XPath("//input[@id='search-box-input']");
        // public static By SearchBox = By.XPath("//input[@id='search-box-inputt']");
        public static By SearchIcon = By.XPath("//button[@title='Search here']");
        public static By SelectRazor = By.XPath("//div[@id='Razor']");
    }
}

using OpenQA.Selenium;

namespace YourNamespace
{
    public class RazorPage
    {
        private readonly IWebDriver _driver;

        public RazorPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickSearchBox()
        {
            var searchBox = _driver.FindElement(RazorUI.SearchBox);
            searchBox.Click();
        }
    }
}

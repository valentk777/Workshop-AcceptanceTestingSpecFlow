using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace TreeDelivaryApp.AutomationTests
{
    public class UICommandsHandler : IDisposable
    {
        private const string ApplicationUrl = "https://localhost:44422/";
        private readonly WebDriverContext _webDriverContext;

        public UICommandsHandler(WebDriverContext webDriverContext)
        {
            this._webDriverContext = webDriverContext;
        }

        public void OpenApplication()
        {
            _webDriverContext.chromeDriver.Navigate().GoToUrl(ApplicationUrl);
            _webDriverContext.chromeDriver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
        }

        public void NavigateToHomePage()
        {
            IWebElement element = _webDriverContext.chromeDriver.FindElement(By.Name("nav-home"));
            element.Click();
            //Thread.Sleep(3000);
        }

        public void NavigateToTreesPage()
        {
            IWebElement element = _webDriverContext.chromeDriver.FindElement(By.Name("nav-trees"));
            element.Click();
            //Thread.Sleep(3000);
        }

        public void NavigateToOrdersPage()
        {
            IWebElement element = _webDriverContext.chromeDriver.FindElement(By.Name("nav-orders"));
            element.Click();
            //Thread.Sleep(3000);
        }

        public void FillOrderInfo(string name, int treeType, string addrees)
        {
            FillOrderName(name);
            FillOrderTreeType(treeType);
            FillOrderAddress(addrees);
        }

        public void FillOrderName(string name)
        {
            IWebElement element = _webDriverContext.chromeDriver.FindElement(By.Name("tree-name"));
            element.SendKeys(name);
            // Thread.Sleep(2000);
        }
        public void FillOrderTreeType(int treeType)
        {
            IWebElement element = _webDriverContext.chromeDriver.FindElement(By.Name("tree-type"));
            element.SendKeys(treeType.ToString());
            // Thread.Sleep(2000);
        }

        public void FillOrderAddress(string addrees)
        {
            IWebElement element = _webDriverContext.chromeDriver.FindElement(By.Name("delivery-address"));
            element.SendKeys(addrees);
            //Thread.Sleep(2000);
        }

        public void SubmitOrder()
        {
            IWebElement element = _webDriverContext.chromeDriver.FindElement(By.Name("submit-order"));
            element.Click();
            //Thread.Sleep(3000);
        }

        public bool OrdedSuccess()
        {
            IWebElement element = _webDriverContext.chromeDriver.FindElement(By.Name("success"));
            //Thread.Sleep(2000);
            return element.Displayed;
        }

        public void Dispose()
        {
            _webDriverContext.chromeDriver.Dispose();
        }
    }
}

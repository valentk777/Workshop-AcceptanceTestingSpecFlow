using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TreeDeliveryApp.AutomationTests
{
    public class UICommandsHandler : IDisposable
    {
        private const string ApplicationUrl = "https://localhost:44422/";

        private readonly IWebDriver _driver;

        public UICommandsHandler()
        {
            _driver = new ChromeDriver();
        }

        public void OpenApplication()
        {
            _driver.Navigate().GoToUrl(ApplicationUrl);
            _driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
        }

        public void NavigateToHomePage()
        {
            IWebElement element = _driver.FindElement(By.Name("nav-home"));
            element.Click();
            //Thread.Sleep(3000);
        }

        public void NavigateToTreesPage()
        {
            IWebElement element = _driver.FindElement(By.Name("nav-trees"));
            element.Click();
            //Thread.Sleep(3000);
        }

        public void NavigateToOrdersPage()
        {
            IWebElement element = _driver.FindElement(By.Name("nav-orders"));
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
            IWebElement element = _driver.FindElement(By.Name("tree-name"));
            element.SendKeys(name);
           // Thread.Sleep(2000);
        }
        public void FillOrderTreeType(int treeType)
        {
            IWebElement element = _driver.FindElement(By.Name("tree-type"));
            element.SendKeys(treeType.ToString());
           // Thread.Sleep(2000);
        }

        public void FillOrderAddress(string addrees)
        {
            IWebElement element = _driver.FindElement(By.Name("delivery-address"));
            element.SendKeys(addrees);
            //Thread.Sleep(2000);
        }

        public void SubmitOrder()
        {
            IWebElement element = _driver.FindElement(By.Name("submit-order"));
            element.Click();
            //Thread.Sleep(3000);
        }

        public bool OrdedSuccess() 
        {
            IWebElement element = _driver.FindElement(By.Name("success"));
            //Thread.Sleep(2000);
            return element.Displayed;
        }

        public void Dispose()
        {
            _driver.Close();
        }
    }
}

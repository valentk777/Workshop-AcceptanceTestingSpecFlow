using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WebDriverContext
{
    public IWebDriver chromeDriver;

    public WebDriverContext()
    {
        chromeDriver = new ChromeDriver();
    }
}
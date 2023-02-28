using FluentAssertions;
using TechTalk.SpecFlow;
using TreeDelivaryApp.AutomationTests;

namespace TreeDelivaryApp.Tests.Steps
{
    [Binding]
    public class GetTreeSteps 
    {
        UICommandsHandler _driver = new UICommandsHandler();

        [BeforeScenario]
        public void OpenApp() 
        {
            _driver.OpenApplication();
        }

        [AfterScenario]
        public void CloseApp()
        {
            _driver.Dispose();
        }

        [When(@"Fill tree form with tree name (.*), valid tree type (.\d*) and delivery adress (.*)")]
        [When(@"Fill tree order form with valid tree name (.*), valid tree type (.\d*) and delivery adress (.*)")]
        public void WhenThreeOrderFormIsFilledInCorrecly(string treeName, int treeType, string deliverAdress) 
        {
            //_driver.NavigateToTreesPage();
            //_driver.NavigateToOrdersPage();
            //_driver.NavigateToHomePage();
            _driver.FillOrderInfo(treeName, treeType, deliverAdress);
        }

        [When(@"Press submit button")]
        public void WhenMakeOrderButtonIsPressed()
        {
            _driver.SubmitOrder();
        }

        [Then(@"Ordered successfully")]
        public void OrderSuccess()
        {
            var ordersuccess = _driver.OrdedSuccess();
            ordersuccess.Should().Be(true);
        }
    }
}
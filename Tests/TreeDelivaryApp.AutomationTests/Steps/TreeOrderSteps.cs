using FluentAssertions;
using TechTalk.SpecFlow;
using TreeDelivaryApp.AutomationTests;

namespace TreeDelivaryApp.Tests.Steps
{
    [Binding]
    public class GetTreeSteps 
    {
        private UICommandsHandler _commandsHandler;

        public GetTreeSteps(UICommandsHandler commandsHandler)
        {
            _commandsHandler = commandsHandler;
        }

        [When(@"Fill tree form with tree name (.*), valid tree type (.\d*) and delivery adress (.*)")]
        [When(@"Fill tree order form with valid tree name (.*), valid tree type (.\d*) and delivery adress (.*)")]
        public void WhenThreeOrderFormIsFilledInCorrecly(string treeName, int treeType, string deliverAdress) 
        {
            //_driver.NavigateToTreesPage();
            //_driver.NavigateToOrdersPage();
            //_driver.NavigateToHomePage();
            _commandsHandler.FillOrderInfo(treeName, treeType, deliverAdress);
        }

        [When(@"Press submit button")]
        public void WhenMakeOrderButtonIsPressed()
        {
            _commandsHandler.SubmitOrder();
        }

        [Then(@"Ordered successfully")]
        public void OrderSuccess()
        {
            var ordersuccess = _commandsHandler.OrdedSuccess();
            ordersuccess.Should().Be(true);
        }
    }
}
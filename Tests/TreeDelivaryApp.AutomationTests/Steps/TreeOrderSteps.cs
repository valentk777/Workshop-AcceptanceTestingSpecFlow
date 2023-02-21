using TechTalk.SpecFlow;
using TreeDelivaryApp.AutomationTests;

namespace TreeDelivaryApp.Tests.Steps
{
    [Binding]
    public class GetTreeSteps 
    {
        [Given(@"enter valid tree name (.*)")]
        public void GivenValidTreeName(string treeName) 
        {
            // this is just testing if application service works. need to rewrite ti use hooks 
            var uiHandler = new UICommandsHandler();
            uiHandler.OpenApplication();
            uiHandler.NavigateToHomePage();
            uiHandler.NavigateToTreesPage();
            uiHandler.NavigateToOrdersPage();
            uiHandler.NavigateToHomePage();
            uiHandler.FillOrderInfo("test1", 5, "test3");
            uiHandler.Dispose();
        }

        [When(@"press the button (.*)")]
        public void WhenMakeOrderButtonIsPressed(string buttonName)
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"ordered successfully")]
        public void OrderSuccess()
        {
            ScenarioContext.StepIsPending();
        }

        [Given(@"enter invalid tree name (.*)")]
        public void GivenInvalidTreeName(string treeName)
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"order fails")]
        public void OrderFail()
        {
            ScenarioContext.StepIsPending();
        }
    }
}
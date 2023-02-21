
using TechTalk.SpecFlow;

namespace TreeDelivaryApp.Tests.Steps 
{
    [Binding]
    public class GetTreeSteps 
    {
        [Given(@"enter valid tree name (.*)")]
        public void GivenValidTreeName(string treeName) 
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"press the button (.*)")]
        public void WhenMakeOrderButtonIsPressed(string buttonName)
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"ordered succesfully")]
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
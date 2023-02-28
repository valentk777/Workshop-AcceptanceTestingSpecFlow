using TechTalk.SpecFlow;


namespace TreeDelivaryApp.AutomationTests.Hooks
{
    [Binding]
    public class TreeDeliveryAppHooks
    {
        private UICommandsHandler _commandsHandler;
        public TreeDeliveryAppHooks(UICommandsHandler commandsHandler) 
        {
            _commandsHandler = commandsHandler;
        }
        
        [BeforeScenario(Order = 0)]
        public void StartScenario()
        {
            _commandsHandler.OpenApplication();
        }

        [BeforeScenario(Order = 1)]
        public void DoSomething() 
        {
            Console.WriteLine("Hello");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _commandsHandler.Dispose();
        }
    }
}

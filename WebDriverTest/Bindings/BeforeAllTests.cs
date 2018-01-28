using BoDi;
using TechTalk.SpecFlow;
using WebDriver.Specflow.Helpers;

namespace WebDriver.Specflow.Bindings
{
    [Binding]
    public sealed class BeforeAllTests
    {
        private readonly IObjectContainer _objectContainer;
        private SeleniumContext SeleniumContext { get; set; }

        public BeforeAllTests(IObjectContainer container)
        {
            _objectContainer = container;
        }

        [BeforeScenario]
        public void RunBeforeScenario()
        {
            SeleniumContext = new SeleniumContext();
            _objectContainer?.RegisterInstanceAs(SeleniumContext);
        }
    }
}

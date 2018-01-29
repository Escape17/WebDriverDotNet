using TechTalk.SpecFlow;
using WebDriver.Specflow.Helpers;

namespace WebDriver.Specflow.Bindings
{
    [Binding]
    public sealed class CleanUpSteps
    {
        private SeleniumContext SeleniumContext { get; }

        public CleanUpSteps(SeleniumContext seleniumContext)
        {
            this.SeleniumContext = seleniumContext;
        }

        [AfterScenario]
        public void CleanUp()
        {
            SeleniumContext.WebDriver.Quit();
        }
    }
}

using TechTalk.SpecFlow;
using WebDriver.Specflow.Helpers;

namespace WebDriver.Specflow.Bindings
{
    [Binding]
    public sealed class GoogleSearchSteps
    {
        private readonly SeleniumContext seleniumContext;

        public GoogleSearchSteps(SeleniumContext seleniumContext)
        {
            this.seleniumContext = seleniumContext;
        }

        [Given(@"I am on the Google search page")]
        public void GivenIAmOnTheGoogleSearchPage()
        {
            seleniumContext.WebDriver.Navigate().GoToUrl(seleniumContext.Setup.BaseUrl);
        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the page title should include the word '(.*)'")]
        public void ThenThePageTitleShouldIncludeTheWord(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}

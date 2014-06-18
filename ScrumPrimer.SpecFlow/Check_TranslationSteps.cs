using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using FluentAutomation;

namespace ScrumPrimer.SpecFlow
{
    [Binding]
    public class Check_TranslationSteps : FluentTest
    {
        public Check_TranslationSteps()
        {
            SeleniumWebDriver.Bootstrap( SeleniumWebDriver.Browser.Chrome);
        }

        private string baseURL;

        [BeforeScenario]
        public void BeforeScenario()
        {
            baseURL = "http://scrumprimer.org";
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            I.Open(baseURL);
        }

        [When(@"I go to scrum primer overview translation page")]
        public void WhenIGoToScrumPrimerOverviewTranslationPage()
        {
            I.Assert.Exists("#navTranslations");
            I.Click("a[href='/translations']");
        }

        [Then(@"I will see scrum primer overview in '(.*)'")]
        public void ThenIWillSeeScrumPrimerOverviewIn(string language)
        {
            Assert.AreEqual("http://scrumprimer.org/overview/" + language + "_scrum_overview.png", I.Find("img[id='overview_translated']").Element.Attributes.Get("src"));
        }
    }
}
using Xunit;

namespace AutomatedTests.Config
{
    [CollectionDefinition(nameof(AutomatedWebFixtureCollection))]
    public class AutomatedWebFixtureCollection : ICollectionFixture<AutomatedWebTestsFixture> { }

    public class AutomatedWebTestsFixture
    {
        public SeleniumHelper BrowserHelper;
        public readonly ConfigurationHelper Configuration;

        public AutomatedWebTestsFixture()
        {
            Configuration = new ConfigurationHelper();
            BrowserHelper = new SeleniumHelper(Browser.Chrome, Configuration, false);
        }
    }
}

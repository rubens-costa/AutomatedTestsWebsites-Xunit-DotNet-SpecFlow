using AutomatedTests.Config;
using TechTalk.SpecFlow;
using Xunit;

namespace AutomatedTests.Website.User_Login
{
    [Binding]
    [Collection(nameof(AutomatedWebFixtureCollection))]
    public class UserLoginStepDefinitions
    {
        private readonly AutomatedWebTestsFixture _fixture;
        private readonly WebsiteBase _websiteBase;

        public UserLoginStepDefinitions(AutomatedWebTestsFixture fixture)
        {
            _fixture = fixture;
            _websiteBase = new WebsiteBase(_fixture.BrowserHelper);
        }
        [Given(@"Que o usuário acesse o Website")]
        public void GivenAccessWemobi()
        {
            _websiteBase.AccessWebsite();
        }

        [Given(@"Ele clicar em Entrar")]
        public void GivenClickEnterButton()
        {
            _websiteBase.ClickMainButton();
        }

        [Given(@"Preencher o login")]
        public void GivenWriteLoginForm()
        {
            _websiteBase.WriteLoginForm();
        }

        [When(@"Clicar no botão Entrar")]
        public void WhenClickLoginButton()
        {
            _websiteBase.ClickLoginButton();
        }

        [Then(@"Ele será redirecionado para a homepage")]
        public void ThenRedirectedToHomepage()
        {
            _websiteBase.QuitPageLogin();
        }
    }
}

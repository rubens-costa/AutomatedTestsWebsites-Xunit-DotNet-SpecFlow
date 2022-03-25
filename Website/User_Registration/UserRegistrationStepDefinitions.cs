using AutomatedTests.Config;
using TechTalk.SpecFlow;
using Xunit;

namespace AutomatedTests.Website.User_Registration
{
    [Binding]
    [Collection(nameof(AutomatedWebFixtureCollection))]
    public class UserRegistrationStepDefinitions
    {
        private readonly AutomatedWebTestsFixture _fixture;
        private readonly WebsiteBase _websiteBase;
        private readonly UserRegistrationBase _userRegistrationBase;

        public UserRegistrationStepDefinitions(AutomatedWebTestsFixture fixture)
        {
            _fixture = fixture;
            _websiteBase = new WebsiteBase(_fixture.BrowserHelper);
            _userRegistrationBase = new UserRegistrationBase(_fixture.BrowserHelper);
        }
        [Given(@"Que o usuário acesse o site sistema Wemobi")]
        public void GivenAccessWemobi()
        {
            _websiteBase.AccessWebsite();
        }

        [Given(@"Clicar no botão Entrar")]
        public void GivenClickEnterButton()
        {
            _websiteBase.ClickMainButton();
        }

        [Given(@"Clica no Link Cadastre-se")]
        public void GivenClickLinkRegister()
        {
            _userRegistrationBase.ClickLinkRegister();
        }

        [When(@"Preencher primeiro formulário do cadastro")]
        public void GivenWriteRegistrationForm1()
        {
            _userRegistrationBase.WriteRegistrationForm1();
        }

        [When(@"Clicar no botão Próximo Passo")]
        public void GivenClickNextStep1()
        {
            _userRegistrationBase.ClickNextStep1();
        }

        [When(@"Preencher segundo formulário do cadastro")]
        public void GivenWriteRegistrationForm2()
        {
            _userRegistrationBase.WriteRegistrationForm2();
        }

        [Then(@"Clicar no botão Finalizar Cadastro")]
        public void GivenClickFinishButton()
        {
            _userRegistrationBase.ClickFinishButton();
        }
    }
}

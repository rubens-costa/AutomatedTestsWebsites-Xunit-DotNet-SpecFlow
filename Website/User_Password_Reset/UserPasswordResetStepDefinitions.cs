using AutomatedTests.Config;
using TechTalk.SpecFlow;
using Xunit;

namespace AutomatedTests.Website.User_Password_Reset

{
    [Binding]
    [Collection(nameof(AutomatedWebFixtureCollection))]
    public class UserPasswordResetStepDefinitions
    {
        private readonly AutomatedWebTestsFixture _fixture;
        private readonly WebsiteBase _websiteBase;
        private readonly UserPasswordResetBase _userPasswordResetBase;

        public UserPasswordResetStepDefinitions(AutomatedWebTestsFixture fixture)
        {
            _fixture = fixture;
            _websiteBase = new WebsiteBase(_fixture.BrowserHelper);
            _userPasswordResetBase = new UserPasswordResetBase(_fixture.BrowserHelper);
        }
        [Given(@"O usuário acesse o Website")]
        public void GivenAccessWemobi()
        {
            _websiteBase.AccessWebsite();
        }

        [Given(@"Clica em Entrar")]
        public void GivenClickEnterButton()
        {
            _websiteBase.ClickMainButton();
        }

        [Given(@"Clica em link esqueci minha senha")]
        public void GivenClickPasswordResetLink()
        {
            _userPasswordResetBase.ClickPasswordResetLink();
        }

        [Given(@"Sistema direciona para o formulário")]
        public void GivenWritePasswordResetForm()
        {
            _userPasswordResetBase.WritePasswordResetForm();
        }

        [Given(@"Usuário preenche campos e clica em botão Enviar")]
        public void GivenClickSendButton()
        {
            _userPasswordResetBase.ClickSendButton();
        }

        [Then(@"Sistema envia a nova senha com sucesso")]
        public void ThenSystemSendsNewPasswordSuccessfully()
        {
            _userPasswordResetBase.QuitPageReset();
        }
    }
}

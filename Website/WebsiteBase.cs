using AutomatedTests.Config;
using System.Threading;

namespace AutomatedTests.Website
{
    public class WebsiteBase : PageObjectModel
    {
        public WebsiteBase(SeleniumHelper helper) : base(helper)
        {
        }

        //Access Website
        public void AccessWebsite()
        {
            Helper.IrParaUrl(Helper.Configuration.DomainUrl);
        }

        //Main button
        public void ClickMainButton()
        {
            Helper.ClicarBotaoPorId("");
        }

        //User Login
        public void WriteLoginForm()
        {
            Helper.PreencherTextBoxPorId("", "");
            Helper.PreencherTextBoxPorId("", "");
        }
        public void ClickLoginButton()
        {
            var botao = Helper.ObterElementoPorClasse("");
            botao.Click();
            Thread.Sleep(1000);
        }

        //Quit
        public void QuitPageLogin()
        {
            Thread.Sleep(2000);
            Helper.Quit();
        }

        //Login Reusing 
        public void login()
        {
            AccessWebsite();
            ClickMainButton();
            WriteLoginForm();
            ClickLoginButton();
        }
    }
}

using AutomatedTests.Config;
using System.Threading;

namespace AutomatedTests.Website.User_Password_Reset
{
    public class UserPasswordResetBase : PageObjectModel
    {
        public UserPasswordResetBase(SeleniumHelper helper) : base(helper)
        {
        }
        public void ClickPasswordResetLink()
        {
            Helper.ClicarPorXPath("");
        }
        public void WritePasswordResetForm()
        {
            Helper.PreencherTextBoxPorId("", "");
        }
        public void ClickSendButton()
        {
            var botao = Helper.ObterElementoPorClasse("");
            botao.Click();
        }
        public void QuitPageReset()
        {
            Thread.Sleep(2000);
            Helper.Quit();
        }
    }
}

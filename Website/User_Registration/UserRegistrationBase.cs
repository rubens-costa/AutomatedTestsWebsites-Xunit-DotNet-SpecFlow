using AutomatedTests.Config;
using OpenQA.Selenium;
using System.Threading;

namespace AutomatedTests.Website.User_Registration
{
    public class UserRegistrationBase : PageObjectModel
    {
        public UserRegistrationBase(SeleniumHelper helper) : base(helper)
        {
        }
        public void ClickLinkRegister()
        {
            Helper.ClicarPorXPath("");
        }
        public void WriteRegistrationForm1()
        {
            Helper.PreencherTextBoxPorId("", "");
            Helper.PreencherTextBoxPorId("", "");
            Helper.PreencherTextBoxPorId("", "");
            Helper.PreencherTextBoxPorId("", "");
            Thread.Sleep(1000);
            Helper.ApertarBotaoTeclado("", Keys.Enter);
        }
        public void ClickNextStep1()
        {
            Helper.ClicarPorXPath("");
        }
        public void WriteRegistrationForm2()
        {
            Helper.PreencherTextBoxPorId("", "");
            Helper.ClicarPorXPath("");
            Helper.ClicarBotaoPorId("");
            Helper.PreencherTextBoxPorId("", "");
            Helper.PreencherTextBoxPorId("", "");
            Helper.PreencherTextBoxPorId("", "");
            Helper.PreencherTextBoxPorId("", "");
        }
        public void ClickFinishButton()
        {
            Helper.ClicarBotaoPorId("");
        }
    }
}

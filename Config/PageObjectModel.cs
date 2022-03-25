using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests.Config
{
    public abstract class PageObjectModel
    {
        protected readonly SeleniumHelper Helper;
        protected PageObjectModel(SeleniumHelper helper)
        {
            Helper = helper;
        }
        public string ObterUrl()
        {
            return Helper.ObterUrl();
        }
        public void NavegarParaUrl(string url)
        {
            Helper.IrParaUrl(url);
        }
    }
}

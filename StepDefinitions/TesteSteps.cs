using config;
using TechTalk.SpecFlow;

namespace Login.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [When(@"Clica em link para download")]
        public void EncontrarElemento()
        {
            Home home = new Home();
            home.clicaEmDownload();
        }

        [Then(@"Valida a pagina de download")]
        public void ValidaPagina()
        {
            Downloads downloads = new Downloads();
            downloads.validaTituloPagina();
        }
    }
}

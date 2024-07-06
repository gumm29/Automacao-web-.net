using TechTalk.SpecFlow;
using OpenQA.Selenium;
using config;

[Binding]
public class Hooks
{
    Configuracao config = new Configuracao();
    [BeforeScenario]
    public void Before(ScenarioContext scenarioContext)
    {
        config.abrirSite();
    }

    [AfterScenario]
    public void Afetr(ScenarioContext scenarioContext)
    {
        config.fecharNavegador();
    }
}
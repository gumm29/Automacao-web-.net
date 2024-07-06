using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace config
{
    public class Configuracao
    {
        public static IWebDriver driver;
        public void abrirSite()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://selenium.dev");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        public void fecharNavegador()
        {
            driver.Quit();
        }
    }
}
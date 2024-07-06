using config;
using OpenQA.Selenium;
public class Home
{
    IWebDriver driver = Configuracao.driver;
    public void clicaEmDownload()
    {
        IList < IWebElement > elementos = driver.FindElements(By.TagName("div"));
        elementos[0].Click();
    }
}
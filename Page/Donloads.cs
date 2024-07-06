using config;
using OpenQA.Selenium;
using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
public class Downloads
{
    IWebDriver driver = Configuracao.driver;
    public void validaTituloPagina()
    {
        string texto = driver.FindElement(By.ClassName("d-1")).Text;
        Debug.Assert(texto.Equals("Downloads"), "Nao sao iguais");
    }
}
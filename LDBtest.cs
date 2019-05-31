using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ldb
{
    [TestFixture]
    public class LDBtest
    {
        IWebDriver driver;
        PageActions pageActions = new PageActions();
        Validations validations = new Validations();
        private bool acceptNextAlert = true;
        //public string ldbURL = "http://vpc-ldb-web-dev.software.alna.lt";
        public string ldbURL = "http://vpc-ldb-web-dev.software.alna.lt:81";
        public string latvija = "Latvija";
        public string vsaa = "Valsts sociālās apdrošināšanas aģentūra";
        public string ak = "46501110310";


        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
          
        }

        [Test]
        public void CreatSED()
        {
            pageActions.NavigateToLDB(driver, ldbURL);
            pageActions.OpenBUC02Card(driver);
            pageActions.SuvestiBucDuomenis(driver, latvija, vsaa);
            pageActions.SurastiBucAsmeni(driver, ak);
            pageActions.SukurtiBuc(driver);
            Thread.Sleep(5000);
            pageActions.CreatSedU007(driver);
            pageActions.SEDwithoutPIN(driver, latvija);
            pageActions.ESIistaiga(driver, latvija);

        }
     

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

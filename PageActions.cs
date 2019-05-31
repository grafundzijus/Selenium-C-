using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ldb
{
    class PageActions
    {
        BasicMethods basicMethod = new BasicMethods();
        Validations validations = new Validations();

        //puslapio uzkrovimas
        public void NavigateToLDB(IWebDriver driver, string ldbURL) 
        {
            
            driver.Navigate().GoToUrl(ldbURL);
         
            //validations.validateScreenByUrl(driver, ldbURL);

        }

        //pasirenkam kurti BUC02 atveji
        public void OpenBUC02Card(IWebDriver driver)
        {
            basicMethod.ClickElement(driver, PageObjects.sukurtiAtveji);
            basicMethod.ClickElement(driver, PageObjects.buc02);
        }


        //suvedama gavejo duomenys: salis, istaiga.
        public void SuvestiBucDuomenis(IWebDriver driver, string latvija, string vsaa)
        {
            basicMethod.ClickElement(driver, PageObjects.gavejoSalis);
            basicMethod.SelectElement(driver, PageObjects.gavejoSalis, latvija);
            basicMethod.SelectElement(driver, PageObjects.gavejas, vsaa);
        }

        //surandamas asmuo pagal asmens koda
        public void SurastiBucAsmeni(IWebDriver driver, string ak)
        {
            basicMethod.SendKeys(driver, PageObjects.personPIN, ak);
            basicMethod.ClickElement(driver, PageObjects.surastiMygtukas);
        }

        //paspaudziamas saugoti Atveji mygtukas
        public void SukurtiBuc(IWebDriver driver)
        {
            basicMethod.ClickElement(driver, PageObjects.saugotiBUC);
            validations.ValidateElementIsPresent(driver, PageObjects.saugotiBUC);
        }

        //pasirenkama atvejyje kurti SED U007
        public void CreatSedU007(IWebDriver driver)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(PageObjects.selectorSED)).Perform();
            builder.MoveToElement(driver.FindElement(PageObjects.u007)).Click().Perform();
            
        }

        //SED kurimas be PIN
        public void SEDwithoutPIN(IWebDriver driver, string latvija)
        {
            basicMethod.ClickElement(driver, PageObjects.bePIN);
            basicMethod.SendKeys(driver, PageObjects.gimimoMiestas7, "Vilnius");
            basicMethod.SelectElement(driver, PageObjects.gimimoSalis7, latvija);
        }

        //EESSI klasifikatoriaus istaiga
        public void ESIistaiga(IWebDriver driver, string latvija)
        {
            basicMethod.ClickElement(driver, PageObjects.eessiKlasifikatorius7);
            basicMethod.SelectElement(driver, PageObjects.eessiKlasSalis, latvija);
            basicMethod.ClickElement(driver, PageObjects.saugotiSED);

        }

        
    }
}

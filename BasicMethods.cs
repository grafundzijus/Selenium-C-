using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace ldb
{
    class BasicMethods
    {
        public void ClickElement(IWebDriver driver, By element)
        {
            
            driver.FindElement(element).Click();
        }

        public void SendKeys(IWebDriver driver, By element, string keys)
        {
            driver.FindElement(element).SendKeys(keys);
        }

       public void SelectElement(IWebDriver driver, By element, string text)
        {
            new SelectElement(driver.FindElement(element)).SelectByText(text);
        }

        public void SelectElementValue(IWebDriver driver, By element, string text)
        {
             new SelectElement(driver.FindElement(element)).SelectByValue(text);
        }

       public void SubmitElement(IWebDriver driver, By element)
        {
             driver.FindElement(element).Submit();
        }
    }
}


using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ldb
{
    class Validations
    {
        public void ValidateScreenByUrl(IWebDriver driver, string screenUrl)
        {
            string currentURL = driver.Url;
            Assert.IsTrue(currentURL.Equals(screenUrl));
        }

        public void ValidateElementIsPresent(IWebDriver driver, By element)
        {
            IWebElement findElement = driver.FindElement(element);
            Assert.IsTrue(findElement.Displayed);
        }

        public void ValidateTextInElement(IWebDriver driver, By element, string text)
        {
            string findElement = driver.FindElement(element).Text;
            Assert.IsTrue(findElement.Equals(text));
        }
    }
}

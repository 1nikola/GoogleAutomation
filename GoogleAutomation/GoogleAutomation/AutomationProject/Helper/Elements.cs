using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationProject.Helper
{
    public class Elements
    {

        public bool CheckElementsDisplayed(IWebDriver driver, string locator)
        {
            try
            {
              return driver.FindElement(By.XPath(locator)).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        public void CheckElementsLabel(IWebDriver driver, string locator, int caseSwitch, string expLabel)
        {
            switch (caseSwitch)
            {
                case 1:
                    IWebElement gLabel1 = driver.FindElement(By.XPath(locator));
                    string actLabel1 = gLabel1.GetAttribute("aria-label");
                    Assert.AreEqual(actLabel1, expLabel);
                    break;
                case 2:
                    IWebElement gLabel2 = driver.FindElement(By.XPath(locator));
                    string actLabel2 = gLabel2.Text;
                    Assert.AreEqual(actLabel2, expLabel);
                    break;
             
            }

            
        }

    }

}

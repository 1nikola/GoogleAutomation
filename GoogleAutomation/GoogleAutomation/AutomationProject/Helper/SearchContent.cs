using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationProject
{
   public class SearchContent
    {
        public void SearchText(IWebDriver driver, string searchFieldLoc, string searchBtnClickLoc, string searchFirstResultBtn)
        {
            IWebElement searchField = driver.FindElement(By.XPath(searchFieldLoc));
            searchField.SendKeys("ShowingTime");
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement searchClick = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(searchBtnClickLoc)));
            searchClick.Click();

            var firstElement = driver.FindElement(By.XPath(searchFirstResultBtn)).Text.ToString();
            var expected = "https://www.showingtime.com/";
            Assert.AreEqual(firstElement, expected);
        }
    }
}

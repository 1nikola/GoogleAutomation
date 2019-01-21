using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationProject.Helper
{
  public class Account
  {
        ConfigVariables configV;

        public Account()
        {
            configV = new ConfigVariables();
                      
        }

        private bool IsElementPresent(By by, IWebDriver driver)
        {
            try
            {                
                Thread.Sleep(5000);
                bool isElementDisplayed = driver.FindElement(by).Displayed;

                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        public void LoginToGmail(IWebDriver driver, string signInBtnLoc, string signInUsrLoc, string signInNextLoc,
          string signInPassLoc, string signInNextAgainLoc, string profile, string wrongPassLoc)
        {
            
            IWebElement signInBtn = driver.FindElement(By.Id(signInBtnLoc));
            signInBtn.Click();

            IWebElement username = driver.FindElement(By.Id(signInUsrLoc));
            username.SendKeys(configV.username.ToString());

            IWebElement clickOnNext = driver.FindElement(By.Id(signInNextLoc));
            clickOnNext.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement password = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(signInPassLoc)));
            password.Click();
            password.Clear();
            password.SendKeys(configV.password.ToString());

            IWebElement clickOnNextAgain = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(signInNextAgainLoc)));
            clickOnNextAgain.Click();

          
            if (IsElementPresent(By.XPath(wrongPassLoc), driver))
            {
                throw new Exception("Failed to login to Account with password: " +
                                    new { configV.password });
            }

         
            
            IWebElement userProfile = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(profile)));

            bool loginStatus = driver.FindElement(By.XPath(profile)).Displayed;

            if (loginStatus == false)
            {
                throw new Exception("Failed to login to Account with username: " +
                                    new { configV.username, configV.password });
            }

        }

    }
}

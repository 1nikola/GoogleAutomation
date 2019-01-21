using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AutomationProject.Helper;
using Microsoft.VisualStudio.TestTools.UITest.Common.UIMap;
using OpenQA.Selenium.Support.UI;


namespace AutomationProject
{

    [TestClass]
    public class ProgramGoogle : SetUp
    {

        public ConfigVariables configV;
        Locators locators;


        public ProgramGoogle()
        {
            configV = new ConfigVariables();           
            locators = new Locators();

        }

        public static class WebDriverExtensions
        {
            public static IWebElement FindElement(IWebDriver driver, By by, int timeoutInSeconds)
            {
                if (timeoutInSeconds > 0)
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                    return wait.Until(drv => drv.FindElement(by));
                }
                return driver.FindElement(by);
            }
        }

        public bool IsElementVisible(IWebElement element)
        {
            return element != null && element.Displayed && element.Enabled;

        }

      
        public void LaunchBrowser()
        {
            chromedriver.Navigate().GoToUrl(configV.Url());
      
        }


        [TestMethod]
        public void GoogleElementsPage()
        {
            LaunchBrowser();
            Elements elements = new Elements();
            elements.CheckElementsDisplayed(chromedriver, locators.btnGoogleSearch);
            elements.CheckElementsDisplayed(chromedriver, locators.btnGoogleFirstHand);
            elements.CheckElementsDisplayed(chromedriver, locators.searchFieldArea);
            elements.CheckElementsDisplayed(chromedriver, locators.googleLogo);
            elements.CheckElementsDisplayed(chromedriver, locators.googleVoice);
            elements.CheckElementsDisplayed(chromedriver, locators.gmail);
            elements.CheckElementsDisplayed(chromedriver, locators.images);
            elements.CheckElementsDisplayed(chromedriver, locators.googleApps);
            elements.CheckElementsDisplayed(chromedriver, locators.googleAccount);
            elements.CheckElementsDisplayed(chromedriver, locators.googleAdvertising);
            elements.CheckElementsDisplayed(chromedriver, locators.googleForBusiness);
            elements.CheckElementsDisplayed(chromedriver, locators.googleAboutLabel);
            elements.CheckElementsDisplayed(chromedriver, locators.privacy);
            elements.CheckElementsDisplayed(chromedriver, locators.terms);
            elements.CheckElementsDisplayed(chromedriver, locators.settings);
            elements.CheckElementsDisplayed(chromedriver, locators.googlLangOffer);
            elements.CheckElementsDisplayed(chromedriver, locators.googleLanguage);
            elements.CheckElementsDisplayed(chromedriver, locators.countryName);

        }

        [TestMethod]
        public void GoogleElementsLabel()
        {
            LaunchBrowser();
            Elements elements = new Elements();
            elements.CheckElementsLabel(chromedriver, locators.btnGoogleSearch, 1, locators.btnGoogleSearchLabel);
            elements.CheckElementsLabel(chromedriver, locators.btnGoogleFirstHand, 1, locators.btnGoogleFirstHandLabel);
            elements.CheckElementsLabel(chromedriver, locators.gmail, 2, locators.gmailLabel);
            elements.CheckElementsLabel(chromedriver, locators.images, 2, locators.imagesLabel);
            elements.CheckElementsLabel(chromedriver, locators.googleAccount, 2, locators.googleAccountLabel);
            elements.CheckElementsLabel(chromedriver, locators.googleAdvertising, 2, locators.googleAdvertisingLabel);
            elements.CheckElementsLabel(chromedriver, locators.googleForBusiness, 2, locators.googleForBussinesLabel);
            elements.CheckElementsLabel(chromedriver, locators.googleAbout, 2, locators.googleAboutLabel);
            elements.CheckElementsLabel(chromedriver, locators.privacy, 2, locators.privacyLabel);
            elements.CheckElementsLabel(chromedriver, locators.terms, 2, locators.termsLabel);
            elements.CheckElementsLabel(chromedriver, locators.settings, 2, locators.settingsLabel);
            elements.CheckElementsLabel(chromedriver, locators.googlLangOffer, 2, locators.googlLangOfferLabel);
            elements.CheckElementsLabel(chromedriver, locators.googleLanguage, 2, locators.googleLanguageLabel);
            elements.CheckElementsLabel(chromedriver, locators.countryName, 2, locators.countryNameLabel);

        }


        [TestMethod]
        public void LoginToGmailAccount()
        {
            LaunchBrowser();
            Account account = new Account();
            account.LoginToGmail(chromedriver, locators.signInBtn,
                    locators.signInUsr, locators.clickOnNext, locators.signInPass, locators.clickOnNextAgain, locators.profile, locators.wrongPass);

        }
 

        [TestMethod]
        public void SearchContent()
        {
            LaunchBrowser();
            SearchContent searchContent = new SearchContent();
            searchContent.SearchText(chromedriver, locators.searchField, locators.searchBtnClick, locators.searchFirstResult);

        }

     
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}

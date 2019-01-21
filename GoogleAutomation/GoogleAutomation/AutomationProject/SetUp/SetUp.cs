using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AutomationProject
{
   
    public class SetUp
    {

        public static IWebDriver chromedriver;

       
        public SetUp()
        {            
            var options = new ChromeOptions();
            options.AddArguments("chrome.switches", "--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
            options.AddArgument(@"--incognito");
            options.AddArguments("--proxy-server='direct://'");
            options.AddArgument("--proxy-bypass-list=*");
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromedriver = new ChromeDriver(@"c:\chromedriver_new", options);

        }

        [TestCleanup]
        public void TearDown()
        {
            if (chromedriver != null)
            {
                chromedriver.Quit();
            }
        }     

    }
}

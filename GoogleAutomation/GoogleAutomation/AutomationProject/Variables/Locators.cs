
namespace AutomationProject
{
   public class Locators
   {

       //locators for google elements
       public string btnGoogleSearch = "//*[@id='tsf']//div[@class='FPdoLc VlcLAe']//input[1]";
       public string btnGoogleFirstHand = "//*[@id='tsf']//div[@class='FPdoLc VlcLAe']//input[2]";
       public string searchFieldArea = "//*[@id='tsf']/div[2]//div[1]/input";
       public string googleLogo = "//*[@id='hplogo']";
       public string googleVoice = "//*[@id='tsf']//div[2]/div[1]/span";
       public string gmail = "//*[@id='gb']//div[@class='gb_Q gb_R'][1]/a[@class='gb_P']";
       public string images = "//*[@id='gb']//div[@class='gb_Q gb_R'][2]/a[@class='gb_P']";
       public string googleApps = "//div[@id='gbwa']";
       public string googleAccount = "//*[@id='gb_70']";
       public string googleAdvertising = "//span[@id='fsl']/a[@class='Fx4vi'][1]";
       public string googleForBusiness = "//span[@id='fsl']/a[@class='Fx4vi'][2]";
       public string googleAbout = "//span[@id='fsl']/a[@class='Fx4vi'][3]";
       public string privacy = "//span[@id='fsr']/a[@class='Fx4vi'][1]";
       public string terms = "//span[@id='fsr']/a[@class='Fx4vi'][2]";
       public string settings = "//span[@id='fsr']//a[@id='fsettl']";
       public string googlLangOffer = "//*[@id='SIvCob']";
       public string googleLanguage = "//*[@id='SIvCob']/a";
       public string profile = "//span[@class = 'gb_cb gbii']";
       public string countryName = "//*[@id='fbar']//span[@class='Q8LRLc']";


       //label values for elements
       public string btnGoogleSearchLabel = "Google Search";
       public string btnGoogleFirstHandLabel = "I'm Feeling Lucky";
       public string gmailLabel = "Gmail";
       public string imagesLabel = "Images";
       public string googleAccountLabel = "Sign in";
       public string googleAdvertisingLabel = "Advertising";
       public string googleForBussinesLabel = "Business";
       public string googleAboutLabel = "About";
       public string privacyLabel = "Privacy";
       public string termsLabel = "Terms";
       public string settingsLabel = "Settings";
       public string googlLangOfferLabel = "Google offered in: српски srpski";
       public string googleLanguageLabel = "српски";
       public string countryNameLabel = "Serbia";


       //locators for searching context
       public string searchBtnClick = "//*[@id='tsf']//div[1]/center/input[1]";
       public string searchField = "//*[@id='tsf']/div[2]//div[1]/input";
       public string searchFirstResult = "//cite[@class='iUh30']";

       //locators for sign in to gmail
       public string signInBtn = "gb_70";
       public string signInUsr = "identifierId";
       public string clickOnNext = "identifierNext";
       public string signInPass = "//input[@type='password']";
       public string clickOnNextAgain = "passwordNext";
       public string wrongPass = "//div[@class='GQ8Pzc']";
       
    }
}

using System;
using System.Configuration;


namespace AutomationProject
{
    public class ConfigVariables
    {
        public string username;
        public string password;
        public string env;

        public ConfigVariables()
        {
            env = ConfigurationManager.AppSettings["Environment"];
            Settings();
                       
        }

        public void Settings()
        {

            if (env == "Test")
            {
                username = (ConfigurationManager.AppSettings["testGmailUsername"]);
                password = (ConfigurationManager.AppSettings["testGmailPassword"]);

            }
            else if (env == "Production")
            {

                username = (ConfigurationManager.AppSettings["prodGmailUsername"]);
                password = (ConfigurationManager.AppSettings["prodGmailPassword"]);
               
            }
        }

        public string Url()
        {

            if (env == "Test")
            {
                return ConfigurationManager.AppSettings["URL"];
            }
            else if (env == "Production")
            {
                return ConfigurationManager.AppSettings["URL"];
            }
            else
            {
                return ("ConfigFileNotReadable");
            }
        }

    }
}

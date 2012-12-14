using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace NasGit.IO  {
    /// <summary>
    /// This class contains the path and some other configurations will be used for IO classes.
    /// </summary>
    public static class IO_Config {

        public static string GIT_EXE_PATH = ""; 

        public static RepositoryConfigCollection GetAllRepositoriesConfig(){
            //get the current config from app.config file
            GitConfigurationSection config = (GitConfigurationSection)ConfigurationManager.GetSection("testConfig.repositoryList");
            return config.RepositoryList;
            /*
             *How to use:
            Console.WriteLine(config.RepositoryList.Count + " repository settings are found :");
            foreach (RepositoryConfigElement e in config.RepositoryList) {
                Console.WriteLine(e.Name + ";" + e.LocalPath + ";" + e.RemoteURL + ";" + e.UserName + ";" + e.Password);
            }*/
        }
        public static void AddRepositoryConfig(RepositoryConfigElement element) {
            // Open App.Config of executable inorder to insert or update the data
            System.Configuration.Configuration configExc =
              ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            GitConfigurationSection sectoin = (GitConfigurationSection)configExc.GetSection("testConfig.repositoryList");
            sectoin.RepositoryList.Add(element);
            // Save the configuration file.
            configExc.Save(ConfigurationSaveMode.Full);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("testConfig.repositoryList");
            /*
             //check if the eNew is added
            config = (GitConfigurationSection)ConfigurationManager.GetSection("testConfig.repositoryList");
            Console.WriteLine("after insert action, "+config.RepositoryList.Count + " repository settings are found :");
            foreach (RepositoryConfigElement e in config.RepositoryList) {
                Console.WriteLine(e.Name + ";" + e.LocalPath + ";" + e.RemoteURL + ";" + e.UserName + ";" + e.Password);
            }
             */
        }
    }
}

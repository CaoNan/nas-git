using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace NasGit.IO {

    public class GitConfigurationSection : ConfigurationSection {
        // Create a list
        [ConfigurationProperty("", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(RepositoryConfigCollection), AddItemName = "repositoryConfigList")]
        public RepositoryConfigCollection RepositoryList {
            get {
                return (RepositoryConfigCollection)base[""];
            }
        }
    }
}

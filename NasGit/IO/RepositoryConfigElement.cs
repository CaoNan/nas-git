using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace NasGit.IO {
   public class RepositoryConfigElement : ConfigurationElement {
        [ConfigurationProperty("name", IsRequired = true)]
        public String Name {
            get { return (String)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("localPath", IsRequired = true)]
        public String LocalPath {
            get { return (String)this["localPath"]; }
            set { this["localPath"] = value; }
        }

        [ConfigurationProperty("remoteURL")]
        public String RemoteURL {
            get { return (String)this["remoteURL"]; }
            set { this["remoteURL"] = value; }
        }

        [ConfigurationProperty("userName")]
        public String UserName {
            get { return (String)this["userName"]; }
            set { this["userName"] = value; }
        }

        [ConfigurationProperty("password")]
        public String Password {
            get { return (String)this["password"]; }
            set { this["password"] = value; }
        }
    }
}

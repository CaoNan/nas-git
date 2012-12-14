using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace NasGit.IO {
   public class RepositoryConfigCollection : ConfigurationElementCollection {
       protected override ConfigurationElement CreateNewElement() {
           return new RepositoryConfigElement();
       }
       protected override object GetElementKey(ConfigurationElement element) {
           return ((RepositoryConfigElement)element).Name;
       }

       public override ConfigurationElementCollectionType CollectionType {
           get {
               return ConfigurationElementCollectionType.BasicMap;
           }
       }
       protected override string ElementName {
           get {
               return "repositoryConfig";
           }
       }
       protected override void BaseAdd(ConfigurationElement element) {
           base.BaseAdd(element);
       }
       public void Add(RepositoryConfigElement element) {
           this.BaseAdd(element);
       }

       public RepositoryConfigElement this[int index] {
           get {
               return (RepositoryConfigElement)BaseGet(index);
           }
           set {
               if (BaseGet(index) != null) {
                   BaseRemoveAt(index);
               }
               BaseAdd(index, value);
           }
       }
    }
}

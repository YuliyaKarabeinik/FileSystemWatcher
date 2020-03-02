using System.Configuration;
using ConfigurationSectionSample.Configuration;

namespace FileSystemWatcher.Configuration
{
    public class CustomConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("appName")]
        public string ApplicationName => (string)base["appName"];

        [ConfigurationProperty("culture")]
        public CultureElement Culture => (CultureElement)this["culture"];

        [ConfigurationCollection(typeof(FolderElement),
            AddItemName = "folder",
            ClearItemsName = "clear",
            RemoveItemName = "del")]
        [ConfigurationProperty("folders")]
        public FolderElementCollection Folders => (FolderElementCollection)this["folders"];

        [ConfigurationCollection(typeof(RuleElement),
            AddItemName = "rule",
            ClearItemsName = "clear",
            RemoveItemName = "del")]
        [ConfigurationProperty("rules")]
        public RuleElementCollection Rules => (RuleElementCollection)this["rules"];
    }
}

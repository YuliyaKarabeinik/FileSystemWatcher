using System.Configuration;

namespace ConfigurationSectionSample.Configuration
{
    public class CustomConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("appName")]
        public string ApplicationName => (string)base["appName"];

        [ConfigurationProperty("workTime")]
        public WorkTimeElement WorkTime => (WorkTimeElement)this["workTime"];

        [ConfigurationProperty("culture")]
        public CultureElement Culture => (CultureElement)this["culture"];

        [ConfigurationCollection(typeof(FileElement),
            AddItemName = "file", 
            ClearItemsName = "clear",
            RemoveItemName = "del")]
        [ConfigurationProperty("files")]
        public FileElementCollection Files => (FileElementCollection)this["files"];

        [ConfigurationCollection(typeof(FolderElement),
            AddItemName = "folder",
            ClearItemsName = "clear",
            RemoveItemName = "del")]
        [ConfigurationProperty("folders")]
        public FolderElementCollection Folders => (FolderElementCollection)this["folders"];
    }
}

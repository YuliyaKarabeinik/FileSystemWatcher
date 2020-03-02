using System.Configuration;

namespace FileSystemWatcher.Configuration.Folders
{
    public class FolderElement : ConfigurationElement
    {
        [ConfigurationProperty("path", IsKey = true, IsRequired = true)]
        public string FolderPath => (string)base["path"];
    }
}

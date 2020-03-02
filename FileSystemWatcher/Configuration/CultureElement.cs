using System.Configuration;

namespace FileSystemWatcher.Configuration
{
    public class CultureElement : ConfigurationElement
    {
        [ConfigurationProperty("name")]
        public string Name => this["name"].ToString();
    }
}

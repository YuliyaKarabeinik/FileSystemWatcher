using System.Configuration;

namespace ConfigurationSectionSample.Configuration
{
    public class CultureElement : ConfigurationElement
    {
        [ConfigurationProperty("name")]
        public string Name => this["name"].ToString();
    }
}

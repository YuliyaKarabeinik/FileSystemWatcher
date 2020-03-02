using System.Configuration;

namespace ConfigurationSectionSample.Configuration
{
    public class FileElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string FileName
        {
            get { return (string)base["name"]; }
        }

        [ConfigurationProperty("size", IsRequired = false, DefaultValue = 0)]
        [IntegerValidator(MinValue = 0, MaxValue = 1000000)]
        public int FileSize
        {
            get { return (int)base["size"]; }
            set { this["size"] = value; }
        }
    }
}

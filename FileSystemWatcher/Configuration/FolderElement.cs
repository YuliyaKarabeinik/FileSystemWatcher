using System.Configuration;

namespace FileSystemWatcher.Configuration
{
    public class FolderElement : ConfigurationElement
    {
        [ConfigurationProperty("path", IsKey = true, IsRequired = true)]
        public string FolderPath => (string)base["path"];

        //[ConfigurationProperty("size", IsRequired = false, DefaultValue = 0)]
        //[IntegerValidator(MinValue = 0, MaxValue = 1000000)]
        //public int FileSize
        //{
        //    get { return (int)base["size"]; }
        //    set { this["size"] = value; }
        //}
    }
}

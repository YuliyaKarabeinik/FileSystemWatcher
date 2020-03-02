using System.Configuration;

namespace FileSystemWatcher.Configuration.Rules
{
    public class RuleElement : ConfigurationElement
    {
        [ConfigurationProperty("pattern", IsKey = true, IsRequired = true)]
        public string Pattern => (string)base["pattern"];

        [ConfigurationProperty("destination", IsRequired = true)]
        public string Destination => (string)base["destination"];

        [ConfigurationProperty("addIndex", DefaultValue = false)]
        public bool AddIndex => (bool)base["addIndex"];

        [ConfigurationProperty("addDate", DefaultValue = false)]
        public bool AddDate => (bool)base["addDate"];
    }
}

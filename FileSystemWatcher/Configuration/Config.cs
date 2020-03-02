using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace FileSystemWatcher.Configuration
{
    public static class Config
    {
        public static CustomConfigurationSection Section => (CustomConfigurationSection)
            ConfigurationManager.GetSection("simpleSection");

        public static List<string> Folders => GetFolders().ToList();

        public static List<RuleElement> Rules => GetRules().ToList();

        public static string DefaultFolder => ConfigurationManager.AppSettings["DefaultFolder"];

        public static string Culture => Section.Culture.Name;
        
        private static IEnumerable<RuleElement> GetRules()
        {
            foreach (RuleElement rule in Section.Rules)
            {
                yield return rule;
            }
        }

        private static IEnumerable<string> GetFolders()
        {
            foreach (FolderElement folder in Section.Folders)
            {
                yield return folder.FolderPath;
            }
        }
    }
}

using System.Configuration;

namespace ConfigurationSectionSample.Configuration
{
    public class FileElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new FileElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FileElement)element).FileName;
        }
    }

}

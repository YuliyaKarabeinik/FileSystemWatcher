﻿using System.Configuration;

namespace ConfigurationSectionSample.Configuration
{
    public class FolderElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new FolderElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FolderElement)element).FolderPath;
        }
    }

}

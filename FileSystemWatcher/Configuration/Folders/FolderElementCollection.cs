﻿using System.Configuration;

namespace FileSystemWatcher.Configuration.Folders
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

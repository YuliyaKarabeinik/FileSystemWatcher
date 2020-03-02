﻿using System.Configuration;

namespace FileSystemWatcher.Configuration.Rules
{
    public class RuleElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new RuleElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((RuleElement)element).Pattern;
        }
    }
}

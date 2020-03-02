using System;
using System.Configuration;

namespace ConfigurationSectionSample.Configuration
{
    public class WorkTimeElement : ConfigurationElement
    {
        [ConfigurationProperty("start")]
        public DateTime StartTime
        {
            get { return (DateTime)this["start"]; }
        }

        [ConfigurationProperty("duration")]
        public TimeSpan Duration
        {
            get { return (TimeSpan)this["duration"]; }
        }
    }
}

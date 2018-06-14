using System.Collections.Generic;
using System.Xml.Serialization;

namespace XfTemplate.AppSettings
{
    [XmlRoot(ElementName = "add")]
    public class Add
    {
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "appSettings")]
    public class AppSettings
    {
        [XmlElement(ElementName = "add")]
        public List<Add> Add { get; set; }
    }

    [XmlRoot(ElementName = "configuration")]
    public class Configuration
    {
        [XmlElement(ElementName = "appSettings")]
        public AppSettings AppSettings { get; set; }
    }

}

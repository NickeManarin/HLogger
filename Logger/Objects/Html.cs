using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Logger.Objects
{
    [Serializable]
    [XmlRoot(ElementName = "html")]
    public class Html
    {
        [XmlElement(ElementName = "head")]
        public Head Head { get; set; }

        [XmlElement(ElementName = "body")]
        public Body Body { get; set; }
    }
}

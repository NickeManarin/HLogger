using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv1.InnerDiv2;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv3.InnerDiv4;

namespace Logger.Objects.InnerBody.InnerDiv.InnerDiv3
{
    public class Div4
    {
        [XmlElement(ElementName = "a")]
        public A A { get; set; }

        [XmlElement(ElementName = "h3")]
        public string H3 { get; set; }

        [XmlElement(ElementName = "table")]
        public Table Table { get; set; }
    }
}

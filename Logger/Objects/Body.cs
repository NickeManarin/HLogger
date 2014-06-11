using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Logger.Objects.InnerBody;

namespace Logger.Objects
{
    public class Body
    {
        [XmlElement(ElementName = "h1")]
        public string H1 { get; set; }
        public bool ShouldSerializeH1()
        {
            return !string.IsNullOrEmpty(H1);
        }

        [XmlElement(ElementName = "div")]
        public Div Div { get; set; }
    }
}

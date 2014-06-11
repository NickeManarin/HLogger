using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv1;

namespace Logger.Objects.InnerBody.InnerDiv
{
    public class Div1
    {
        [XmlElement(ElementName = "h2")]
        public string H2 { get; set; }

        [XmlElement(ElementName = "div")]
        public Div2 Div2 { get; set; }
    }
}

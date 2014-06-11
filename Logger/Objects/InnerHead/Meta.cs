using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Logger.Objects.InnerHead
{
    public class Meta
    {
        [XmlAttribute(AttributeName = "content")]
        public string Content { get; set; }

        [XmlAttribute(AttributeName = "http-equiv")]
        public string HttpEquiv { get; set; }
    }
}

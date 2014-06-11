using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv1;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv3;

namespace Logger.Objects.InnerBody.InnerDiv
{
    public class Div3
    {
        [XmlElement(ElementName = "div")]
        public List<Div4> Div4 { get; set; }
    }
}

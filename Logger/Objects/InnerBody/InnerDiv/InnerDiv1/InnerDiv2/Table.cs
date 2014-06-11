using System.Collections.Generic;
using System.Xml.Serialization;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv1.InnerDiv2.InnerTable;

namespace Logger.Objects.InnerBody.InnerDiv.InnerDiv1.InnerDiv2
{
    public class Table
    {
        [XmlElement(ElementName = "tr")]
        public List<Tr> Tr { get; set; }
    }
}

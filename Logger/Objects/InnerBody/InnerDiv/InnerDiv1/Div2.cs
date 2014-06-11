using System.Xml.Serialization;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv1.InnerDiv2;

namespace Logger.Objects.InnerBody.InnerDiv.InnerDiv1
{
    public class Div2
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; } //overview

        [XmlElement(ElementName = "table")]
        public Table Table { get; set; }
    }
}

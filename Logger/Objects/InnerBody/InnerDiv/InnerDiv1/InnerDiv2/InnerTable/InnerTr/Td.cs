using System;
using System.Xml.Serialization;

namespace Logger.Objects.InnerBody.InnerDiv.InnerDiv1.InnerDiv2.InnerTable.InnerTr
{
    public class Td
    {
        public Td()
        {
            
        }

        public Td(string @class, string value = "", string style = "")
        {
            Class = @class;
            Value = value;
            Style = style;
        }

        [XmlAttribute(AttributeName = "class")]
        public string Class { get; set; } //class
        public bool ShouldSerializeClass()
        {
            return !String.IsNullOrEmpty(Class);
        }

        [XmlElement(ElementName = "value")]
        public string Value { get; set; }
        public bool ShouldSerializeValue()
        {
            return !String.IsNullOrEmpty(Value);
        }

        [XmlAttribute(AttributeName = "style")]
        public string Style { get; set; }
        public bool ShouldSerializeStyle()
        {
            return !String.IsNullOrEmpty(Style);
        }
    }
}

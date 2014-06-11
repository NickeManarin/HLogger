using System;
using System.Xml.Serialization;

namespace Logger.Objects.InnerBody.InnerDiv.InnerDiv1.InnerDiv2.InnerTable.InnerTr
{
    public class Th
    {
        public Th()
        {

        }

        public Th(string locId, string value = "", string clss = "")
        {
            Locid = locId;
            Value = value;
            Clss = clss;
        }

        [XmlAttribute(AttributeName = "class")]
        public string Clss { get; set; } //class
        public bool ShouldSerializeClss()
        {
            return !String.IsNullOrEmpty(Clss);
        }

        [XmlAttribute(AttributeName = "_locid")]
        public string Locid { get; set; } //Locid
        public bool ShouldSerializeLocid()
        {
            return !String.IsNullOrEmpty(Locid);
        }

        [XmlElement(ElementName = "value")]
        public string Value { get; set; }
        public bool ShouldSerializeValue()
        {
            return !String.IsNullOrEmpty(Value);
        }
    }
}

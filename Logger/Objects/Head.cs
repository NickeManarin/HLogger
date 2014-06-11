using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Logger.Objects.InnerHead;

namespace Logger.Objects
{
    public class Head
    {
        [XmlElement(ElementName = "meta")]
        public List<Meta> Meta { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        public bool ShouldSerializeTitle()
        {
            return !string.IsNullOrEmpty(Title);
        }

        [XmlElement(ElementName = "style")]
        public string Style { get; set; }
        public bool ShouldSerializeStyle()
        {
            return !string.IsNullOrEmpty(Style);
        }

        //type="text/javascript" language="javascript"
        //type=\"text/javascript\" language=\"javascript\"
        [XmlElement(ElementName = "script")] 
        public string Script { get; set; }
        public bool ShouldSerializeScript()
        {
            return !string.IsNullOrEmpty(Script);
        }
    }
}

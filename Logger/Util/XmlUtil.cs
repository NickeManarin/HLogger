using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Logger.Util
{
    public class XmlUtils
    {
        public static object Deserializar<T>(T obj, string xmlText)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                TextReader textReader = new StringReader(xmlText);
                return (T)deserializer.Deserialize(textReader);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static XmlDocument Serializar<T>(T obj)
        {
            string xmlString = GenXml.Generate<T>(obj);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);
            return doc;
        }

        public static string GetXmlTexto(XmlDocument doc)
        {
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);

            doc.WriteTo(xmlTextWriter);

            return stringWriter.ToString();

        }
    }
}

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Logger.Util
{
    public class GenXml
    {
        public static String Generate<T>(T obj)
        {
            XElement xml = null;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));

                using (MemoryStream memory = new MemoryStream())
                {
                    using (TextReader tr = new StreamReader(memory, Encoding.UTF8))
                    {

                        ser.Serialize(memory, obj);
                        memory.Position = 0;
                        xml = XElement.Load(tr);
                        xml.Attributes().Where(x => x.Name.LocalName.Equals("xsd") || x.Name.LocalName.Equals("xsi")).Remove();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }

            return xml.ToString();
        }
    }
}

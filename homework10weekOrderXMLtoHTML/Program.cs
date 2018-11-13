using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
class Test
{
    static void Main()
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\s.xml");

            XPathNavigator nav = doc.CreateNavigator();
            nav.MoveToRoot();

            XslCompiledTransform xt = new XslCompiledTransform();
            xt.Load(@"..\..\s.xslt");

            FileStream outFileStream = File.OpenWrite(@"..\..\s.html");
            XmlTextWriter writer =
                new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
            xt.Transform(nav, null, writer);


        }
        catch (XmlException e)
        {
            Console.WriteLine("XML Exception:" + e.ToString());
        }
        catch (XsltException e)
        {
            Console.WriteLine("XSLT Exception:" + e.ToString());
        }
    }

}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            String filename = @"c:\tmp\persons.xml";
            String content = File.ReadAllText(filename);

            XmlDocument document = new XmlDocument();
            document.LoadXml(content);

            XmlElement persons = document["persons"];
            Console.WriteLine($"Liczba elementów w persons = {persons.ChildNodes.Count} ");
            foreach (XmlElement item in persons.ChildNodes)
            {
                string lname = item.GetAttribute("lname");
                string name = item.GetAttribute("name");
                string phone = item.GetAttribute("phone");
                Console.WriteLine($"{name} {lname} - {phone}");
            }

            Console.ReadKey();
        }
    }
}

using Cw2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Cw2.Controllers
{
    public class Writer<T>
    {
        public static void WriteToFile(String path, String content)
        {
            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);
                sw.WriteLine("Generated File");
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(content);
            }
        }
/*        public static void Save(string fileName, List<T> content, string rootName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                                           new XmlRootAttribute(rootName);
                serializer.Serialize(stream, content);
            }
        }*/
    }
}

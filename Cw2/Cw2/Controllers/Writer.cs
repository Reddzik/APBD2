using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cw2.Controllers
{
    public class Writer
    {
        public static void WriteToFile(String path, string content)
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
/*        public void Save(string fileName, List<T> content)
        {
            using(var stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new 
            }
        }*/
    }
}

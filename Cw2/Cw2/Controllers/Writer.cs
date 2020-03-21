using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cw2.Controllers
{
    class Writer
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
    }
}

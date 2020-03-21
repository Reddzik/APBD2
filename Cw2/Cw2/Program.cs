using Cw2.Controllers;
using Cw2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Proejkty\APBD\zad2\APBD2\Cw2\Cw2\Data\dane.csv";
            Console.WriteLine("Hello World");
            HashSet<Student> dataSet = new HashSet<Student>(new MyComparator());
            //Wczytywanie 
            var fi = new FileInfo(path);
            using (var stream = new StreamReader(fi.OpenRead()))
            {
                string line = null;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] kolumny = line.Split(',');
                   // Console.WriteLine(kolumny[0]);
                    var student = new Student
                    {
                        Imie = kolumny[0],
                    };
                    dataSet.Add(student);
                    if (!dataSet.Add(student)){
                        Console.WriteLine("Powtórzone ======");
                        Console.WriteLine(student.Imie);

                        Console.WriteLine("Koniec powtórzenia ======");
                    }
                }
                Display(dataSet);
            }



            static void Display(HashSet<Student> hashSet)
            {
                if (hashSet.Count == 0)
                {
                    Console.WriteLine("Hashset is empty!");
                    return;
                }
                foreach (var item in hashSet)
                {
                    Console.WriteLine("{0}, ", item);
                }
                Console.WriteLine("\n");
            }
            //stream.Dispose();

            //XML
            /*            var list = new List<Student>();
                        var st = new Student
                        {
                            Imie = "Jan",
                            Nazwisko = "Kowalski",
                            Email = "kowalski@wp.pl"
                        };
                        list.Add(st);

                        FileStream writer = new FileStream(@"data.xml", FileMode.Create);
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>),
                                                   new XmlRootAttribute("uczelnia"));
                        serializer.Serialize(writer, list);
                        serializer.Serialize(writer, list);*/

        }
    }
    
}

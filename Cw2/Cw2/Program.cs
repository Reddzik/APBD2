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
                    // imie, nazwisko, kierunek studiów ,radzaj studiow, id, data, email, imie matki, imie ojca
                    string[] columns = line.Split(',');
                    if (!DataValidator<string>.checkLength(columns, 9))
                    {
                        Logger.LogToFile(line, "Zbyt mała liczba kolumn");
                        continue;
                    }
                    for (int i = 0; i < columns.Length; i++)
                    {
                        if (DataValidator<string>.checkColumnsContent(columns[i]))
                        {
                            Logger.LogToFile(line, "Wiersz niepoprawny, posiadający puste kolumny");
                            continue;
                        }
                    }
                    var student = new Student
                    {
                        Name = columns[0],
                        Surname = columns[1],
                        FiledOfStudy = columns[2],
                        SchoolMode = columns[3],
                        Id = columns[4],
                        DateOfStart = columns[5],
                        Email = columns[6],
                        MothersName = columns[7],
                        FathersName = columns[8],
                    };
                    if (!dataSet.Add(student)){
                       // Console.WriteLine("{0} Taki student już istnieje", student);
                    }
                }
                Display(dataSet);
                var list = new List<Student>(dataSet);
                FileStream writer = new FileStream(@"D:\Proejkty\APBD\Zajęcia 2\cwiczenia_notatki\Cw2\Cw2\Data\dataa.xml", FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>),
                                           new XmlRootAttribute("uczelnia"));
                serializer.Serialize(writer, list);
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
/*            serializer.Serialize(writer, list);*/

        }
    }
    
}

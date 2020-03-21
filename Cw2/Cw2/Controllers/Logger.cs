using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2.Controllers
{
    class Logger
    {
        private static string pathToLogs = @"D:\Proejkty\APBD\Zajęcia 2\cwiczenia_notatki\Cw2\Cw2\Data\Logger.txt";

        public static void LogToFile(String errorLine, string message)
        {
            string content = "Ta linia jest błędna ->" + errorLine + "\n" + " Z powodu: " + message;
            Console.WriteLine("Siema siema");
            Writer.WriteToFile(pathToLogs, content);
        }
    }
}

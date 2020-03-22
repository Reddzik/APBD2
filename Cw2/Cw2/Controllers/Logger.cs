using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2.Controllers
{
    class Logger
    {
        private static string pathToLogs = @"D:\Proejkty\APBD\zad2\APBD2\Cw2\Cw2\Data\Logger.txt";

        public static void LogToFile(String errorLine, String message)
        {
            string content = "\n"+"Ta linia jest błędna ->" + errorLine + "\n" + " Z powodu: " + message+"\n";
            Writer<Object>.WriteToFile(pathToLogs, content);
        }
    }
}

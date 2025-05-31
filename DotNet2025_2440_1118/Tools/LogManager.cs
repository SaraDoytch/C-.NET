using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Tools
{
    public static class LogManager
    {
        private static string path = "Log";
        public static string getCurrentDir()
        {
            return path + "/" + DateTime.Now.Month + "-" + DateTime.Now.Year;
        }

        public static string getCurrentFile()
        {
            return getCurrentDir() + "/" + DateTime.Now.Day + ".txt";
        }

        public static void WriteToLog(string projectName, string funcName, string message = "")
        {
            //bool exists = Directory.Exists(Current_Folder());
            //if (!exists)
            //{

            //    DirectoryInfo dir = Directory.CreateDirectory(Current_Folder());
            //}
            //bool fileExisist = File.Exists(Current_File());
            //if (!fileExisist)
            //{
            //    File.Create(Current_File()).Close();
            //}

            //using (StreamWriter writer = new StreamWriter(Current_File(), true))
            //{
            //    writer.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{freeMessage}");
            //}
            if (!Directory.Exists(getCurrentFile()))
            {
                if (!Directory.Exists(getCurrentDir()))
                {
                    Directory.CreateDirectory(getCurrentDir());

                }
                File.Create(getCurrentFile()).Close();
            }

            using (StreamWriter writeText = new StreamWriter(getCurrentFile(), true))
            {
                writeText.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\t{projectName}.{funcName}:\t{message}");
            }


        }
        public static void Delete()
        {
            //string[] subDirectories = Directory.GetDirectories(path);
            //string month;
            //string year;

            //foreach (var item in subDirectories)
            //{
            //    Console.WriteLine(item);
            //    month = item.Substring(4, 2);
            //    year = item.Substring(7);

            //    Console.WriteLine(month + "-" + year);

            //    if (month == DateAndTime.Now.Month.ToString() && year == DateAndTime.Now.Year.ToString()) { }
            //    else
            //    if (month == DateAndTime.Now.AddMonths(-1).Month.ToString() && year == DateAndTime.Now.Year.ToString()) { }
            //    else { Directory.Delete(item); }
            //}
            string[] subDirectoriesOnLog = Directory.GetDirectories(path);
            for (int i = 0; i < subDirectoriesOnLog.Length; i++)
            {
                string[] parts = Path.GetFileName(subDirectoriesOnLog[i]).Split('_');
                string dirMonth = parts[0];
                string dirYear = parts[1];
                if (!((DateTime.Now.Year.ToString().Equals(dirYear) &&
                    ((DateTime.Now.Month - 2).ToString().Equals(dirMonth) || (DateTime.Now.Month - 1).ToString().Equals(dirMonth) || (DateTime.Now.Month).ToString().Equals(dirMonth))) ||
                    ((dirMonth.Equals("01") || dirMonth.Equals("02")) && dirYear.Equals((DateTime.Now.Year - 1).ToString()))))
                {
                    Directory.Delete(subDirectoriesOnLog[i]);
                }

            }

        }
    }
}

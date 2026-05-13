using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileLogger
{
    public class Logger
    {
        private string filePath = "log.txt";
        public void Write(string message)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";

            File.AppendAllText(filePath, logMessage + Environment.NewLine);
        }

        public List<string> Search(string keyword)
        {
            if (!File.Exists(filePath))
            {
                return new List<string>();
            }

            return File.ReadAllLines(filePath)
                       .Where(line =>line.Contains(keyword))
                       .ToList();
        }

        public void Clear()
        {
            File.WriteAllText(filePath, string.Empty);
        }
    }
}

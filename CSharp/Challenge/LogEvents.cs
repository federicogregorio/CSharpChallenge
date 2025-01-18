using System;
using System.IO;

namespace Logger
{
    public class LogEvents
    {
        private List<string> loglevels = ["DEBUG", "INFO", "WARNING", "ERROR", "CRITICAL"];
        public void log_message(string message, string logLevel)
        {
            if(this.loglevels.Contains(logLevel))
            {
                string filepath = Directory.GetCurrentDirectory() + "/application.log";
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string logEntry = $"[{logLevel}] {message}";
                using (System.IO.StreamWriter w = System.IO.File.AppendText(filepath))
                {
                    w.WriteLine($"[{timestamp}]" + logEntry);
                }
            }
        }
    }

}
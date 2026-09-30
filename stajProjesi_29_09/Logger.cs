using System;
using System.IO;

namespace stajProjesi_29_09
{
    public class Logger
    {
        private readonly object sync = new object();
        public string LogFilePath { get; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "MSEFileAnalyzer", "app_logs.txt");
        public string LastError { get; private set; }

        public void LogInfo(string message) => Log("INFO", message);
        public void LogError(string message, Exception exception = null) =>
            Log("ERROR", exception == null ? message : message + " | " + exception);

        private void Log(string level, string message)
        {
            lock (sync)
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(LogFilePath));
                    File.AppendAllText(LogFilePath, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}{Environment.NewLine}");
                    LastError = null;
                }
                catch (Exception exception)
                {
                    LastError = exception.Message;
                }
            }
        }
    }
}

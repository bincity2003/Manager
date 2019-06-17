using System;
using System.IO;

namespace Backend
{
    public static class LogWriter
    {
        public static void Write(string path, string data, bool includeTime)
        {
            if (includeTime)
            {
                data = $"{DateTime.Now}: " + data;
            }
            File.AppendAllText(path, data + "\n");
        }
    }
}

using System;
using System.IO;

namespace Supermarket.Services
{
    public class FileLog : ILog
    {
        void ILog.Write(string text)
        {
            File.AppendAllText("Today.log", text + Environment.NewLine);

        }
    }
}

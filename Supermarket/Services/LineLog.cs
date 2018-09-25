using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Services
{
    public class LineLog : ILog
    {
        private const string Token = "GrDd1CrPfBmOmusdlN3BfgALRKSEK3jvzooVzLozyLz";

        public async void Write(string text)
        {
            var line = new Notifier(Token);

            await line.Notify(text);
        }

    }
}

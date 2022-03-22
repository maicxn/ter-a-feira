using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terça_Feira.log
{
   internal static class LogPack
    {
        internal static List<Logs> LogList { get; private set; } = new List<Logs>();

        private static void AddLog(LogType logType, string operation, string result, bool show)
        {
            var logs = new Logs(logType, operation, result);
            LogList.Add(logs);

            if (show)
                Console.WriteLine(logs);
        }

        internal static void AddMessageLog(string message, bool show = true)
            => AddLog(LogType.SYSTEM, message, null, show);


        

    }
}

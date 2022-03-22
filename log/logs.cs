using System;

namespace Terça_Feira.log
{
    internal sealed class Logs
    {
        internal Logs(LogType logType, string operation, string result)
        {
            var dt = DateTime.Now;
            var datetime = $"[{dt.ToShortDateString()}][{dt.ToLongDateString()}]";
            LogType = logType;

            Message = result == null
                ? $"{datetime}  {logType}: {operation}"
                : $"{ datetime} {logType}: { operation}\n{Space(datetime.Length + logType.ToString().Length)}└──{result}";
        }

        // [data] [hora] SYSTEM: tentou falar algo
        //                     └── encerrando o programa

        public LogType LogType { get; }
        internal string Message { get; }

        private string Space(int len)
        {
            var s = "";

            for (var i = 0; i < len; i++)
                s += " ";

            return s;
        }


        public override string ToString() => Message;
     
       
    }
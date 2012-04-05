using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace JKR.Util
{
    public sealed class LogError
    {
        //public LogError();

        private const string c_EventSource = "EVIN C6 SmartClient";
        private const string c_LogName = "Application";

        public static void Write(string errorMessage)
        {
            try
            {
                if (EventLog.SourceExists(c_EventSource))
                {
                    EventLog msg = new EventLog(c_LogName);
                    msg.Source = c_EventSource;
                    msg.WriteEntry(errorMessage, EventLogEntryType.Error);
                }
                else
                {
                    EventLog.CreateEventSource(c_EventSource, c_LogName);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

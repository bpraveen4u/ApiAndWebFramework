using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Sample.Fpp.Infrastructure.Utilities;

namespace Sample.Fpp.Infrastructure.Logging
{
    /// <summary>
    /// EventLogger class is useful for logging error messages into Event Log
    /// </summary>
    public class EventLogger : ILogger
    {
        #region Implementation
        public void Info(string message)
        {
            WriteToEventLog(message, EventLogEntryType.Information);
        }

        public void Warn(string message)
        {
            WriteToEventLog(message, EventLogEntryType.Warning);
        }

        public void Debug(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

        public void Error(string message)
        {
            WriteToEventLog(message, EventLogEntryType.Error);
        }

        public void Error(Exception exception)
        {
            WriteToEventLog(exception.ToString(), EventLogEntryType.Error);
        }

        public void Fatal(string message)
        {
            WriteToEventLog(message, EventLogEntryType.Error);
        }

        public void Fatal(Exception exception)
        {
            WriteToEventLog(exception.ToString(), EventLogEntryType.Error);
        } 
        #endregion

        #region Methods
        void WriteToEventLog(string message, EventLogEntryType logType)
        {

            EventLog eventLog = new EventLog();

            eventLog.Source =AppConfigUtility.AppSettingValue("Sample.EventSource", "sample");
            eventLog.WriteEntry(message, logType);
        }

        #endregion
    }
}

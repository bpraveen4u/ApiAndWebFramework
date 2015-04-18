using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using System.Threading;

namespace Sample.Fpp.Infrastructure.Logging
{
    public class NLogLogger : ILogger
    {
        private NLog.Logger _logger;

        Func<LogLevel, string, LogEventInfo> log = new Func<LogLevel, string, LogEventInfo>((level, msg) =>
        {
            var logEvent = new NLog.LogEventInfo(level, "", msg);
            //var identity = (Thread.CurrentPrincipal as dynamic).Identity as dynamic;
            //if (identity.IsAuthenticated 
            //    && identity.App != null
            //    && !String.IsNullOrEmpty(identity.App.Code))
            //{
            //    logEvent.Properties["appcode"] = identity.App.Code;
            //}
            //try
            //{
            //    logEvent.Properties["userip"] = identity.UserIP;
            //    logEvent.Properties["useragent"] = identity.UserAgent;
            //    logEvent.Properties["controller"] = identity.Controller;
            //    logEvent.Properties["action"] = identity.Action;
            //    logEvent.Properties["requestedparams"] = identity.RequestedParams;
            //}
            //catch {}
            return logEvent; 
        });

        public NLogLogger()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        #region Implementation

        public void Info(string message)
        {
            _logger.Log(log(LogLevel.Info, message));
        }

        public void Warn(string message)
        {
            _logger.Log(log(LogLevel.Warn, message));
        }

        public void Debug(string message)
        {
            _logger.Log(log(LogLevel.Debug, message));
        }

        public void Error(string message)
        {
            _logger.Log(log(LogLevel.Error, message));
        }

        public void Error(Exception exception)
        {
            _logger.Log(log(LogLevel.Error, exception.ToString()));
        }
        
        public void Fatal(string message)
        {
            _logger.Log(log(LogLevel.Fatal, message));
        }

        public void Fatal(Exception exception)
        {
            _logger.Log(log(LogLevel.Fatal, LogUtility.BuildExceptionMessage(exception)));
        }
 
        #endregion

    }
}

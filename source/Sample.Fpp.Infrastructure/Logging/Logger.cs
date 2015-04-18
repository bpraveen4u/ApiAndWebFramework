using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using System.Globalization;
using System.Reflection;

namespace Sample.Fpp.Infrastructure.Logging
{
    public class Logger
    {        
        static ILogger _hostInternalLogger = Logger.GetLogger(LoggerName);
        /// <summary>
        /// Return the default namespace to use in the rules of the NLog configuration.
        /// We return the namespace with a ".*" append at the end.
        /// </summary>
        public static string LoggerName
        {
            get { return string.Format(CultureInfo.InvariantCulture, "{0}.*", Assembly.GetExecutingAssembly().GetName().Name); }
        }

        /// <summary>
        /// Return the public static ILogger instance.
        /// </summary>
        public static HostAnalytics.LoggingFramework.ILogger LogWrapper
        {
            get { return _hostInternalLogger; }
        }
    }
}
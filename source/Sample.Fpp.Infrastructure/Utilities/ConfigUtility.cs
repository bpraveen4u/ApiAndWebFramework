using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Sample.Fpp.Infrastructure.Utilities
{
    public static class AppConfigUtility
    {
        public static string AppSettingValue(string key, string defaultValue = "")
        {
            var value=defaultValue;
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[key])) value = ConfigurationManager.AppSettings[key];
            return value;
        }
    }
}

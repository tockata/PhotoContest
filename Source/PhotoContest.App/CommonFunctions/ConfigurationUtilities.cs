﻿namespace PhotoContest.App.CommonFunctions
{
    using System.Web.Configuration;

    public static class ConfigurationUtilities
    {
        public static string GetAppSetting(string customField)
        {
            var setting = WebConfigurationManager.AppSettings[customField];
            return setting;
        }
    }
}
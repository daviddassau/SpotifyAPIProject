using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace SpotifyAPIPractice
{
    public class Settings
    {
        private static string Get(string settingName)
        {
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get(settingName)))
                return ConfigurationManager.AppSettings.Get(settingName);

            return Environment.GetEnvironmentVariable(settingName);
        }

        public static string SpotifyClientId { get { return Get("SpotifyClientId"); } }
        public static string SpotifyClientSecret { get { return Get("SpotifyClientSecret"); } }
        public static string RedirectUri { get { return Get("RedirectUri"); } }
        public static string TokenFile { get { return Get("Settings"); } }
        // ApiUrl
        // UserName
        // PlaylistId
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GammuMonitoring.Helper
{
    class Setingan
    {
        public static void set(String key, String value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string getDefaultSmsdRc(String loc, String configloc)
        {
            if (System.IO.Path.IsPathRooted(configloc))
            {
                return configloc;
            }else
            {
                return System.IO.Path.GetDirectoryName(loc) + "\\" + configloc;
            }
        }
    }
}

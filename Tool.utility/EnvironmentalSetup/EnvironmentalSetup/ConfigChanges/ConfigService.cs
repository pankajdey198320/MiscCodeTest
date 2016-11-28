using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.Configuration;

namespace EnvironmentalSetup.ConfigChanges
{
    public class ConfigService
    {
        public void ChangeAppSetting(string key, string value, Configuration config)
        {
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
        }

        public Dictionary<string, string> GetAllConfiguration(Configuration config)
        {
            Dictionary<string, string> _d = new Dictionary<string, string>();
            foreach (var set in config.AppSettings.Settings.AllKeys)
            {
                _d.Add(set, config.AppSettings.Settings[set].Value);
            }
            return _d;
        }
    }

    public class ConfigurationFactory
    {
        public Configuration GetWebConfiguration(string path)
        {
            return WebConfigurationManager.OpenWebConfiguration("/eRxWeb", "Hotfix");
        }
    }
}

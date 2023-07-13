using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WKW_ErhebunsApp.GUI.Data
{
    public class Settings
    {
        private string _email;

        public Settings(string email)
        {
            _email = email;
        }

        public string Email { get { return _email; } internal set { _email = value; } }

        public static Settings ReadJson(string json)
        {
            try
            {
                Settings settings = JsonConvert.DeserializeObject<Settings>(json);
                return settings;
            }
            catch
            {
                return new Settings("");
            }
        }

        public static string ToJson(Settings settings)
        {
            return JsonConvert.SerializeObject(settings);
        }
    }
}

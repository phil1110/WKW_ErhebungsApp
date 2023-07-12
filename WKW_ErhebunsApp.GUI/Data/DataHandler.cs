using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKW_ErhebunsApp.GUI.Data
{
    public class DataHandler
    {
        public static List<Project> projects = Project.ReadJson(Preferences.Get("projects", null));
    }
}

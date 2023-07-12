using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKW_ErhebunsApp.GUI.Data
{
    public class Project
    {
        string _name;
        private List<Property> _properties;

        public Project(string name)
        {
            _name = name;
        }

        public string Name
        {
            private set { _name = value; }
            get
            {
                return _name;
            }
        }

        public static List<Project> ReadJson(string json)
        {
            throw new NotImplementedException();
        }

        public string ToJson(List<Project> list)
        {
            throw new NotImplementedException();
        }
    }
}

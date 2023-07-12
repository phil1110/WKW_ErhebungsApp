using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WKW_ErhebunsApp.GUI.Data
{
    public class Project
    {
        string _name;
        private List<Property> _properties = new List<Property>();

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

        public List<Property> Properties
        {
            get { return _properties; }
        }

        public void AddProperty(Property property)
        {
            _properties.Add(property);
        }

        public static List<Project> ReadJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Project>>(json);
            }
            catch
            {
                if(json == null)
                {
                    return new List<Project>();
                }
                else { return null; }
            }
        }

        public static string ToJson(List<Project> list)
        {
            try
            {
                return JsonConvert.SerializeObject(list);
            }
            catch
            {
                return null;
            }
        }
    }
}

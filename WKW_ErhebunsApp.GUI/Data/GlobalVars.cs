using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKW_ErhebunsApp.GUI.Data
{
    public static class GlobalVars
    {
		private static bool _initialized = false;
        private static List<Project> _projects;
        private static Settings _settings;

        public static Project CurrentProject { get; set; }

        public static string LastStreetEntered { get; set; }

        public static string LastPlzEntered { get; set; }

        public static void Initialize()
        {
            if (!_initialized)
            {
				_projects = Project.ReadJson(Preferences.Get("projects", null));
                _settings = Settings.ReadJson(Preferences.Get("settings", null));

                _initialized = true;
			}
		}

        public static List<Project> Projects { get { return _projects; } }

        public static void AddProject(string name)
        {
            _projects.Add(new Project(GetProjectId(), name));
            SaveProjects();
        }

        public static void RemoveProject(Project project)
        {
            _projects.Remove(project);
            SaveProjects();
        }

        public static void RemoveProject(int index)
        {
            _projects.RemoveAt(index);
            SaveProjects();
        }

        public static Project AddProperty(Project project, Property property)
        {
            int index = _projects.IndexOf(project);

            _projects[index].Properties.Add(property);

            SaveProjects();

            return _projects[index];
        }

        public static Project RemoveProperty(Project project, int id)
        {
            int index = _projects.IndexOf(project);

            Property property = _projects[index].Properties.FirstOrDefault(p => p.ID == id);

            _projects[index].Properties.Remove(property);

            SaveProjects();

            return _projects[index];
        }

        private static void SaveProjects()
        {
            Preferences.Set("projects", Project.ToJson(_projects));
        }

        public static int GetPropertyId(Project project)
        {
			if (project.Properties.Count() != 0)
			{
				return project.Properties[(project.Properties.Count() - 1)].ID + 1;
			}
			else
			{
				return 1;
			}
		}

        private static int GetProjectId()
        {
            if (_projects.Count() != 0)
            {
				return _projects[(_projects.Count() - 1)].ID + 1;
			}
            else
            {
                return 1;
            }
        }

        public static Property EditProperty(Project project, Property prop, int id)
        {
            int projectIndex = _projects.IndexOf(project);
            Property temp = _projects[projectIndex].Properties.FirstOrDefault(p => p.ID == id);
            int propIndex = _projects[projectIndex].Properties.IndexOf(temp);

            Property toInsert = new Property(_projects[projectIndex].Properties[propIndex].ID, prop.PostalCode, prop.StreetName, prop.HouseNumber, prop.Vl, prop.Info, prop.Comment, prop.Status);

            _projects[projectIndex].Properties[propIndex] = toInsert;

            return toInsert;
        }

        public static Settings GetSettings()
        {
            return _settings;
        }

        private static void SaveSettings()
        {
            Preferences.Set("settings", Settings.ToJson(_settings));
        }

        public static void SetEmail(string email)
        {
            _settings.Email = email;
            SaveSettings();
        }
    }
}

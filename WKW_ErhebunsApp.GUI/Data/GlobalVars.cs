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

        public static List<Project> projects;
        public static Project CurrentProject { get; set; }

        public static void Initialize()
        {
            if (!_initialized)
            {
				projects = Project.ReadJson(Preferences.Get("projects", null));

				_initialized = true;
			}
		}

        public static void Add(Project project)
        {
            projects.Add(project);
            SaveProjects();
        }

        public static void Remove(Project project)
        {
            projects.Remove(project);
            SaveProjects();
        }

        public static void Remove(int index)
        {
            projects.RemoveAt(index);
            SaveProjects();
        }

        private static void SaveProjects()
        {
            Preferences.Set("projects", Project.ToJson(projects));
        }
    }
}

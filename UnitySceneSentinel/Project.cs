using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitySceneSentinel
{
    public class Project
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public List<string> UsersInProject { get; set; }

        public Project(string name, string username) 
        { 
            Name = name;
            Username = username;
            UsersInProject = GetUsersInProject();
        }

        // SQL for getting all users in project
        private List<string> GetUsersInProject()
        {
            List<string> users = new List<string>();
            return users;
        }

        public override string ToString()
        {
            return $"{Name} by {Username}";
        }
    }
}

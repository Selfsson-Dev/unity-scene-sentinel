using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitySceneSentinel
{
    public class CredentialsHandler
    {
        private string username;
        private string password;

        public CredentialsHandler(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        // TODO ADD SQL
        // ENCRYPT PASSWORD??? MAYBE, lots of maybes.
        public bool IsAuthenticated()
        {
            return true; // FIX TEMPORARY
        }
    }
}

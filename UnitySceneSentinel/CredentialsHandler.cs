using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitySceneSentinel
{
    internal class CredentialsHandler
    {
        private string username;
        private string password;

        public CredentialsHandler(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        //TODO ADD SQL
        internal bool IsAuthenticated()
        {
            return true;
        }
    }
}

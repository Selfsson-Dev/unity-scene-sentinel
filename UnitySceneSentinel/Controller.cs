using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitySceneSentinel
{
    public class Controller
    {
        private CredentialsHandler? credentialsHandler;

        public Controller() 
        { 

        }

        public void VerifyLogin(string username, string password)
        {
            credentialsHandler = new CredentialsHandler(username, password);

            if (credentialsHandler.IsAuthenticated())
            {
                MessageBox.Show("Authenticated successfully");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitySceneSentinel
{
    public partial class LoginScreen : Form
    {
        private Controller controller = new Controller();

        public LoginScreen()
        {
            InitializeComponent();
        }

        // TODO ADD POPUP ON ERROR
        private void loginButton_Click(object sender, EventArgs e)
        {
                if (usernameInput.Text.Length == 0 || passwordInput.Text.Length == 0)
                    return;

                controller.VerifyLogin(usernameInput.Text, passwordInput.Text);
        }

        // Maybe theres a better way, who know. I have impostor syndrom.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

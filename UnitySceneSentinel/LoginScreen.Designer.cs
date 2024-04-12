namespace UnitySceneSentinel
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitButton = new Button();
            loginButton = new Button();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(551, 280);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 0;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(370, 280);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(370, 153);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "Username";
            usernameInput.Size = new Size(256, 23);
            usernameInput.TabIndex = 2;
            usernameInput.TextChanged += usernameInput_TextChanged;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(370, 201);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.PlaceholderText = "Password";
            passwordInput.Size = new Size(256, 23);
            passwordInput.TabIndex = 3;
            passwordInput.TextChanged += passwordInput_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(295, 30);
            label1.Name = "label1";
            label1.Size = new Size(410, 59);
            label1.TabIndex = 4;
            label1.Text = "Unity Scene Sentinel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(label1);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(loginButton);
            Controls.Add(exitButton);
            Name = "LoginScreen";
            Text = "Unity Scene Sentinel by Oswald";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button loginButton;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label label1;
    }
}
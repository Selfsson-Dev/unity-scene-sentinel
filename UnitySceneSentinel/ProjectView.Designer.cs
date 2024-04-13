namespace UnitySceneSentinel
{
    partial class ProjectView
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
            projectBox = new ComboBox();
            projectText = new Label();
            SuspendLayout();
            // 
            // projectBox
            // 
            projectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            projectBox.FormattingEnabled = true;
            projectBox.Location = new Point(12, 27);
            projectBox.Name = "projectBox";
            projectBox.Size = new Size(269, 23);
            projectBox.Sorted = true;
            projectBox.TabIndex = 0;
            projectBox.SelectedIndexChanged += projectBox_SelectedIndexChanged;
            // 
            // projectText
            // 
            projectText.AutoSize = true;
            projectText.Location = new Point(12, 9);
            projectText.Name = "projectText";
            projectText.Size = new Size(77, 15);
            projectText.TabIndex = 1;
            projectText.Text = "Project select\r\n";
            // 
            // ProjectView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(projectText);
            Controls.Add(projectBox);
            Name = "ProjectView";
            Text = "Unity Scene Sentinel by Oswald";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox projectBox;
        private Label projectText;
    }
}
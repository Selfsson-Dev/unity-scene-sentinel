namespace UnitySceneSentinel
{
    partial class Popup
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
            okButton = new Button();
            popupLabel = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(132, 77);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "okay?";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // popupLabel
            // 
            popupLabel.AutoSize = true;
            popupLabel.Location = new Point(99, 20);
            popupLabel.Name = "popupLabel";
            popupLabel.Size = new Size(136, 15);
            popupLabel.TabIndex = 1;
            popupLabel.Text = "Awesome text goes here";
            popupLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Popup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 112);
            Controls.Add(popupLabel);
            Controls.Add(okButton);
            Name = "Popup";
            Text = "Popup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Label popupLabel;
    }
}
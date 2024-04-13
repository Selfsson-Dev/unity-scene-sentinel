using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnitySceneSentinel
{
    public partial class ProjectView : Form
    {
        public ProjectView()
        {
            InitializeComponent();
            projectBox.Items.AddRange(GetProjects());
        }

        private Project[] GetProjects()
        {
            // SQL for getting projects where userid = username
            return CreateTestProjects();
        }

        private Project[] CreateTestProjects()
        {
            return [new Project("Awesome game 1", "Selfsson"), 
                new Project("Awesome game 4", "Gabbersh"), 
                new Project("Awesome game 69", "Kingennoobin")];
        }

        private void projectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object? selectedItem = projectBox.SelectedItem;

            if (selectedItem == null) return;

            MessageBox.Show(selectedItem.ToString());
        }
    }
}

using System;
using System.Windows.Forms;

namespace Gauthier_4
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        // Handle the Close Button Click event
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the About Form, returning to the Main Registration Form

        }
        // Handle the About Form Load event
        private void AboutForm_Load(object sender, EventArgs e)
        {
            // Assign the close button tool tip
            toolTip1.SetToolTip(closeButton, "Click here to close the About Form and return to the Registration Form"); 
        }
    }
}

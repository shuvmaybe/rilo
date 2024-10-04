using System;
using System.Windows.Forms;

namespace rilo
{
    public partial class manifest_window : Form
    {
        public manifest_window()
        {
            InitializeComponent();
        }

        // handle installation in form1
        public event Action InstallClicked;

        private void install_Click(object sender, EventArgs e)
        {
            InstallClicked?.Invoke();
            this.Close();
        }
    }
}

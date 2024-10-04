using System.Windows.Forms;

namespace rilo
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        public void UpdateLoader(string text)
        {
            loader.Text = text;
        }
    }
}

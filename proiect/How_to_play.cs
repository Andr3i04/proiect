using System;
using System.Windows.Forms;

namespace proiect
{
    public partial class How_to_play : Form
    {
        public How_to_play(string message)
        {
            InitializeComponent();
            lblmessageHOP.Text = message;
        }

        private void How_to_play_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblmessageHOP_Click(object sender, EventArgs e)
        {

        }
    }
}

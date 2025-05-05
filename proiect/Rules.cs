using System;
using System.Windows.Forms;

namespace proiect
{
    public partial class Rules : Form
    {
        public Rules(string message2)
        {
            InitializeComponent();
            lblmessageRULES.Text = message2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

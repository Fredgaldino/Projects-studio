using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PublishForm : Form
    {
        public PublishForm()
        {
            InitializeComponent();
            btnPublish.Enabled = false;
        }

        private void btnPubExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            lblEmailNotific.Visible = true;
            lblEmailNotific.Text = txtBoxPublish.Text + "111-222-3333";
            
            txtBoxPublish.Clear();         
        }

        private void txtBoxPublish_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPublish.Text.Length > 0)
            {
                btnPublish.Enabled = true;
            }
        }

        private void PublishForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class NotificManagerForm : Form
    {
        public NotificManagerForm()
        {
            InitializeComponent();
        }

        private void btnMngSubs_Click(object sender, EventArgs e)
        {
            SubscribeForm sub = new SubscribeForm();
            sub.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPublNot_Click(object sender, EventArgs e)
        {
            PublishForm pub = new PublishForm();
            pub.Show();
        }
    }
}

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
    public partial class SubscribeForm : Form
    {

        public SubscribeForm()
        {
            InitializeComponent();
            txtBoxPhone.Text = "xxx-xxx-xxxx";            
            
        }

        

        private void btnSubsc_Click(object sender, EventArgs e)
        {        
            if (checkBoxEmail.Checked == true)
            {
                System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (!rEMail.IsMatch(txtBoxEmail.Text))
                {
                    lblInvalidEmail.Visible = true;
                }
                if (rEMail.IsMatch(txtBoxEmail.Text))
                {
                    txtBoxEmail.Clear();
                    txtBoxPhone.Clear();
                    PublishForm pub = new PublishForm();
                    pub.Show();

                }                
            }
            if (checkBoxPhone.Checked == true)
            {
                System.Text.RegularExpressions.Regex rPhone = new System.Text.RegularExpressions.Regex(@"^[\d]*-[\d]*-[\d]*$");
                if (!rPhone.IsMatch(txtBoxPhone.Text))
                {
                    lblInvalidPhone.Visible = true;
                }
                if (rPhone.IsMatch(txtBoxPhone.Text))
                {
                    PublishForm pub = new PublishForm();
                    pub.Show();
                }
            }
            txtBoxEmail.Clear();
            txtBoxPhone.Clear();  
        }

        private void checkBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxEmail.Checked && txtBoxEmail.Text.Length >= 7)
            {
                btnSubsc.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {            
            if (checkBoxPhone.Checked && txtBoxPhone.Text.Length >= 12)
            {                               
                {                
                    btnSubsc.Enabled = true;
                }                
            }
        }
    }
}

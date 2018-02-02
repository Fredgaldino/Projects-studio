namespace WindowsFormsApp2
{
    partial class SubscribeForm
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
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.btnSubsc = new System.Windows.Forms.Button();
            this.btnUnsubsc = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInvalidPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(26, 13);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(136, 17);
            this.checkBoxEmail.TabIndex = 0;
            this.checkBoxEmail.Text = "Message Sent by Email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            this.checkBoxEmail.CheckedChanged += new System.EventHandler(this.checkBoxEmail_CheckedChanged);
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Location = new System.Drawing.Point(26, 77);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(142, 17);
            this.checkBoxPhone.TabIndex = 1;
            this.checkBoxPhone.Text = "Message Sent by Phone";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(184, 13);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(241, 20);
            this.txtBoxEmail.TabIndex = 2;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxPhone.Location = new System.Drawing.Point(184, 77);
            this.txtBoxPhone.MaxLength = 12;
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(241, 20);
            this.txtBoxPhone.TabIndex = 3;
            this.txtBoxPhone.WordWrap = false;
            this.txtBoxPhone.TextChanged += new System.EventHandler(this.txtBoxPhone_TextChanged);
            // 
            // lblInvalidEmail
            // 
            this.lblInvalidEmail.AutoSize = true;
            this.lblInvalidEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInvalidEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidEmail.Location = new System.Drawing.Point(268, 36);
            this.lblInvalidEmail.Name = "lblInvalidEmail";
            this.lblInvalidEmail.Size = new System.Drawing.Size(79, 13);
            this.lblInvalidEmail.TabIndex = 4;
            this.lblInvalidEmail.Text = "Invalid Email";
            this.lblInvalidEmail.Visible = false;
            // 
            // btnSubsc
            // 
            this.btnSubsc.Enabled = false;
            this.btnSubsc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSubsc.Location = new System.Drawing.Point(27, 129);
            this.btnSubsc.Name = "btnSubsc";
            this.btnSubsc.Size = new System.Drawing.Size(75, 23);
            this.btnSubsc.TabIndex = 5;
            this.btnSubsc.Text = "Subscribe";
            this.btnSubsc.UseVisualStyleBackColor = true;
            this.btnSubsc.Click += new System.EventHandler(this.btnSubsc_Click);
            // 
            // btnUnsubsc
            // 
            this.btnUnsubsc.Location = new System.Drawing.Point(195, 129);
            this.btnUnsubsc.Name = "btnUnsubsc";
            this.btnUnsubsc.Size = new System.Drawing.Size(75, 23);
            this.btnUnsubsc.TabIndex = 6;
            this.btnUnsubsc.Text = "Unsubscribe";
            this.btnUnsubsc.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(363, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInvalidPhone
            // 
            this.lblInvalidPhone.AutoSize = true;
            this.lblInvalidPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPhone.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPhone.Location = new System.Drawing.Point(259, 100);
            this.lblInvalidPhone.Name = "lblInvalidPhone";
            this.lblInvalidPhone.Size = new System.Drawing.Size(92, 13);
            this.lblInvalidPhone.TabIndex = 8;
            this.lblInvalidPhone.Text = "Invalid Number";
            this.lblInvalidPhone.Visible = false;
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(482, 175);
            this.Controls.Add(this.lblInvalidPhone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnsubsc);
            this.Controls.Add(this.btnSubsc);
            this.Controls.Add(this.lblInvalidEmail);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.checkBoxPhone);
            this.Controls.Add(this.checkBoxEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubscribeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubscribeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label lblInvalidEmail;
        private System.Windows.Forms.Button btnSubsc;
        private System.Windows.Forms.Button btnUnsubsc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInvalidPhone;
    }
}
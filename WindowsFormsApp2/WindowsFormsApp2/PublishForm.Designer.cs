namespace WindowsFormsApp2
{
    partial class PublishForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPublish = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEmailNotific = new System.Windows.Forms.Label();
            this.lblPhoneNotific = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content";
            // 
            // txtBoxPublish
            // 
            this.txtBoxPublish.Location = new System.Drawing.Point(135, 52);
            this.txtBoxPublish.Name = "txtBoxPublish";
            this.txtBoxPublish.Size = new System.Drawing.Size(263, 20);
            this.txtBoxPublish.TabIndex = 1;
            this.txtBoxPublish.TextChanged += new System.EventHandler(this.txtBoxPublish_TextChanged);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(85, 102);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 2;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPubExit_Click);
            // 
            // lblEmailNotific
            // 
            this.lblEmailNotific.AutoSize = true;
            this.lblEmailNotific.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailNotific.Location = new System.Drawing.Point(176, 156);
            this.lblEmailNotific.Name = "lblEmailNotific";
            this.lblEmailNotific.Size = new System.Drawing.Size(111, 16);
            this.lblEmailNotific.TabIndex = 4;
            this.lblEmailNotific.Text = "lblEmailNotification";
            this.lblEmailNotific.Visible = false;
            // 
            // lblPhoneNotific
            // 
            this.lblPhoneNotific.AutoSize = true;
            this.lblPhoneNotific.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNotific.Location = new System.Drawing.Point(176, 188);
            this.lblPhoneNotific.Name = "lblPhoneNotific";
            this.lblPhoneNotific.Size = new System.Drawing.Size(90, 16);
            this.lblPhoneNotific.TabIndex = 5;
            this.lblPhoneNotific.Text = "lblPhoneNotific";
            this.lblPhoneNotific.Visible = false;
            // 
            // PublishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(414, 234);
            this.Controls.Add(this.lblPhoneNotific);
            this.Controls.Add(this.lblEmailNotific);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtBoxPublish);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publish Notification";
            this.Load += new System.EventHandler(this.PublishForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPublish;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEmailNotific;
        private System.Windows.Forms.Label lblPhoneNotific;
    }
}
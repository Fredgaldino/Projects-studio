namespace WindowsFormsApp2
{
    partial class NotificManagerForm
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
            this.btnMngSubs = new System.Windows.Forms.Button();
            this.btnPublNot = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMngSubs
            // 
            this.btnMngSubs.Location = new System.Drawing.Point(76, 24);
            this.btnMngSubs.Name = "btnMngSubs";
            this.btnMngSubs.Size = new System.Drawing.Size(136, 43);
            this.btnMngSubs.TabIndex = 0;
            this.btnMngSubs.Text = "Manage Subscription";
            this.btnMngSubs.UseVisualStyleBackColor = true;
            this.btnMngSubs.Click += new System.EventHandler(this.btnMngSubs_Click);
            // 
            // btnPublNot
            // 
            this.btnPublNot.Enabled = false;
            this.btnPublNot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPublNot.Location = new System.Drawing.Point(76, 89);
            this.btnPublNot.Name = "btnPublNot";
            this.btnPublNot.Size = new System.Drawing.Size(136, 43);
            this.btnPublNot.TabIndex = 1;
            this.btnPublNot.Text = "Publish Notification";
            this.btnPublNot.UseVisualStyleBackColor = true;
            this.btnPublNot.Click += new System.EventHandler(this.btnPublNot_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(76, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NotificManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(297, 227);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublNot);
            this.Controls.Add(this.btnMngSubs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification Manager by Frederico Galdino";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMngSubs;
        private System.Windows.Forms.Button btnPublNot;
        private System.Windows.Forms.Button btnExit;
    }
}


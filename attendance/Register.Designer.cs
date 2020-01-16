namespace attendance
{
    partial class Register
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
            this.TxtUser = new MetroFramework.Controls.MetroTextBox();
            this.TxtPass1 = new MetroFramework.Controls.MetroTextBox();
            this.TxtPass2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(148, 123);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(129, 23);
            this.TxtUser.TabIndex = 0;
            // 
            // TxtPass1
            // 
            this.TxtPass1.Location = new System.Drawing.Point(148, 187);
            this.TxtPass1.Name = "TxtPass1";
            this.TxtPass1.PasswordChar = '*';
            this.TxtPass1.Size = new System.Drawing.Size(129, 23);
            this.TxtPass1.TabIndex = 0;
            // 
            // TxtPass2
            // 
            this.TxtPass2.Location = new System.Drawing.Point(148, 265);
            this.TxtPass2.Name = "TxtPass2";
            this.TxtPass2.PasswordChar = '*';
            this.TxtPass2.Size = new System.Drawing.Size(129, 23);
            this.TxtPass2.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(148, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "UserName";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(148, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(148, 242);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Confirm Password";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(375, 352);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 45);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "accept";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtPass2);
            this.Controls.Add(this.TxtPass1);
            this.Controls.Add(this.TxtUser);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtUser;
        private MetroFramework.Controls.MetroTextBox TxtPass1;
        private MetroFramework.Controls.MetroTextBox TxtPass2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
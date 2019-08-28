namespace prjPointOfSalesSystem
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.TextBox();
            this.passwordValue = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, -18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(56, 206);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(10);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.usernameLabel.Size = new System.Drawing.Size(88, 30);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(56, 274);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(10);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Padding = new System.Windows.Forms.Padding(5);
            this.passwordLabel.Size = new System.Drawing.Size(83, 30);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // usernameValue
            // 
            this.usernameValue.Location = new System.Drawing.Point(208, 209);
            this.usernameValue.Margin = new System.Windows.Forms.Padding(10);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(160, 27);
            this.usernameValue.TabIndex = 3;
            // 
            // passwordValue
            // 
            this.passwordValue.Location = new System.Drawing.Point(208, 277);
            this.passwordValue.Margin = new System.Windows.Forms.Padding(10);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.PasswordChar = '*';
            this.passwordValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordValue.Size = new System.Drawing.Size(160, 27);
            this.passwordValue.TabIndex = 4;
            this.passwordValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Login
            // 
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login.Location = new System.Drawing.Point(114, 358);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(160, 37);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancel.Location = new System.Drawing.Point(114, 401);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(160, 37);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passwordValue);
            this.Controls.Add(this.usernameValue);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameValue;
        private System.Windows.Forms.TextBox passwordValue;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Cancel;
    }
}


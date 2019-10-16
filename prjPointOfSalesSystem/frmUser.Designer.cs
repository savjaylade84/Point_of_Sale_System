namespace prjPointOfSalesSystem
{
    partial class frmUser
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
            this.UserIdValue = new System.Windows.Forms.TextBox();
            this.PasswordValue = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordValue = new System.Windows.Forms.TextBox();
            this.UsernameValue = new System.Windows.Forms.TextBox();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.ShowPasswordChckBx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // UserIdValue
            // 
            this.UserIdValue.Location = new System.Drawing.Point(76, 305);
            this.UserIdValue.Margin = new System.Windows.Forms.Padding(15);
            this.UserIdValue.Name = "UserIdValue";
            this.UserIdValue.Size = new System.Drawing.Size(293, 34);
            this.UserIdValue.TabIndex = 0;
            this.UserIdValue.Text = "[user id:]";
            this.UserIdValue.Click += new System.EventHandler(this.FocusTextbox);
            this.UserIdValue.Leave += new System.EventHandler(this.UnFocusTextBox);
            // 
            // PasswordValue
            // 
            this.PasswordValue.Location = new System.Drawing.Point(76, 433);
            this.PasswordValue.Margin = new System.Windows.Forms.Padding(15);
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.Size = new System.Drawing.Size(293, 34);
            this.PasswordValue.TabIndex = 2;
            this.PasswordValue.Text = "[password:]";
            this.PasswordValue.Click += new System.EventHandler(this.FocusTextbox);
            this.PasswordValue.Leave += new System.EventHandler(this.UnFocusTextBox);
            // 
            // ConfirmPasswordValue
            // 
            this.ConfirmPasswordValue.Location = new System.Drawing.Point(76, 497);
            this.ConfirmPasswordValue.Margin = new System.Windows.Forms.Padding(15);
            this.ConfirmPasswordValue.Name = "ConfirmPasswordValue";
            this.ConfirmPasswordValue.Size = new System.Drawing.Size(293, 34);
            this.ConfirmPasswordValue.TabIndex = 4;
            this.ConfirmPasswordValue.Text = "[confirm password]";
            this.ConfirmPasswordValue.Click += new System.EventHandler(this.FocusTextbox);
            this.ConfirmPasswordValue.Leave += new System.EventHandler(this.UnFocusTextBox);
            // 
            // UsernameValue
            // 
            this.UsernameValue.Location = new System.Drawing.Point(76, 369);
            this.UsernameValue.Margin = new System.Windows.Forms.Padding(15);
            this.UsernameValue.Name = "UsernameValue";
            this.UsernameValue.Size = new System.Drawing.Size(293, 34);
            this.UsernameValue.TabIndex = 6;
            this.UsernameValue.Text = "[username:]";
            this.UsernameValue.Click += new System.EventHandler(this.FocusTextbox);
            this.UsernameValue.Leave += new System.EventHandler(this.UnFocusTextBox);
            // 
            // ProfilePic
            // 
            this.ProfilePic.Image = global::prjPointOfSalesSystem.Properties.Resources.Unknown_empty;
            this.ProfilePic.Location = new System.Drawing.Point(76, 69);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(303, 218);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePic.TabIndex = 14;
            this.ProfilePic.TabStop = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(76, 549);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(293, 57);
            this.SubmitBtn.TabIndex = 15;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ShowPasswordChckBx
            // 
            this.ShowPasswordChckBx.AutoSize = true;
            this.ShowPasswordChckBx.Location = new System.Drawing.Point(372, 433);
            this.ShowPasswordChckBx.Name = "ShowPasswordChckBx";
            this.ShowPasswordChckBx.Size = new System.Drawing.Size(84, 32);
            this.ShowPasswordChckBx.TabIndex = 16;
            this.ShowPasswordChckBx.Text = "Show";
            this.ShowPasswordChckBx.UseVisualStyleBackColor = true;
            this.ShowPasswordChckBx.Click += new System.EventHandler(this.ShowHidePassword);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(496, 713);
            this.Controls.Add(this.ShowPasswordChckBx);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.ProfilePic);
            this.Controls.Add(this.UsernameValue);
            this.Controls.Add(this.ConfirmPasswordValue);
            this.Controls.Add(this.PasswordValue);
            this.Controls.Add(this.UserIdValue);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUser";
            this.Text = "User Registration";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserIdValue;
        private System.Windows.Forms.TextBox PasswordValue;
        private System.Windows.Forms.TextBox ConfirmPasswordValue;
        private System.Windows.Forms.TextBox UsernameValue;
        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.CheckBox ShowPasswordChckBx;
    }
}
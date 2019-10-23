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
            this.InfoAlert = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.ContactValue = new System.Windows.Forms.TextBox();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // UserIdValue
            // 
            this.UserIdValue.Location = new System.Drawing.Point(17, 252);
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
            this.PasswordValue.Location = new System.Drawing.Point(17, 380);
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
            this.ConfirmPasswordValue.Location = new System.Drawing.Point(17, 444);
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
            this.UsernameValue.Location = new System.Drawing.Point(17, 316);
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
            this.ProfilePic.Location = new System.Drawing.Point(17, 16);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(303, 218);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePic.TabIndex = 14;
            this.ProfilePic.TabStop = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(17, 752);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(293, 57);
            this.SubmitBtn.TabIndex = 15;
            this.SubmitBtn.Text = "Create";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ShowPasswordChckBx
            // 
            this.ShowPasswordChckBx.AutoSize = true;
            this.ShowPasswordChckBx.Location = new System.Drawing.Point(313, 380);
            this.ShowPasswordChckBx.Name = "ShowPasswordChckBx";
            this.ShowPasswordChckBx.Size = new System.Drawing.Size(84, 32);
            this.ShowPasswordChckBx.TabIndex = 16;
            this.ShowPasswordChckBx.Text = "Show";
            this.ShowPasswordChckBx.UseVisualStyleBackColor = true;
            this.ShowPasswordChckBx.Click += new System.EventHandler(this.ShowHidePassword);
            // 
            // InfoAlert
            // 
            this.InfoAlert.AutoSize = true;
            this.InfoAlert.Location = new System.Drawing.Point(405, 16);
            this.InfoAlert.Name = "InfoAlert";
            this.InfoAlert.Size = new System.Drawing.Size(0, 28);
            this.InfoAlert.TabIndex = 17;
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(17, 572);
            this.LastNameValue.Margin = new System.Windows.Forms.Padding(15);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(293, 34);
            this.LastNameValue.TabIndex = 19;
            this.LastNameValue.Text = "[last name:]";
            this.LastNameValue.Click += new System.EventHandler(this.FocusTextbox);
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(17, 508);
            this.FirstNameValue.Margin = new System.Windows.Forms.Padding(15);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(293, 34);
            this.FirstNameValue.TabIndex = 18;
            this.FirstNameValue.Text = "[first name:]";
            this.FirstNameValue.Click += new System.EventHandler(this.FocusTextbox);
            // 
            // ContactValue
            // 
            this.ContactValue.Location = new System.Drawing.Point(17, 700);
            this.ContactValue.Margin = new System.Windows.Forms.Padding(15);
            this.ContactValue.Name = "ContactValue";
            this.ContactValue.Size = new System.Drawing.Size(293, 34);
            this.ContactValue.TabIndex = 21;
            this.ContactValue.Text = "[contact no.:]";
            this.ContactValue.Click += new System.EventHandler(this.FocusTextbox);
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(17, 636);
            this.EmailValue.Margin = new System.Windows.Forms.Padding(15);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(293, 34);
            this.EmailValue.TabIndex = 20;
            this.EmailValue.Text = "[email:]";
            this.EmailValue.Click += new System.EventHandler(this.FocusTextbox);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.Location = new System.Drawing.Point(17, 815);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(293, 57);
            this.CancelBtn.TabIndex = 22;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.ExitForm);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(636, 885);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ContactValue);
            this.Controls.Add(this.EmailValue);
            this.Controls.Add(this.LastNameValue);
            this.Controls.Add(this.FirstNameValue);
            this.Controls.Add(this.InfoAlert);
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
        private System.Windows.Forms.Label InfoAlert;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.TextBox ContactValue;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Button CancelBtn;
    }
}
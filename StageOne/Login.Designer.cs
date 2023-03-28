namespace StageOne
{
    partial class Login
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
            this.title = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.username_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.redirect_label = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(260, 58);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(274, 44);
            this.title.TabIndex = 0;
            this.title.Text = "RE:Battlespire";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(177, 176);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(91, 25);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(181, 243);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(87, 25);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(274, 173);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(294, 31);
            this.username_input.TabIndex = 3;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(274, 240);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(294, 31);
            this.password_input.TabIndex = 4;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(348, 327);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(112, 34);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // redirect_label
            // 
            this.redirect_label.AutoSize = true;
            this.redirect_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.redirect_label.Location = new System.Drawing.Point(397, 274);
            this.redirect_label.Name = "redirect_label";
            this.redirect_label.Size = new System.Drawing.Size(171, 21);
            this.redirect_label.TabIndex = 6;
            this.redirect_label.TabStop = true;
            this.redirect_label.Text = "Don\'t have an account?";
            this.redirect_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.redirect_label_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.redirect_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.title);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private Label label_username;
        private Label label_password;
        private TextBox username_input;
        private TextBox password_input;
        private Button login_button;
        private LinkLabel redirect_label;
    }
}
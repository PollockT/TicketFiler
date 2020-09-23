namespace TicketUI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.loginNameLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginNameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginQuitButton = new System.Windows.Forms.Button();
            this.loginContactLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(176, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(260, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Ticket Tracking Application";
            // 
            // loginNameLabel
            // 
            this.loginNameLabel.AutoSize = true;
            this.loginNameLabel.Location = new System.Drawing.Point(249, 125);
            this.loginNameLabel.Name = "loginNameLabel";
            this.loginNameLabel.Size = new System.Drawing.Size(116, 30);
            this.loginNameLabel.TabIndex = 1;
            this.loginNameLabel.Text = "User Name";
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(232, 232);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(146, 30);
            this.loginPasswordLabel.TabIndex = 2;
            this.loginPasswordLabel.Text = "User Password";
            // 
            // loginNameTextBox
            // 
            this.loginNameTextBox.Location = new System.Drawing.Point(232, 167);
            this.loginNameTextBox.Name = "loginNameTextBox";
            this.loginNameTextBox.PlaceholderText = "User Name";
            this.loginNameTextBox.Size = new System.Drawing.Size(146, 35);
            this.loginNameTextBox.TabIndex = 3;
            this.loginNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(232, 265);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.PlaceholderText = "Password";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(146, 35);
            this.loginPasswordTextBox.TabIndex = 4;
            this.loginPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginQuitButton
            // 
            this.loginQuitButton.BackColor = System.Drawing.Color.Red;
            this.loginQuitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginQuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.loginQuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginQuitButton.Location = new System.Drawing.Point(444, 423);
            this.loginQuitButton.Name = "loginQuitButton";
            this.loginQuitButton.Size = new System.Drawing.Size(155, 50);
            this.loginQuitButton.TabIndex = 5;
            this.loginQuitButton.Text = "Quit Application";
            this.loginQuitButton.UseVisualStyleBackColor = false;
            this.loginQuitButton.Click += new System.EventHandler(this.loginQuitButton_Click);
            // 
            // loginContactLabel
            // 
            this.loginContactLabel.AutoSize = true;
            this.loginContactLabel.Location = new System.Drawing.Point(410, 354);
            this.loginContactLabel.Name = "loginContactLabel";
            this.loginContactLabel.Size = new System.Drawing.Size(217, 30);
            this.loginContactLabel.TabIndex = 6;
            this.loginContactLabel.TabStop = true;
            this.loginContactLabel.Text = "Contact Administrator";
            this.loginContactLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginContactLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 495);
            this.Controls.Add(this.loginContactLabel);
            this.Controls.Add(this.loginQuitButton);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginNameTextBox);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.loginNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label loginNameLabel;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox loginNameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Button loginQuitButton;
        private System.Windows.Forms.LinkLabel loginContactLabel;
    }
}
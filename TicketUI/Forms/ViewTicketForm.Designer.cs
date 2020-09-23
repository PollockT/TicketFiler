namespace TicketUI.Forms
{
    partial class ViewTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTicketForm));
            this.headingLabel = new System.Windows.Forms.Label();
            this.ticketNumberLabel = new System.Windows.Forms.Label();
            this.ticketNameLabel = new System.Windows.Forms.TextBox();
            this.ticketCategoryLabel = new System.Windows.Forms.Label();
            this.ticketCategoryUpDown = new System.Windows.Forms.DomainUpDown();
            this.ticketPriorityLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ticketTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ticketTimeLabel = new System.Windows.Forms.Label();
            this.ticketCancelButton = new System.Windows.Forms.Button();
            this.ticketCloseButton = new System.Windows.Forms.Button();
            this.ticketUpdateButton = new System.Windows.Forms.Button();
            this.ticketTextBox = new System.Windows.Forms.RichTextBox();
            this.ticketDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(184, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(273, 37);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Ticket Management";
            // 
            // ticketNumberLabel
            // 
            this.ticketNumberLabel.AutoSize = true;
            this.ticketNumberLabel.Location = new System.Drawing.Point(12, 76);
            this.ticketNumberLabel.Name = "ticketNumberLabel";
            this.ticketNumberLabel.Size = new System.Drawing.Size(169, 30);
            this.ticketNumberLabel.TabIndex = 1;
            this.ticketNumberLabel.Text = "<ticket number>";
            // 
            // ticketNameLabel
            // 
            this.ticketNameLabel.Location = new System.Drawing.Point(237, 71);
            this.ticketNameLabel.Name = "ticketNameLabel";
            this.ticketNameLabel.PlaceholderText = "<loading ticket title>";
            this.ticketNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ticketNameLabel.Size = new System.Drawing.Size(337, 35);
            this.ticketNameLabel.TabIndex = 5;
            // 
            // ticketCategoryLabel
            // 
            this.ticketCategoryLabel.AutoSize = true;
            this.ticketCategoryLabel.Location = new System.Drawing.Point(10, 134);
            this.ticketCategoryLabel.Name = "ticketCategoryLabel";
            this.ticketCategoryLabel.Size = new System.Drawing.Size(96, 30);
            this.ticketCategoryLabel.TabIndex = 3;
            this.ticketCategoryLabel.Text = "Category";
            // 
            // ticketCategoryUpDown
            // 
            this.ticketCategoryUpDown.Items.Add("User Interface");
            this.ticketCategoryUpDown.Items.Add("Maintenance");
            this.ticketCategoryUpDown.Items.Add("Update");
            this.ticketCategoryUpDown.Items.Add("Code Portability");
            this.ticketCategoryUpDown.Items.Add("Features");
            this.ticketCategoryUpDown.Items.Add("Performance");
            this.ticketCategoryUpDown.Items.Add("Account Information");
            this.ticketCategoryUpDown.Items.Add("Administration");
            this.ticketCategoryUpDown.Location = new System.Drawing.Point(12, 167);
            this.ticketCategoryUpDown.Name = "ticketCategoryUpDown";
            this.ticketCategoryUpDown.Size = new System.Drawing.Size(269, 35);
            this.ticketCategoryUpDown.TabIndex = 7;
            // 
            // ticketPriorityLabel
            // 
            this.ticketPriorityLabel.AutoSize = true;
            this.ticketPriorityLabel.Location = new System.Drawing.Point(496, 134);
            this.ticketPriorityLabel.Name = "ticketPriorityLabel";
            this.ticketPriorityLabel.Size = new System.Drawing.Size(78, 30);
            this.ticketPriorityLabel.TabIndex = 3;
            this.ticketPriorityLabel.Text = "Priority";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox1.Location = new System.Drawing.Point(496, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(78, 38);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "5";
            // 
            // ticketTimePicker
            // 
            this.ticketTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ticketTimePicker.Location = new System.Drawing.Point(12, 273);
            this.ticketTimePicker.Name = "ticketTimePicker";
            this.ticketTimePicker.Size = new System.Drawing.Size(127, 35);
            this.ticketTimePicker.TabIndex = 6;
            // 
            // ticketTimeLabel
            // 
            this.ticketTimeLabel.AutoSize = true;
            this.ticketTimeLabel.Location = new System.Drawing.Point(10, 240);
            this.ticketTimeLabel.Name = "ticketTimeLabel";
            this.ticketTimeLabel.Size = new System.Drawing.Size(164, 30);
            this.ticketTimeLabel.TabIndex = 9;
            this.ticketTimeLabel.Text = "Incident of Time";
            // 
            // ticketCancelButton
            // 
            this.ticketCancelButton.BackColor = System.Drawing.Color.Gold;
            this.ticketCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ticketCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.ticketCancelButton.Location = new System.Drawing.Point(216, 514);
            this.ticketCancelButton.Name = "ticketCancelButton";
            this.ticketCancelButton.Size = new System.Drawing.Size(166, 74);
            this.ticketCancelButton.TabIndex = 4;
            this.ticketCancelButton.Text = "Cancel Ticket Changes";
            this.ticketCancelButton.UseVisualStyleBackColor = false;
            this.ticketCancelButton.Click += new System.EventHandler(this.ticketCancelButton_Click);
            // 
            // ticketCloseButton
            // 
            this.ticketCloseButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ticketCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ticketCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.ticketCloseButton.Location = new System.Drawing.Point(408, 514);
            this.ticketCloseButton.Name = "ticketCloseButton";
            this.ticketCloseButton.Size = new System.Drawing.Size(166, 74);
            this.ticketCloseButton.TabIndex = 4;
            this.ticketCloseButton.Text = "Close Ticket";
            this.ticketCloseButton.UseVisualStyleBackColor = false;
            this.ticketCloseButton.Click += new System.EventHandler(this.ticketCloseButton_Click);
            // 
            // ticketUpdateButton
            // 
            this.ticketUpdateButton.BackColor = System.Drawing.Color.Green;
            this.ticketUpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ticketUpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.ticketUpdateButton.Location = new System.Drawing.Point(15, 514);
            this.ticketUpdateButton.Name = "ticketUpdateButton";
            this.ticketUpdateButton.Size = new System.Drawing.Size(166, 74);
            this.ticketUpdateButton.TabIndex = 4;
            this.ticketUpdateButton.Text = "Update Ticket";
            this.ticketUpdateButton.UseVisualStyleBackColor = false;
            this.ticketUpdateButton.Click += new System.EventHandler(this.ticketUpdateButton_Click);
            // 
            // ticketTextBox
            // 
            this.ticketTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ticketTextBox.Location = new System.Drawing.Point(310, 273);
            this.ticketTextBox.Name = "ticketTextBox";
            this.ticketTextBox.Size = new System.Drawing.Size(264, 207);
            this.ticketTextBox.TabIndex = 8;
            this.ticketTextBox.Text = "";
            // 
            // ticketDescriptionLabel
            // 
            this.ticketDescriptionLabel.AutoSize = true;
            this.ticketDescriptionLabel.Location = new System.Drawing.Point(358, 240);
            this.ticketDescriptionLabel.Name = "ticketDescriptionLabel";
            this.ticketDescriptionLabel.Size = new System.Drawing.Size(178, 30);
            this.ticketDescriptionLabel.TabIndex = 10;
            this.ticketDescriptionLabel.Text = "Ticket Description";
            // 
            // ViewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 600);
            this.Controls.Add(this.ticketDescriptionLabel);
            this.Controls.Add(this.ticketTextBox);
            this.Controls.Add(this.ticketUpdateButton);
            this.Controls.Add(this.ticketCloseButton);
            this.Controls.Add(this.ticketCancelButton);
            this.Controls.Add(this.ticketTimeLabel);
            this.Controls.Add(this.ticketTimePicker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ticketPriorityLabel);
            this.Controls.Add(this.ticketCategoryUpDown);
            this.Controls.Add(this.ticketCategoryLabel);
            this.Controls.Add(this.ticketNameLabel);
            this.Controls.Add(this.ticketNumberLabel);
            this.Controls.Add(this.headingLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ViewTicketForm";
            this.Text = "View Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label ticketCategoryLabel;
        private System.Windows.Forms.Label ticketNumberLabel;
        private System.Windows.Forms.TextBox ticketNameLabel;
        private System.Windows.Forms.DomainUpDown ticketCategoryUpDown;
        private System.Windows.Forms.Label ticketPriorityLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker ticketTimePicker;
        private System.Windows.Forms.Label ticketTimeLabel;
        private System.Windows.Forms.Button ticketCancelButton;
        private System.Windows.Forms.Button ticketCloseButton;
        private System.Windows.Forms.Button ticketUpdateButton;
        private System.Windows.Forms.RichTextBox ticketTextBox;
        private System.Windows.Forms.Label ticketDescriptionLabel;
    }
}
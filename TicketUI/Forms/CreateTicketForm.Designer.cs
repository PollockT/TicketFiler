namespace TicketUI
{
    partial class CreateTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTicketForm));
            this.headerBuildLabel = new System.Windows.Forms.Label();
            this.ticketBuildNumberLabel = new System.Windows.Forms.Label();
            this.ticketBuildPriorityDropDown = new System.Windows.Forms.ComboBox();
            this.ticketBuildPriorityLabel = new System.Windows.Forms.Label();
            this.ticketBuildAddButton = new System.Windows.Forms.Button();
            this.ticketBuildCancelButton = new System.Windows.Forms.Button();
            this.ticketBuildTitleTextBox = new System.Windows.Forms.TextBox();
            this.ticketBuildTime = new System.Windows.Forms.DateTimePicker();
            this.ticketBuildCategoryLabel = new System.Windows.Forms.Label();
            this.ticketBuildCategoryUpDown = new System.Windows.Forms.DomainUpDown();
            this.ticketBuildDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // headerBuildLabel
            // 
            this.headerBuildLabel.AutoSize = true;
            this.headerBuildLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerBuildLabel.Location = new System.Drawing.Point(180, 9);
            this.headerBuildLabel.Name = "headerBuildLabel";
            this.headerBuildLabel.Size = new System.Drawing.Size(212, 37);
            this.headerBuildLabel.TabIndex = 0;
            this.headerBuildLabel.Text = "Ticket Creation";
            // 
            // ticketBuildNumberLabel
            // 
            this.ticketBuildNumberLabel.AutoSize = true;
            this.ticketBuildNumberLabel.Location = new System.Drawing.Point(24, 65);
            this.ticketBuildNumberLabel.Name = "ticketBuildNumberLabel";
            this.ticketBuildNumberLabel.Size = new System.Drawing.Size(169, 30);
            this.ticketBuildNumberLabel.TabIndex = 1;
            this.ticketBuildNumberLabel.Text = "<ticket number>";
            // 
            // ticketBuildPriorityDropDown
            // 
            this.ticketBuildPriorityDropDown.BackColor = System.Drawing.SystemColors.Window;
            this.ticketBuildPriorityDropDown.FormattingEnabled = true;
            this.ticketBuildPriorityDropDown.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.ticketBuildPriorityDropDown.Location = new System.Drawing.Point(480, 136);
            this.ticketBuildPriorityDropDown.Name = "ticketBuildPriorityDropDown";
            this.ticketBuildPriorityDropDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ticketBuildPriorityDropDown.Size = new System.Drawing.Size(78, 38);
            this.ticketBuildPriorityDropDown.TabIndex = 2;
            this.ticketBuildPriorityDropDown.Text = "5";
            // 
            // ticketBuildPriorityLabel
            // 
            this.ticketBuildPriorityLabel.AutoSize = true;
            this.ticketBuildPriorityLabel.Location = new System.Drawing.Point(480, 103);
            this.ticketBuildPriorityLabel.Name = "ticketBuildPriorityLabel";
            this.ticketBuildPriorityLabel.Size = new System.Drawing.Size(78, 30);
            this.ticketBuildPriorityLabel.TabIndex = 3;
            this.ticketBuildPriorityLabel.Text = "Priority";
            // 
            // ticketBuildAddButton
            // 
            this.ticketBuildAddButton.BackColor = System.Drawing.Color.Transparent;
            this.ticketBuildAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.ticketBuildAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ticketBuildAddButton.Location = new System.Drawing.Point(48, 452);
            this.ticketBuildAddButton.Name = "ticketBuildAddButton";
            this.ticketBuildAddButton.Size = new System.Drawing.Size(130, 37);
            this.ticketBuildAddButton.TabIndex = 4;
            this.ticketBuildAddButton.Text = "Add Ticket";
            this.ticketBuildAddButton.UseVisualStyleBackColor = false;
            // 
            // ticketBuildCancelButton
            // 
            this.ticketBuildCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ticketBuildCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.ticketBuildCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ticketBuildCancelButton.Location = new System.Drawing.Point(370, 452);
            this.ticketBuildCancelButton.Name = "ticketBuildCancelButton";
            this.ticketBuildCancelButton.Size = new System.Drawing.Size(157, 37);
            this.ticketBuildCancelButton.TabIndex = 4;
            this.ticketBuildCancelButton.Text = "Cancel Ticket";
            this.ticketBuildCancelButton.UseVisualStyleBackColor = true;
            // 
            // ticketBuildTitleTextBox
            // 
            this.ticketBuildTitleTextBox.Location = new System.Drawing.Point(221, 65);
            this.ticketBuildTitleTextBox.Name = "ticketBuildTitleTextBox";
            this.ticketBuildTitleTextBox.PlaceholderText = "<Ticket Title>";
            this.ticketBuildTitleTextBox.Size = new System.Drawing.Size(337, 35);
            this.ticketBuildTitleTextBox.TabIndex = 5;
            // 
            // ticketBuildTime
            // 
            this.ticketBuildTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ticketBuildTime.Location = new System.Drawing.Point(48, 198);
            this.ticketBuildTime.Name = "ticketBuildTime";
            this.ticketBuildTime.Size = new System.Drawing.Size(127, 35);
            this.ticketBuildTime.TabIndex = 6;
            // 
            // ticketBuildCategoryLabel
            // 
            this.ticketBuildCategoryLabel.AutoSize = true;
            this.ticketBuildCategoryLabel.Location = new System.Drawing.Point(48, 103);
            this.ticketBuildCategoryLabel.Name = "ticketBuildCategoryLabel";
            this.ticketBuildCategoryLabel.Size = new System.Drawing.Size(96, 30);
            this.ticketBuildCategoryLabel.TabIndex = 3;
            this.ticketBuildCategoryLabel.Text = "Category";
            // 
            // ticketBuildCategoryUpDown
            // 
            this.ticketBuildCategoryUpDown.Items.Add("User Interface");
            this.ticketBuildCategoryUpDown.Items.Add("Maintenance");
            this.ticketBuildCategoryUpDown.Items.Add("Update");
            this.ticketBuildCategoryUpDown.Items.Add("Code Portability");
            this.ticketBuildCategoryUpDown.Items.Add("Features");
            this.ticketBuildCategoryUpDown.Items.Add("Performance");
            this.ticketBuildCategoryUpDown.Items.Add("Account Information");
            this.ticketBuildCategoryUpDown.Items.Add("Administration");
            this.ticketBuildCategoryUpDown.Location = new System.Drawing.Point(48, 139);
            this.ticketBuildCategoryUpDown.Name = "ticketBuildCategoryUpDown";
            this.ticketBuildCategoryUpDown.Size = new System.Drawing.Size(269, 35);
            this.ticketBuildCategoryUpDown.TabIndex = 7;
            // 
            // ticketBuildDescriptionRichTextBox
            // 
            this.ticketBuildDescriptionRichTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ticketBuildDescriptionRichTextBox.Location = new System.Drawing.Point(263, 224);
            this.ticketBuildDescriptionRichTextBox.Name = "ticketBuildDescriptionRichTextBox";
            this.ticketBuildDescriptionRichTextBox.Size = new System.Drawing.Size(264, 207);
            this.ticketBuildDescriptionRichTextBox.TabIndex = 8;
            this.ticketBuildDescriptionRichTextBox.Text = "";
            // 
            // CreateTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 501);
            this.Controls.Add(this.ticketBuildDescriptionRichTextBox);
            this.Controls.Add(this.ticketBuildCategoryUpDown);
            this.Controls.Add(this.ticketBuildCategoryLabel);
            this.Controls.Add(this.ticketBuildTime);
            this.Controls.Add(this.ticketBuildTitleTextBox);
            this.Controls.Add(this.ticketBuildCancelButton);
            this.Controls.Add(this.ticketBuildAddButton);
            this.Controls.Add(this.ticketBuildPriorityLabel);
            this.Controls.Add(this.ticketBuildPriorityDropDown);
            this.Controls.Add(this.ticketBuildNumberLabel);
            this.Controls.Add(this.headerBuildLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTicketForm";
            this.Text = "Create Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerBuildLabel;
        private System.Windows.Forms.Label ticketBuildNumberLabel;
        private System.Windows.Forms.ComboBox ticketBuildPriorityDropDown;
        private System.Windows.Forms.Label ticketBuildPriorityLabel;
        private System.Windows.Forms.Button ticketBuildAddButton;
        private System.Windows.Forms.Button ticketBuildCancelButton;
        private System.Windows.Forms.TextBox ticketBuildTitleTextBox;
        private System.Windows.Forms.DateTimePicker ticketBuildTime;
        private System.Windows.Forms.Label ticketBuildCategoryLabel;
        private System.Windows.Forms.DomainUpDown ticketBuildCategoryUpDown;
        private System.Windows.Forms.RichTextBox ticketBuildDescriptionRichTextBox;
    }
}
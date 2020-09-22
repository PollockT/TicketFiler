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
            // ViewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 600);
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
    }
}
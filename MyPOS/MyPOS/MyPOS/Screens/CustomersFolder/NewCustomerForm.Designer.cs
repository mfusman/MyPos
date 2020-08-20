namespace MyPOS.Screens.CustomersFolder
{
    partial class NewCustomerForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.DefineNewButton = new MetroFramework.Controls.MetroButton();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerMobileTextBox = new System.Windows.Forms.TextBox();
            this.CustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(61, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer Name  :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(61, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Customer Mobile :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(61, 195);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Address  :";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(190, 308);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(247, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DefineNewButton
            // 
            this.DefineNewButton.Location = new System.Drawing.Point(190, 357);
            this.DefineNewButton.Name = "DefineNewButton";
            this.DefineNewButton.Size = new System.Drawing.Size(107, 23);
            this.DefineNewButton.TabIndex = 7;
            this.DefineNewButton.Text = "New";
            this.DefineNewButton.UseSelectable = true;
            this.DefineNewButton.Click += new System.EventHandler(this.DefineNewButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(326, 357);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(111, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerNameTextBox.Location = new System.Drawing.Point(190, 95);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(237, 20);
            this.CustomerNameTextBox.TabIndex = 0;
            // 
            // CustomerMobileTextBox
            // 
            this.CustomerMobileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerMobileTextBox.Location = new System.Drawing.Point(190, 145);
            this.CustomerMobileTextBox.Name = "CustomerMobileTextBox";
            this.CustomerMobileTextBox.Size = new System.Drawing.Size(152, 20);
            this.CustomerMobileTextBox.TabIndex = 1;
            // 
            // CustomerAddressTextBox
            // 
            this.CustomerAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerAddressTextBox.Location = new System.Drawing.Point(190, 195);
            this.CustomerAddressTextBox.Multiline = true;
            this.CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            this.CustomerAddressTextBox.Size = new System.Drawing.Size(247, 94);
            this.CustomerAddressTextBox.TabIndex = 2;
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.CustomerAddressTextBox);
            this.Controls.Add(this.CustomerMobileTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DefineNewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "NewCustomerForm";
            this.Text = "New Customer";
            this.Load += new System.EventHandler(this.NewCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroButton DefineNewButton;
        private MetroFramework.Controls.MetroButton CloseButton;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox CustomerMobileTextBox;
        private System.Windows.Forms.TextBox CustomerAddressTextBox;
    }
}
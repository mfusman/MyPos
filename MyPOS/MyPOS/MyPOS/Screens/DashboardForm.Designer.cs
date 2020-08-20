namespace MyPOS.Screens
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.ExitButton = new MetroFramework.Controls.MetroButton();
            this.CustomReportsButton = new MetroFramework.Controls.MetroButton();
            this.OrdersRecordButton = new MetroFramework.Controls.MetroButton();
            this.ChangePasswordButton = new MetroFramework.Controls.MetroButton();
            this.NewOrderButton = new MetroFramework.Controls.MetroButton();
            this.CustomersButton = new MetroFramework.Controls.MetroButton();
            this.CattegoriesButton = new MetroFramework.Controls.MetroButton();
            this.StockButton = new MetroFramework.Controls.MetroButton();
            this.ManageProductsButton = new MetroFramework.Controls.MetroButton();
            this.DefineProductsButton = new MetroFramework.Controls.MetroButton();
            this.CustomerRecordButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gray;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButton.Location = new System.Drawing.Point(644, 345);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 97);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit Application";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButton.UseCustomBackColor = true;
            this.ExitButton.UseSelectable = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CustomReportsButton
            // 
            this.CustomReportsButton.BackColor = System.Drawing.Color.Gray;
            this.CustomReportsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomReportsButton.BackgroundImage")));
            this.CustomReportsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CustomReportsButton.Location = new System.Drawing.Point(479, 345);
            this.CustomReportsButton.Name = "CustomReportsButton";
            this.CustomReportsButton.Size = new System.Drawing.Size(140, 97);
            this.CustomReportsButton.TabIndex = 8;
            this.CustomReportsButton.Text = "Custom Reports";
            this.CustomReportsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomReportsButton.UseCustomBackColor = true;
            this.CustomReportsButton.UseSelectable = true;
            this.CustomReportsButton.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // OrdersRecordButton
            // 
            this.OrdersRecordButton.BackColor = System.Drawing.Color.Gray;
            this.OrdersRecordButton.BackgroundImage = global::MyPOS.Properties.Resources.order;
            this.OrdersRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrdersRecordButton.Location = new System.Drawing.Point(479, 228);
            this.OrdersRecordButton.Name = "OrdersRecordButton";
            this.OrdersRecordButton.Size = new System.Drawing.Size(140, 97);
            this.OrdersRecordButton.TabIndex = 7;
            this.OrdersRecordButton.Text = "Orders Record";
            this.OrdersRecordButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OrdersRecordButton.UseCustomBackColor = true;
            this.OrdersRecordButton.UseSelectable = true;
            this.OrdersRecordButton.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.Gray;
            this.ChangePasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangePasswordButton.BackgroundImage")));
            this.ChangePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChangePasswordButton.Location = new System.Drawing.Point(644, 228);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(140, 97);
            this.ChangePasswordButton.TabIndex = 6;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChangePasswordButton.UseCustomBackColor = true;
            this.ChangePasswordButton.UseSelectable = true;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.BackColor = System.Drawing.Color.Gray;
            this.NewOrderButton.BackgroundImage = global::MyPOS.Properties.Resources.buy;
            this.NewOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewOrderButton.Location = new System.Drawing.Point(479, 114);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(305, 97);
            this.NewOrderButton.TabIndex = 5;
            this.NewOrderButton.Text = "Add New Sales Order ";
            this.NewOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewOrderButton.UseCustomBackColor = true;
            this.NewOrderButton.UseSelectable = true;
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.Gray;
            this.CustomersButton.BackgroundImage = global::MyPOS.Properties.Resources.consumer;
            this.CustomersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CustomersButton.Location = new System.Drawing.Point(123, 345);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(140, 97);
            this.CustomersButton.TabIndex = 4;
            this.CustomersButton.Text = "Customers Management";
            this.CustomersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomersButton.UseCustomBackColor = true;
            this.CustomersButton.UseSelectable = true;
            this.CustomersButton.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // CattegoriesButton
            // 
            this.CattegoriesButton.BackColor = System.Drawing.Color.Gray;
            this.CattegoriesButton.BackgroundImage = global::MyPOS.Properties.Resources.category;
            this.CattegoriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CattegoriesButton.Location = new System.Drawing.Point(288, 228);
            this.CattegoriesButton.Name = "CattegoriesButton";
            this.CattegoriesButton.Size = new System.Drawing.Size(140, 97);
            this.CattegoriesButton.TabIndex = 3;
            this.CattegoriesButton.Text = "Manage Categories";
            this.CattegoriesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CattegoriesButton.UseCustomBackColor = true;
            this.CattegoriesButton.UseSelectable = true;
            // 
            // StockButton
            // 
            this.StockButton.BackColor = System.Drawing.Color.Gray;
            this.StockButton.BackgroundImage = global::MyPOS.Properties.Resources.factory;
            this.StockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StockButton.Location = new System.Drawing.Point(123, 228);
            this.StockButton.Name = "StockButton";
            this.StockButton.Size = new System.Drawing.Size(140, 97);
            this.StockButton.TabIndex = 2;
            this.StockButton.Text = "Stock Management";
            this.StockButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StockButton.UseCustomBackColor = true;
            this.StockButton.UseSelectable = true;
            this.StockButton.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // ManageProductsButton
            // 
            this.ManageProductsButton.BackColor = System.Drawing.Color.Gray;
            this.ManageProductsButton.BackgroundImage = global::MyPOS.Properties.Resources.product;
            this.ManageProductsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ManageProductsButton.Location = new System.Drawing.Point(288, 114);
            this.ManageProductsButton.Name = "ManageProductsButton";
            this.ManageProductsButton.Size = new System.Drawing.Size(140, 97);
            this.ManageProductsButton.TabIndex = 1;
            this.ManageProductsButton.Text = "Manage Products";
            this.ManageProductsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ManageProductsButton.UseCustomBackColor = true;
            this.ManageProductsButton.UseSelectable = true;
            this.ManageProductsButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // DefineProductsButton
            // 
            this.DefineProductsButton.BackColor = System.Drawing.Color.DimGray;
            this.DefineProductsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DefineProductsButton.BackgroundImage")));
            this.DefineProductsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DefineProductsButton.Location = new System.Drawing.Point(123, 114);
            this.DefineProductsButton.Name = "DefineProductsButton";
            this.DefineProductsButton.Size = new System.Drawing.Size(140, 97);
            this.DefineProductsButton.TabIndex = 0;
            this.DefineProductsButton.Text = "Define Products";
            this.DefineProductsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DefineProductsButton.UseCustomBackColor = true;
            this.DefineProductsButton.UseSelectable = true;
            this.DefineProductsButton.Click += new System.EventHandler(this.DefineProductsButton_Click);
            // 
            // CustomerRecordButton
            // 
            this.CustomerRecordButton.BackColor = System.Drawing.Color.Gray;
            this.CustomerRecordButton.BackgroundImage = global::MyPOS.Properties.Resources.consumer;
            this.CustomerRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CustomerRecordButton.Location = new System.Drawing.Point(288, 345);
            this.CustomerRecordButton.Name = "CustomerRecordButton";
            this.CustomerRecordButton.Size = new System.Drawing.Size(140, 97);
            this.CustomerRecordButton.TabIndex = 10;
            this.CustomerRecordButton.Text = "Customer Record";
            this.CustomerRecordButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerRecordButton.UseCustomBackColor = true;
            this.CustomerRecordButton.UseSelectable = true;
            this.CustomerRecordButton.Click += new System.EventHandler(this.CustomerRecordButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(916, 515);
            this.Controls.Add(this.CustomerRecordButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CustomReportsButton);
            this.Controls.Add(this.OrdersRecordButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.CattegoriesButton);
            this.Controls.Add(this.StockButton);
            this.Controls.Add(this.ManageProductsButton);
            this.Controls.Add(this.DefineProductsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(916, 515);
            this.Name = "DashboardForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MyPOS | DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton DefineProductsButton;
        private MetroFramework.Controls.MetroButton ManageProductsButton;
        private MetroFramework.Controls.MetroButton StockButton;
        private MetroFramework.Controls.MetroButton CattegoriesButton;
        private MetroFramework.Controls.MetroButton CustomersButton;
        private MetroFramework.Controls.MetroButton NewOrderButton;
        private MetroFramework.Controls.MetroButton ChangePasswordButton;
        private MetroFramework.Controls.MetroButton OrdersRecordButton;
        private MetroFramework.Controls.MetroButton CustomReportsButton;
        private MetroFramework.Controls.MetroButton ExitButton;
        private MetroFramework.Controls.MetroButton CustomerRecordButton;
    }
}
namespace MyPOS.Screens.ProductsFolder
{
    partial class DefineProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineProductScreen));
            this.ProductNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DefineNewButton = new MetroFramework.Controls.MetroButton();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.PurchasePriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SalesPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SizeDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectAllSizeButton = new System.Windows.Forms.Button();
            this.DeselectAllSizeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SizeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ProductNameTextBox.CustomButton.Image = null;
            this.ProductNameTextBox.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.ProductNameTextBox.CustomButton.Name = "";
            this.ProductNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductNameTextBox.CustomButton.TabIndex = 1;
            this.ProductNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductNameTextBox.CustomButton.UseSelectable = true;
            this.ProductNameTextBox.CustomButton.Visible = false;
            this.ProductNameTextBox.Lines = new string[0];
            this.ProductNameTextBox.Location = new System.Drawing.Point(268, 98);
            this.ProductNameTextBox.MaxLength = 32767;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.PasswordChar = '\0';
            this.ProductNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameTextBox.SelectedText = "";
            this.ProductNameTextBox.SelectionLength = 0;
            this.ProductNameTextBox.SelectionStart = 0;
            this.ProductNameTextBox.ShortcutsEnabled = true;
            this.ProductNameTextBox.Size = new System.Drawing.Size(240, 23);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.UseSelectable = true;
            this.ProductNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(93, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Product Name :";
            // 
            // DefineNewButton
            // 
            this.DefineNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefineNewButton.BackColor = System.Drawing.Color.Gray;
            this.DefineNewButton.Location = new System.Drawing.Point(533, 454);
            this.DefineNewButton.Name = "DefineNewButton";
            this.DefineNewButton.Size = new System.Drawing.Size(293, 38);
            this.DefineNewButton.TabIndex = 8;
            this.DefineNewButton.Text = "Define New";
            this.DefineNewButton.UseCustomBackColor = true;
            this.DefineNewButton.UseSelectable = true;
            this.DefineNewButton.Click += new System.EventHandler(this.DefineNewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.Gray;
            this.SaveButton.Location = new System.Drawing.Point(96, 403);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(309, 38);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseCustomBackColor = true;
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Location = new System.Drawing.Point(96, 454);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(309, 38);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseCustomBackColor = true;
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PurchasePriceTextBox
            // 
            this.PurchasePriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.PurchasePriceTextBox.CustomButton.Image = null;
            this.PurchasePriceTextBox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.PurchasePriceTextBox.CustomButton.Name = "";
            this.PurchasePriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PurchasePriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PurchasePriceTextBox.CustomButton.TabIndex = 1;
            this.PurchasePriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PurchasePriceTextBox.CustomButton.UseSelectable = true;
            this.PurchasePriceTextBox.CustomButton.Visible = false;
            this.PurchasePriceTextBox.Lines = new string[0];
            this.PurchasePriceTextBox.Location = new System.Drawing.Point(268, 282);
            this.PurchasePriceTextBox.MaxLength = 32767;
            this.PurchasePriceTextBox.Name = "PurchasePriceTextBox";
            this.PurchasePriceTextBox.PasswordChar = '\0';
            this.PurchasePriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PurchasePriceTextBox.SelectedText = "";
            this.PurchasePriceTextBox.SelectionLength = 0;
            this.PurchasePriceTextBox.SelectionStart = 0;
            this.PurchasePriceTextBox.ShortcutsEnabled = true;
            this.PurchasePriceTextBox.Size = new System.Drawing.Size(137, 23);
            this.PurchasePriceTextBox.TabIndex = 3;
            this.PurchasePriceTextBox.UseSelectable = true;
            this.PurchasePriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PurchasePriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SalesPriceTextBox
            // 
            this.SalesPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.SalesPriceTextBox.CustomButton.Image = null;
            this.SalesPriceTextBox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.SalesPriceTextBox.CustomButton.Name = "";
            this.SalesPriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SalesPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SalesPriceTextBox.CustomButton.TabIndex = 1;
            this.SalesPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SalesPriceTextBox.CustomButton.UseSelectable = true;
            this.SalesPriceTextBox.CustomButton.Visible = false;
            this.SalesPriceTextBox.Lines = new string[0];
            this.SalesPriceTextBox.Location = new System.Drawing.Point(268, 337);
            this.SalesPriceTextBox.MaxLength = 32767;
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.PasswordChar = '\0';
            this.SalesPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SalesPriceTextBox.SelectedText = "";
            this.SalesPriceTextBox.SelectionLength = 0;
            this.SalesPriceTextBox.SelectionStart = 0;
            this.SalesPriceTextBox.ShortcutsEnabled = true;
            this.SalesPriceTextBox.Size = new System.Drawing.Size(137, 23);
            this.SalesPriceTextBox.TabIndex = 4;
            this.SalesPriceTextBox.UseSelectable = true;
            this.SalesPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SalesPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(93, 163);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Category :";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(93, 221);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Product Supplier :";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(93, 282);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Purchase Price :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(93, 337);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Sales Price :";
            // 
            // SizeDataGridView
            // 
            this.SizeDataGridView.AllowUserToAddRows = false;
            this.SizeDataGridView.AllowUserToDeleteRows = false;
            this.SizeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SizeDataGridView.Location = new System.Drawing.Point(533, 98);
            this.SizeDataGridView.Name = "SizeDataGridView";
            this.SizeDataGridView.RowHeadersVisible = false;
            this.SizeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SizeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SizeDataGridView.Size = new System.Drawing.Size(293, 343);
            this.SizeDataGridView.TabIndex = 5;
            this.SizeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SelectAllSizeButton
            // 
            this.SelectAllSizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAllSizeButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SelectAllSizeButton.Location = new System.Drawing.Point(844, 98);
            this.SelectAllSizeButton.Name = "SelectAllSizeButton";
            this.SelectAllSizeButton.Size = new System.Drawing.Size(32, 32);
            this.SelectAllSizeButton.TabIndex = 9;
            this.SelectAllSizeButton.Text = "S";
            this.SelectAllSizeButton.UseVisualStyleBackColor = false;
            this.SelectAllSizeButton.Click += new System.EventHandler(this.SelectAllSizeButton_Click);
            // 
            // DeselectAllSizeButton
            // 
            this.DeselectAllSizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeselectAllSizeButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DeselectAllSizeButton.Location = new System.Drawing.Point(844, 146);
            this.DeselectAllSizeButton.Name = "DeselectAllSizeButton";
            this.DeselectAllSizeButton.Size = new System.Drawing.Size(32, 32);
            this.DeselectAllSizeButton.TabIndex = 10;
            this.DeselectAllSizeButton.Text = "D";
            this.DeselectAllSizeButton.UseVisualStyleBackColor = false;
            this.DeselectAllSizeButton.Click += new System.EventHandler(this.DeselectAllSizeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SupplierComboBox);
            this.groupBox1.Controls.Add(this.CategoryComboBox);
            this.groupBox1.Location = new System.Drawing.Point(69, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 428);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(199, 85);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(189, 21);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SupplierComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(199, 143);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(189, 21);
            this.SupplierComboBox.TabIndex = 2;
            // 
            // DefineProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 515);
            this.Controls.Add(this.DeselectAllSizeButton);
            this.Controls.Add(this.SelectAllSizeButton);
            this.Controls.Add(this.SizeDataGridView);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.SalesPriceTextBox);
            this.Controls.Add(this.PurchasePriceTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DefineNewButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DefineProductScreen";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Define Products";
            this.Load += new System.EventHandler(this.DefineProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SizeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox ProductNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton DefineNewButton;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroTextBox PurchasePriceTextBox;
        private MetroFramework.Controls.MetroTextBox SalesPriceTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridView SizeDataGridView;
        private System.Windows.Forms.Button SelectAllSizeButton;
        private System.Windows.Forms.Button DeselectAllSizeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}
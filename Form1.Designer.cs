namespace Software_I___C____C968
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAddParts = new Button();
            BtnModifyParts = new Button();
            BtnDeleteParts = new Button();
            BtnDeleteProducts = new Button();
            BtnModifyProducts = new Button();
            BtnAddProducts = new Button();
            BtnExit = new Button();
            LstProducts = new ListBox();
            BtnSearchParts = new Button();
            BtnSearchProducts = new Button();
            TbProductsSearch = new TextBox();
            TbPartsSearch = new TextBox();
            LblMainTitle = new Label();
            LblPartsTitle = new Label();
            LblProducts = new Label();
            DgvParts = new DataGridView();
            DgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvProducts).BeginInit();
            SuspendLayout();
            // 
            // BtnAddParts
            // 
            BtnAddParts.Location = new Point(400, 514);
            BtnAddParts.Name = "BtnAddParts";
            BtnAddParts.Size = new Size(112, 34);
            BtnAddParts.TabIndex = 0;
            BtnAddParts.Text = "Add";
            BtnAddParts.UseVisualStyleBackColor = true;
            BtnAddParts.Click += BtnAddParts_Click;
            // 
            // BtnModifyParts
            // 
            BtnModifyParts.Location = new Point(518, 514);
            BtnModifyParts.Name = "BtnModifyParts";
            BtnModifyParts.Size = new Size(112, 34);
            BtnModifyParts.TabIndex = 1;
            BtnModifyParts.Text = "Modify";
            BtnModifyParts.UseVisualStyleBackColor = true;
            BtnModifyParts.Click += BtnModifyParts_Click;
            // 
            // BtnDeleteParts
            // 
            BtnDeleteParts.Location = new Point(636, 514);
            BtnDeleteParts.Name = "BtnDeleteParts";
            BtnDeleteParts.Size = new Size(112, 34);
            BtnDeleteParts.TabIndex = 2;
            BtnDeleteParts.Text = "Delete";
            BtnDeleteParts.UseVisualStyleBackColor = true;
            BtnDeleteParts.Click += BtnDeleteParts_Click;
            // 
            // BtnDeleteProducts
            // 
            BtnDeleteProducts.Location = new Point(1376, 514);
            BtnDeleteProducts.Name = "BtnDeleteProducts";
            BtnDeleteProducts.Size = new Size(112, 34);
            BtnDeleteProducts.TabIndex = 5;
            BtnDeleteProducts.Text = "Delete";
            BtnDeleteProducts.UseVisualStyleBackColor = true;
            BtnDeleteProducts.Click += BtnDeleteProducts_Click;
            // 
            // BtnModifyProducts
            // 
            BtnModifyProducts.Location = new Point(1258, 514);
            BtnModifyProducts.Name = "BtnModifyProducts";
            BtnModifyProducts.Size = new Size(112, 34);
            BtnModifyProducts.TabIndex = 4;
            BtnModifyProducts.Text = "Modify";
            BtnModifyProducts.UseVisualStyleBackColor = true;
            BtnModifyProducts.Click += BtnModifyProducts_Click;
            // 
            // BtnAddProducts
            // 
            BtnAddProducts.Location = new Point(1140, 514);
            BtnAddProducts.Name = "BtnAddProducts";
            BtnAddProducts.Size = new Size(112, 34);
            BtnAddProducts.TabIndex = 3;
            BtnAddProducts.Text = "Add";
            BtnAddProducts.UseVisualStyleBackColor = true;
            BtnAddProducts.Click += BtnAddProducts_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(1376, 604);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(112, 34);
            BtnExit.TabIndex = 7;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // LstProducts
            // 
            LstProducts.FormattingEnabled = true;
            LstProducts.ItemHeight = 25;
            LstProducts.Location = new Point(781, 161);
            LstProducts.Name = "LstProducts";
            LstProducts.Size = new Size(1, 4);
            LstProducts.TabIndex = 9;
            // 
            // BtnSearchParts
            // 
            BtnSearchParts.Location = new Point(390, 99);
            BtnSearchParts.Name = "BtnSearchParts";
            BtnSearchParts.Size = new Size(78, 34);
            BtnSearchParts.TabIndex = 10;
            BtnSearchParts.Text = "Search";
            BtnSearchParts.UseVisualStyleBackColor = true;
            BtnSearchParts.Click += BtnSearchParts_Click;
            // 
            // BtnSearchProducts
            // 
            BtnSearchProducts.Location = new Point(1129, 101);
            BtnSearchProducts.Name = "BtnSearchProducts";
            BtnSearchProducts.Size = new Size(78, 34);
            BtnSearchProducts.TabIndex = 11;
            BtnSearchProducts.Text = "Search";
            BtnSearchProducts.UseVisualStyleBackColor = true;
            BtnSearchProducts.Click += BtnSearchProducts_Click;
            // 
            // TbProductsSearch
            // 
            TbProductsSearch.Location = new Point(1227, 101);
            TbProductsSearch.Name = "TbProductsSearch";
            TbProductsSearch.Size = new Size(261, 31);
            TbProductsSearch.TabIndex = 12;
            // 
            // TbPartsSearch
            // 
            TbPartsSearch.Location = new Point(487, 102);
            TbPartsSearch.Name = "TbPartsSearch";
            TbPartsSearch.Size = new Size(261, 31);
            TbPartsSearch.TabIndex = 13;
            // 
            // LblMainTitle
            // 
            LblMainTitle.AutoSize = true;
            LblMainTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblMainTitle.Location = new Point(3, 7);
            LblMainTitle.Name = "LblMainTitle";
            LblMainTitle.Size = new Size(348, 32);
            LblMainTitle.TabIndex = 14;
            LblMainTitle.Text = "Inventory Management System";
            // 
            // LblPartsTitle
            // 
            LblPartsTitle.AutoSize = true;
            LblPartsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblPartsTitle.Location = new Point(35, 126);
            LblPartsTitle.Name = "LblPartsTitle";
            LblPartsTitle.Size = new Size(64, 32);
            LblPartsTitle.TabIndex = 15;
            LblPartsTitle.Text = "Parts";
            // 
            // LblProducts
            // 
            LblProducts.AutoSize = true;
            LblProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblProducts.Location = new Point(781, 126);
            LblProducts.Name = "LblProducts";
            LblProducts.Size = new Size(106, 32);
            LblProducts.TabIndex = 16;
            LblProducts.Text = "Products";
            // 
            // DgvParts
            // 
            DgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvParts.Location = new Point(36, 163);
            DgvParts.Margin = new Padding(2);
            DgvParts.Name = "DgvParts";
            DgvParts.RowHeadersWidth = 82;
            DgvParts.RowTemplate.Height = 41;
            DgvParts.Size = new Size(712, 328);
            DgvParts.TabIndex = 17;
            // 
            // DgvProducts
            // 
            DgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProducts.Location = new Point(781, 161);
            DgvProducts.Margin = new Padding(2);
            DgvProducts.Name = "DgvProducts";
            DgvProducts.RowHeadersWidth = 82;
            DgvProducts.RowTemplate.Height = 41;
            DgvProducts.Size = new Size(712, 328);
            DgvProducts.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 672);
            Controls.Add(DgvProducts);
            Controls.Add(DgvParts);
            Controls.Add(LblProducts);
            Controls.Add(LblPartsTitle);
            Controls.Add(LblMainTitle);
            Controls.Add(TbPartsSearch);
            Controls.Add(TbProductsSearch);
            Controls.Add(BtnSearchProducts);
            Controls.Add(BtnSearchParts);
            Controls.Add(LstProducts);
            Controls.Add(BtnExit);
            Controls.Add(BtnDeleteProducts);
            Controls.Add(BtnModifyProducts);
            Controls.Add(BtnAddProducts);
            Controls.Add(BtnDeleteParts);
            Controls.Add(BtnModifyParts);
            Controls.Add(BtnAddParts);
            Name = "Form1";
            Text = "Main Screen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAddParts;
        private Button BtnModifyParts;
        private Button BtnDeleteParts;
        private Button BtnDeleteProducts;
        private Button BtnModifyProducts;
        private Button BtnAddProducts;
        private Button BtnExit;
        private ListBox LstProducts;
        private Button BtnSearchParts;
        private Button BtnSearchProducts;
        private TextBox TbProductsSearch;
        private TextBox TbPartsSearch;
        private Label LblMainTitle;
        private Label LblPartsTitle;
        private Label LblProducts;
        private DataGridView DgvParts;
        private DataGridView DgvProducts;
    }
}
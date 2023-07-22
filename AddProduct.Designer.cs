namespace Software_I___C____C968
{
    partial class AddProduct
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
            BtnAdd = new Button();
            BtnDelete = new Button();
            BtnSave = new Button();
            BtnCancel = new Button();
            GvPartsAssociated = new DataGridView();
            GvCandidateParts = new DataGridView();
            BtnSearch = new Button();
            TbProductsSearch = new TextBox();
            LblMin = new Label();
            LblMax = new Label();
            LblPrice = new Label();
            label3 = new Label();
            LblName = new Label();
            LblId = new Label();
            TbMin = new TextBox();
            TbMax = new TextBox();
            TbPriceCost = new TextBox();
            TbInventory = new TextBox();
            TbName = new TextBox();
            TbId = new TextBox();
            LblTitle = new Label();
            LblCandidateParts = new Label();
            LblPartsAssociated = new Label();
            ((System.ComponentModel.ISupportInitialize)GvPartsAssociated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GvCandidateParts).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(1173, 401);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(150, 46);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(1173, 761);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(150, 46);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(988, 829);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(150, 46);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(1173, 829);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(150, 46);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // GvPartsAssociated
            // 
            GvPartsAssociated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvPartsAssociated.Location = new Point(583, 473);
            GvPartsAssociated.Name = "GvPartsAssociated";
            GvPartsAssociated.RowHeadersWidth = 82;
            GvPartsAssociated.RowTemplate.Height = 41;
            GvPartsAssociated.Size = new Size(794, 266);
            GvPartsAssociated.TabIndex = 4;
            // 
            // GvCandidateParts
            // 
            GvCandidateParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvCandidateParts.Location = new Point(583, 117);
            GvCandidateParts.Name = "GvCandidateParts";
            GvCandidateParts.RowHeadersWidth = 82;
            GvCandidateParts.RowTemplate.Height = 41;
            GvCandidateParts.Size = new Size(794, 266);
            GvCandidateParts.TabIndex = 5;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(859, 52);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(150, 46);
            BtnSearch.TabIndex = 6;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TbProductsSearch
            // 
            TbProductsSearch.Location = new Point(1039, 56);
            TbProductsSearch.Margin = new Padding(4);
            TbProductsSearch.Name = "TbProductsSearch";
            TbProductsSearch.Size = new Size(338, 39);
            TbProductsSearch.TabIndex = 13;
            // 
            // LblMin
            // 
            LblMin.AutoSize = true;
            LblMin.Location = new Point(292, 551);
            LblMin.Margin = new Padding(4, 0, 4, 0);
            LblMin.Name = "LblMin";
            LblMin.Size = new Size(56, 32);
            LblMin.TabIndex = 30;
            LblMin.Text = "Min";
            LblMin.Click += LblMin_Click;
            // 
            // LblMax
            // 
            LblMax.AutoSize = true;
            LblMax.Location = new Point(33, 551);
            LblMax.Margin = new Padding(4, 0, 4, 0);
            LblMax.Name = "LblMax";
            LblMax.Size = new Size(59, 32);
            LblMax.TabIndex = 29;
            LblMax.Text = "Max";
            LblMax.Click += LblMax_Click;
            // 
            // LblPrice
            // 
            LblPrice.AutoSize = true;
            LblPrice.Location = new Point(33, 487);
            LblPrice.Margin = new Padding(4, 0, 4, 0);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(65, 32);
            LblPrice.TabIndex = 28;
            LblPrice.Text = "Price";
            LblPrice.Click += LblPriceCost_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 416);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 27;
            label3.Text = "Inventory";
            label3.Click += label3_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(33, 348);
            LblName.Margin = new Padding(4, 0, 4, 0);
            LblName.Name = "LblName";
            LblName.Size = new Size(78, 32);
            LblName.TabIndex = 26;
            LblName.Text = "Name";
            LblName.Click += LblName_Click;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(33, 280);
            LblId.Margin = new Padding(4, 0, 4, 0);
            LblId.Name = "LblId";
            LblId.Size = new Size(37, 32);
            LblId.TabIndex = 25;
            LblId.Text = "ID";
            LblId.Click += LblId_Click;
            // 
            // TbMin
            // 
            TbMin.Location = new Point(395, 548);
            TbMin.Margin = new Padding(4);
            TbMin.Name = "TbMin";
            TbMin.Size = new Size(129, 39);
            TbMin.TabIndex = 24;
            TbMin.TextChanged += TbMin_TextChanged;
            // 
            // TbMax
            // 
            TbMax.Location = new Point(114, 548);
            TbMax.Margin = new Padding(4);
            TbMax.Name = "TbMax";
            TbMax.Size = new Size(129, 39);
            TbMax.TabIndex = 23;
            TbMax.TextChanged += TbMax_TextChanged;
            // 
            // TbPriceCost
            // 
            TbPriceCost.Location = new Point(163, 480);
            TbPriceCost.Margin = new Padding(4);
            TbPriceCost.Name = "TbPriceCost";
            TbPriceCost.Size = new Size(259, 39);
            TbPriceCost.TabIndex = 22;
            TbPriceCost.TextChanged += TbPriceCost_TextChanged;
            // 
            // TbInventory
            // 
            TbInventory.Location = new Point(163, 412);
            TbInventory.Margin = new Padding(4);
            TbInventory.Name = "TbInventory";
            TbInventory.Size = new Size(259, 39);
            TbInventory.TabIndex = 21;
            TbInventory.TextChanged += TbInventory_TextChanged;
            // 
            // TbName
            // 
            TbName.Location = new Point(163, 344);
            TbName.Margin = new Padding(4);
            TbName.Name = "TbName";
            TbName.Size = new Size(259, 39);
            TbName.TabIndex = 20;
            TbName.TextChanged += TbName_TextChanged;
            // 
            // TbId
            // 
            TbId.Location = new Point(163, 276);
            TbId.Margin = new Padding(4);
            TbId.Name = "TbId";
            TbId.Size = new Size(259, 39);
            TbId.TabIndex = 19;
            TbId.TextChanged += TbId_TextChanged;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitle.Location = new Point(44, 20);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(199, 45);
            LblTitle.TabIndex = 31;
            LblTitle.Text = "Add Product";
            // 
            // LblCandidateParts
            // 
            LblCandidateParts.AutoSize = true;
            LblCandidateParts.Location = new Point(583, 82);
            LblCandidateParts.Name = "LblCandidateParts";
            LblCandidateParts.Size = new Size(213, 32);
            LblCandidateParts.TabIndex = 32;
            LblCandidateParts.Text = "All Candidate Parts";
            LblCandidateParts.Click += label1_Click;
            // 
            // LblPartsAssociated
            // 
            LblPartsAssociated.AutoSize = true;
            LblPartsAssociated.Location = new Point(583, 438);
            LblPartsAssociated.Name = "LblPartsAssociated";
            LblPartsAssociated.Size = new Size(370, 32);
            LblPartsAssociated.TabIndex = 33;
            LblPartsAssociated.Text = "Parts Associated with this Product";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 915);
            Controls.Add(LblPartsAssociated);
            Controls.Add(LblCandidateParts);
            Controls.Add(LblTitle);
            Controls.Add(LblMin);
            Controls.Add(LblMax);
            Controls.Add(LblPrice);
            Controls.Add(label3);
            Controls.Add(LblName);
            Controls.Add(LblId);
            Controls.Add(TbMin);
            Controls.Add(TbMax);
            Controls.Add(TbPriceCost);
            Controls.Add(TbInventory);
            Controls.Add(TbName);
            Controls.Add(TbId);
            Controls.Add(TbProductsSearch);
            Controls.Add(BtnSearch);
            Controls.Add(GvCandidateParts);
            Controls.Add(GvPartsAssociated);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Name = "Product";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)GvPartsAssociated).EndInit();
            ((System.ComponentModel.ISupportInitialize)GvCandidateParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnSave;
        private Button BtnCancel;
        private DataGridView GvPartsAssociated;
        private DataGridView GvCandidateParts;
        private Button BtnSearch;
        private TextBox TbProductsSearch;
        private Label LblMin;
        private Label LblMax;
        private Label LblPrice;
        private Label label3;
        private Label LblName;
        private Label LblId;
        private TextBox TbMin;
        private TextBox TbMax;
        private TextBox TbPriceCost;
        private TextBox TbInventory;
        private TextBox TbName;
        private TextBox TbId;
        private Label LblTitle;
        private Label LblCandidateParts;
        private Label LblPartsAssociated;
    }
}
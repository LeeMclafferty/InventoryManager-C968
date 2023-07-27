namespace Software_I___C____C968
{
    partial class ModifyProduct
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
            LblPartsAssociated = new Label();
            LblCandidateParts = new Label();
            LblTitle = new Label();
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
            TbProductsSearch = new TextBox();
            BtnSearch = new Button();
            DgvPartsAssociated = new DataGridView();
            BtnCancel = new Button();
            BtnSave = new Button();
            BtnDelete = new Button();
            BtnAdd = new Button();
            DgvCandidateParts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvPartsAssociated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvCandidateParts).BeginInit();
            SuspendLayout();
            // 
            // LblPartsAssociated
            // 
            LblPartsAssociated.AutoSize = true;
            LblPartsAssociated.Location = new Point(449, 342);
            LblPartsAssociated.Name = "LblPartsAssociated";
            LblPartsAssociated.Size = new Size(279, 25);
            LblPartsAssociated.TabIndex = 56;
            LblPartsAssociated.Text = "Parts Associated with this Product";
            // 
            // LblCandidateParts
            // 
            LblCandidateParts.AutoSize = true;
            LblCandidateParts.Location = new Point(449, 63);
            LblCandidateParts.Name = "LblCandidateParts";
            LblCandidateParts.Size = new Size(160, 25);
            LblCandidateParts.TabIndex = 55;
            LblCandidateParts.Text = "All Candidate Parts";
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitle.Location = new Point(34, 15);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(179, 32);
            LblTitle.TabIndex = 54;
            LblTitle.Text = "Modify Product";
            // 
            // LblMin
            // 
            LblMin.AutoSize = true;
            LblMin.Location = new Point(224, 430);
            LblMin.Name = "LblMin";
            LblMin.Size = new Size(42, 25);
            LblMin.TabIndex = 53;
            LblMin.Text = "Min";
            // 
            // LblMax
            // 
            LblMax.AutoSize = true;
            LblMax.Location = new Point(26, 430);
            LblMax.Name = "LblMax";
            LblMax.Size = new Size(45, 25);
            LblMax.TabIndex = 52;
            LblMax.Text = "Max";
            // 
            // LblPrice
            // 
            LblPrice.AutoSize = true;
            LblPrice.Location = new Point(26, 380);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(49, 25);
            LblPrice.TabIndex = 51;
            LblPrice.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 325);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 50;
            label3.Text = "Inventory";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(26, 272);
            LblName.Name = "LblName";
            LblName.Size = new Size(59, 25);
            LblName.TabIndex = 49;
            LblName.Text = "Name";
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(26, 218);
            LblId.Name = "LblId";
            LblId.Size = new Size(30, 25);
            LblId.TabIndex = 48;
            LblId.Text = "ID";
            // 
            // TbMin
            // 
            TbMin.Location = new Point(304, 428);
            TbMin.Name = "TbMin";
            TbMin.Size = new Size(100, 31);
            TbMin.TabIndex = 47;
            // 
            // TbMax
            // 
            TbMax.Location = new Point(87, 428);
            TbMax.Name = "TbMax";
            TbMax.Size = new Size(100, 31);
            TbMax.TabIndex = 46;
            // 
            // TbPriceCost
            // 
            TbPriceCost.Location = new Point(126, 375);
            TbPriceCost.Name = "TbPriceCost";
            TbPriceCost.Size = new Size(200, 31);
            TbPriceCost.TabIndex = 45;
            // 
            // TbInventory
            // 
            TbInventory.Location = new Point(126, 322);
            TbInventory.Name = "TbInventory";
            TbInventory.Size = new Size(200, 31);
            TbInventory.TabIndex = 44;
            TbInventory.TextChanged += TbInventory_TextChanged;
            // 
            // TbName
            // 
            TbName.Location = new Point(126, 268);
            TbName.Name = "TbName";
            TbName.Size = new Size(200, 31);
            TbName.TabIndex = 43;
            // 
            // TbId
            // 
            TbId.BackColor = SystemColors.InactiveCaption;
            TbId.Location = new Point(126, 215);
            TbId.Name = "TbId";
            TbId.ReadOnly = true;
            TbId.Size = new Size(200, 31);
            TbId.TabIndex = 42;
            // 
            // TbProductsSearch
            // 
            TbProductsSearch.Location = new Point(799, 43);
            TbProductsSearch.Name = "TbProductsSearch";
            TbProductsSearch.Size = new Size(261, 31);
            TbProductsSearch.TabIndex = 41;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(661, 40);
            BtnSearch.Margin = new Padding(3, 2, 3, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(116, 37);
            BtnSearch.TabIndex = 40;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // DgvPartsAssociated
            // 
            DgvPartsAssociated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPartsAssociated.Location = new Point(449, 370);
            DgvPartsAssociated.Margin = new Padding(3, 2, 3, 2);
            DgvPartsAssociated.Name = "DgvPartsAssociated";
            DgvPartsAssociated.RowHeadersWidth = 82;
            DgvPartsAssociated.RowTemplate.Height = 41;
            DgvPartsAssociated.Size = new Size(611, 208);
            DgvPartsAssociated.TabIndex = 38;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(903, 648);
            BtnCancel.Margin = new Padding(3, 2, 3, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(116, 37);
            BtnCancel.TabIndex = 37;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(760, 648);
            BtnSave.Margin = new Padding(3, 2, 3, 2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(116, 37);
            BtnSave.TabIndex = 36;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(903, 595);
            BtnDelete.Margin = new Padding(3, 2, 3, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 37);
            BtnDelete.TabIndex = 35;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(903, 313);
            BtnAdd.Margin = new Padding(3, 2, 3, 2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(116, 37);
            BtnAdd.TabIndex = 34;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // DgvCandidateParts
            // 
            DgvCandidateParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCandidateParts.Location = new Point(449, 92);
            DgvCandidateParts.Margin = new Padding(3, 2, 3, 2);
            DgvCandidateParts.Name = "DgvCandidateParts";
            DgvCandidateParts.RowHeadersWidth = 82;
            DgvCandidateParts.RowTemplate.Height = 41;
            DgvCandidateParts.Size = new Size(611, 208);
            DgvCandidateParts.TabIndex = 57;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 715);
            Controls.Add(DgvCandidateParts);
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
            Controls.Add(DgvPartsAssociated);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModifyProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)DgvPartsAssociated).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvCandidateParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPartsAssociated;
        private Label LblCandidateParts;
        private Label LblTitle;
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
        private TextBox TbProductsSearch;
        private Button BtnSearch;
        private DataGridView DgvPartsAssociated;
        private Button BtnCancel;
        private Button BtnSave;
        private Button BtnDelete;
        private Button BtnAdd;
        private DataGridView DgvCandidateParts;
    }
}
namespace Software_I___C____C968
{
    partial class AddPart
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
            RbOutsourced = new RadioButton();
            BtnSave = new Button();
            BtnCancel = new Button();
            TbId = new TextBox();
            TbName = new TextBox();
            TbInventory = new TextBox();
            TbPriceCost = new TextBox();
            TbMax = new TextBox();
            TbMachineId = new TextBox();
            TbMin = new TextBox();
            LblAddPart = new Label();
            LblId = new Label();
            LblName = new Label();
            label3 = new Label();
            LblPriceCost = new Label();
            LblMax = new Label();
            LblMin = new Label();
            LblMachineId = new Label();
            RbInHouse = new RadioButton();
            SuspendLayout();
            // 
            // RbOutsourced
            // 
            RbOutsourced.AutoSize = true;
            RbOutsourced.Location = new Point(290, 28);
            RbOutsourced.Name = "RbOutsourced";
            RbOutsourced.Size = new Size(130, 29);
            RbOutsourced.TabIndex = 1;
            RbOutsourced.Text = "Outsourced";
            RbOutsourced.UseVisualStyleBackColor = true;
            RbOutsourced.CheckedChanged += RbOutsourced_CheckedChanged;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(289, 449);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 34);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(423, 449);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 34);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TbId
            // 
            TbId.Location = new Point(183, 112);
            TbId.Name = "TbId";
            TbId.Size = new Size(200, 31);
            TbId.TabIndex = 4;
            // 
            // TbName
            // 
            TbName.Location = new Point(183, 165);
            TbName.Name = "TbName";
            TbName.Size = new Size(200, 31);
            TbName.TabIndex = 5;
            // 
            // TbInventory
            // 
            TbInventory.Location = new Point(183, 218);
            TbInventory.Name = "TbInventory";
            TbInventory.Size = new Size(200, 31);
            TbInventory.TabIndex = 6;
            // 
            // TbPriceCost
            // 
            TbPriceCost.Location = new Point(183, 271);
            TbPriceCost.Name = "TbPriceCost";
            TbPriceCost.Size = new Size(200, 31);
            TbPriceCost.TabIndex = 7;
            // 
            // TbMax
            // 
            TbMax.Location = new Point(181, 324);
            TbMax.Name = "TbMax";
            TbMax.Size = new Size(100, 31);
            TbMax.TabIndex = 9;
            // 
            // TbMachineId
            // 
            TbMachineId.Location = new Point(183, 376);
            TbMachineId.Name = "TbMachineId";
            TbMachineId.Size = new Size(200, 31);
            TbMachineId.TabIndex = 10;
            // 
            // TbMin
            // 
            TbMin.Location = new Point(397, 324);
            TbMin.Name = "TbMin";
            TbMin.Size = new Size(100, 31);
            TbMin.TabIndex = 11;
            // 
            // LblAddPart
            // 
            LblAddPart.AutoSize = true;
            LblAddPart.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LblAddPart.Location = new Point(24, 27);
            LblAddPart.Name = "LblAddPart";
            LblAddPart.Size = new Size(88, 28);
            LblAddPart.TabIndex = 12;
            LblAddPart.Text = "Add Part";
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(138, 115);
            LblId.Name = "LblId";
            LblId.Size = new Size(30, 25);
            LblId.TabIndex = 13;
            LblId.Text = "ID";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(109, 168);
            LblName.Name = "LblName";
            LblName.Size = new Size(59, 25);
            LblName.TabIndex = 14;
            LblName.Text = "Name";
            LblName.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 221);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 15;
            label3.Text = "Inventory";
            // 
            // LblPriceCost
            // 
            LblPriceCost.AutoSize = true;
            LblPriceCost.Location = new Point(66, 274);
            LblPriceCost.Name = "LblPriceCost";
            LblPriceCost.Size = new Size(102, 25);
            LblPriceCost.TabIndex = 16;
            LblPriceCost.Text = "Price / Cost";
            // 
            // LblMax
            // 
            LblMax.AutoSize = true;
            LblMax.Location = new Point(123, 327);
            LblMax.Name = "LblMax";
            LblMax.Size = new Size(45, 25);
            LblMax.TabIndex = 17;
            LblMax.Text = "Max";
            // 
            // LblMin
            // 
            LblMin.AutoSize = true;
            LblMin.Location = new Point(318, 327);
            LblMin.Name = "LblMin";
            LblMin.Size = new Size(42, 25);
            LblMin.TabIndex = 18;
            LblMin.Text = "Min";
            LblMin.Click += LblMin_Click;
            // 
            // LblMachineId
            // 
            LblMachineId.AutoSize = true;
            LblMachineId.Location = new Point(62, 376);
            LblMachineId.Name = "LblMachineId";
            LblMachineId.Size = new Size(101, 25);
            LblMachineId.TabIndex = 19;
            LblMachineId.Text = "Machine ID";
            // 
            // RbInHouse
            // 
            RbInHouse.AutoSize = true;
            RbInHouse.Checked = true;
            RbInHouse.Location = new Point(158, 28);
            RbInHouse.Name = "RbInHouse";
            RbInHouse.Size = new Size(110, 29);
            RbInHouse.TabIndex = 0;
            RbInHouse.TabStop = true;
            RbInHouse.Text = "In-House";
            RbInHouse.UseVisualStyleBackColor = true;
            RbInHouse.CheckedChanged += RbInHouse_CheckedChanged;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 510);
            Controls.Add(LblMachineId);
            Controls.Add(LblMin);
            Controls.Add(LblMax);
            Controls.Add(LblPriceCost);
            Controls.Add(label3);
            Controls.Add(LblName);
            Controls.Add(LblId);
            Controls.Add(LblAddPart);
            Controls.Add(TbMin);
            Controls.Add(TbMax);
            Controls.Add(TbPriceCost);
            Controls.Add(TbInventory);
            Controls.Add(TbName);
            Controls.Add(TbId);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(RbOutsourced);
            Controls.Add(RbInHouse);
            Controls.Add(TbMachineId);
            Name = "AddPart";
            Text = "Part";
            Load += AddPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton RbOutsourced;
        private Button BtnSave;
        private Button BtnCancel;
        private TextBox TbId;
        private TextBox TbName;
        private TextBox TbInventory;
        private TextBox TbPriceCost;
        private TextBox TbMax;
        private TextBox TbMachineId;
        private TextBox TbMin;
        private Label LblAddPart;
        private Label LblId;
        private Label LblName;
        private Label label3;
        private Label LblPriceCost;
        private Label LblMax;
        private Label LblMin;
        private Label LblMachineId;
        private RadioButton RbInHouse;
    }
}
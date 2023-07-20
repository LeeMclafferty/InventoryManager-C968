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
            RbInHouse = new RadioButton();
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
            SuspendLayout();
            // 
            // RbInHouse
            // 
            RbInHouse.AutoSize = true;
            RbInHouse.Location = new Point(153, 24);
            RbInHouse.Name = "RbInHouse";
            RbInHouse.Size = new Size(110, 29);
            RbInHouse.TabIndex = 0;
            RbInHouse.TabStop = true;
            RbInHouse.Text = "In-House";
            RbInHouse.UseVisualStyleBackColor = true;
            // 
            // RbOutsourced
            // 
            RbOutsourced.AutoSize = true;
            RbOutsourced.Location = new Point(285, 24);
            RbOutsourced.Name = "RbOutsourced";
            RbOutsourced.Size = new Size(130, 29);
            RbOutsourced.TabIndex = 1;
            RbOutsourced.TabStop = true;
            RbOutsourced.Text = "Outsourced";
            RbOutsourced.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(284, 445);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 34);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(418, 445);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 34);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TbId
            // 
            TbId.Location = new Point(178, 108);
            TbId.Name = "TbId";
            TbId.Size = new Size(200, 31);
            TbId.TabIndex = 4;
            // 
            // TbName
            // 
            TbName.Location = new Point(178, 161);
            TbName.Name = "TbName";
            TbName.Size = new Size(200, 31);
            TbName.TabIndex = 5;
            // 
            // TbInventory
            // 
            TbInventory.Location = new Point(178, 214);
            TbInventory.Name = "TbInventory";
            TbInventory.Size = new Size(200, 31);
            TbInventory.TabIndex = 6;
            // 
            // TbPriceCost
            // 
            TbPriceCost.Location = new Point(178, 267);
            TbPriceCost.Name = "TbPriceCost";
            TbPriceCost.Size = new Size(200, 31);
            TbPriceCost.TabIndex = 7;
            // 
            // TbMax
            // 
            TbMax.Location = new Point(176, 320);
            TbMax.Name = "TbMax";
            TbMax.Size = new Size(100, 31);
            TbMax.TabIndex = 9;
            // 
            // TbMachineId
            // 
            TbMachineId.Location = new Point(178, 373);
            TbMachineId.Name = "TbMachineId";
            TbMachineId.Size = new Size(200, 31);
            TbMachineId.TabIndex = 10;
            TbMachineId.Visible = false;
            // 
            // TbMin
            // 
            TbMin.Location = new Point(392, 320);
            TbMin.Name = "TbMin";
            TbMin.Size = new Size(100, 31);
            TbMin.TabIndex = 11;
            // 
            // LblAddPart
            // 
            LblAddPart.AutoSize = true;
            LblAddPart.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LblAddPart.Location = new Point(19, 23);
            LblAddPart.Name = "LblAddPart";
            LblAddPart.Size = new Size(88, 28);
            LblAddPart.TabIndex = 12;
            LblAddPart.Text = "Add Part";
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(133, 111);
            LblId.Name = "LblId";
            LblId.Size = new Size(30, 25);
            LblId.TabIndex = 13;
            LblId.Text = "ID";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(104, 164);
            LblName.Name = "LblName";
            LblName.Size = new Size(59, 25);
            LblName.TabIndex = 14;
            LblName.Text = "Name";
            LblName.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 217);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 15;
            label3.Text = "Inventory";
            // 
            // LblPriceCost
            // 
            LblPriceCost.AutoSize = true;
            LblPriceCost.Location = new Point(61, 270);
            LblPriceCost.Name = "LblPriceCost";
            LblPriceCost.Size = new Size(102, 25);
            LblPriceCost.TabIndex = 16;
            LblPriceCost.Text = "Price / Cost";
            // 
            // LblMax
            // 
            LblMax.AutoSize = true;
            LblMax.Location = new Point(118, 323);
            LblMax.Name = "LblMax";
            LblMax.Size = new Size(45, 25);
            LblMax.TabIndex = 17;
            LblMax.Text = "Max";
            // 
            // LblMin
            // 
            LblMin.AutoSize = true;
            LblMin.Location = new Point(313, 323);
            LblMin.Name = "LblMin";
            LblMin.Size = new Size(42, 25);
            LblMin.TabIndex = 18;
            LblMin.Text = "Min";
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RbInHouse;
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
    }
}
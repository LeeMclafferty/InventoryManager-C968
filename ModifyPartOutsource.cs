using Software_I___C____C968.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_I___C____C968
{
    public partial class ModifyPartOutsource : Form
    {

        public ModifyPart? inHouseForm = null;
        public MainScreen? mainScreen = null;
        public Outsourced selectedPart;

        public ModifyPartOutsource(MainScreen mainForm, Outsourced part, ModifyPart? inHouse = null)
        {
            InitializeComponent();
            inHouseForm = inHouse;
            mainScreen = mainForm;
            selectedPart = part;
            CheckOutsource();
            FillPartData();
        }

        void FillPartData()
        {
            if (selectedPart == null) return;

            Part? moddedPart = selectedPart;
            Outsourced? moddedOutsource = moddedPart as Outsourced;

            TbId.Text = selectedPart.partID.ToString();
            TbName.Text = selectedPart.name.ToString();
            TbInventory.Text = selectedPart.inStock.ToString();
            TbPriceCost.Text = selectedPart.price.ToString();
            TbMax.Text = selectedPart.max.ToString();
            TbMin.Text = selectedPart.min.ToString();

            if (moddedOutsource != null)
            {
                TbCompanyName.Text = moddedOutsource.companyName.ToString();
            }
        }

        public void CheckOutsource()
        {
            RbOutsourced.Checked = true;
            RbInHouse.Checked = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseWindow();
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CloseWindow();
        }

        private void CloseWindow()
        {
            if (inHouseForm != null)
            {
                inHouseForm.CloseWindow();
                inHouseForm = null;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (mainScreen == null) return;

            Part? moddedPart = selectedPart;
            Outsourced? moddedOutsourced = moddedPart as Outsourced;

            if (CheckTextBoxes())
            {
                if (moddedPart != null)
                {
                    selectedPart.partID = CheckStringNotEmpty(TbId.Text) ? Int32.Parse(TbId.Text) : moddedPart.partID;
                    selectedPart.name = CheckStringNotEmpty(TbName.Text) ? TbName.Text : moddedPart.name;
                    selectedPart.inStock = CheckStringNotEmpty(TbInventory.Text) ? Int32.Parse(TbInventory.Text) : moddedPart.inStock;
                    selectedPart.price = CheckStringNotEmpty(TbPriceCost.Text) ? Double.Parse(TbPriceCost.Text) : moddedPart.price;
                    selectedPart.min = CheckStringNotEmpty(TbMin.Text) ? Int32.Parse(TbMin.Text) : moddedPart.min;
                    selectedPart.max = CheckStringNotEmpty(TbMax.Text) ? Int32.Parse(TbMax.Text) : moddedPart.max;
                }
                if (selectedPart.min > selectedPart.max)
                {
                    MessageBox.Show("Min must be less than or equal to max", "error");
                    return;
                }

                if (moddedOutsourced != null)
                {
                    selectedPart.companyName = CheckStringNotEmpty(TbCompanyName.Text) ? TbCompanyName.Text : moddedOutsourced.companyName;
                }


                mainScreen.RefreshDataSource();
                ModifyInventoryPart(selectedPart);
                CloseWindow();
                Close();
                
                
            }
        }

        public bool CheckStringNotEmpty(string check)
        {
            return !string.IsNullOrEmpty(check);
        }

        private bool CheckTextBoxes()
        {

            int a;
            if (CheckStringNotEmpty(TbId.Text))
            {
                if (!Int32.TryParse(TbId.Text, out a))
                {
                    MessageBox.Show("ID must be a number", "Error");
                    return false;
                }
            }

            if (CheckStringNotEmpty(TbInventory.Text))
            {
                if (!Int32.TryParse(TbInventory.Text, out a))
                {
                    MessageBox.Show("Inventory must be a number", "Error");
                    return false;
                }
            }

            if (CheckStringNotEmpty(TbPriceCost.Text))
            {
                if (!double.TryParse(TbPriceCost.Text, out double b))
                {
                    MessageBox.Show("Price must be a number", "Error");
                    return false;
                }
            }

            if (CheckStringNotEmpty(TbMin.Text))
            {
                if (!Int32.TryParse(TbMin.Text, out a))
                {
                    MessageBox.Show("Min must be a number", "Error");
                    return false;
                }
            }

            if (CheckStringNotEmpty(TbMax.Text))
            {
                if (!Int32.TryParse(TbMax.Text, out a))
                {
                    MessageBox.Show("Max must be a number", "Error");
                    return false;
                }
            }

            return true;
        }

        private void ModifyInventoryPart(Outsourced toAdd)
        {
            if (inHouseForm == null || inHouseForm.mainScreen == null || inHouseForm.mainScreen.inventory == null)
                return;

            inHouseForm.mainScreen.inventory.updatePart(selectedPart.partID, toAdd);
        }

        private void RbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            //             this.Visible = false;
            // 
            //             if (inHouseForm == null)
            //             {
            //                 if (mainScreen == null) return;
            //                 if (selectedPart as Inhouse == null) return;
            // 
            //                 inHouseForm = new ModifyPart(mainScreen, selectedPart as Inhouse, this);
            //             }
            // 
            //             inHouseForm.CheckInHouse();
            //             inHouseForm.Show();
            RbOutsourced.Checked = true;
            MessageBox.Show("You cannot edit an Outsourced as part as in-house.", "Error");
        }
    }
}

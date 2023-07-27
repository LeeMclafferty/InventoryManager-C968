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
    public partial class ModifyPart : Form
    {
        public MainScreen? mainScreen = null;
        public ModifyPartOutsource? outsourcedForm = null;
        public Inhouse selectedPart;

        public ModifyPart(MainScreen mainForm, Inhouse part, ModifyPartOutsource? outForm = null)
        {
            InitializeComponent();
            mainScreen = mainForm;
            selectedPart = part;
            CheckInHouse();
            FillPartData();
        }

        void FillPartData()
        {
            if (selectedPart == null) return;

            Part? moddedPart = selectedPart;
            Inhouse? moddedInHouse = moddedPart as Inhouse;

            TbId.Text = selectedPart.partID.ToString();
            TbName.Text = selectedPart.name.ToString();
            TbInventory.Text = selectedPart.inStock.ToString();
            TbPriceCost.Text = selectedPart.price.ToString();
            TbMax.Text = selectedPart.max.ToString();
            TbMin.Text = selectedPart.min.ToString();

            if (moddedInHouse != null)
            {
                TbMachineId.Text = moddedInHouse.machineID.ToString();
            }
        }

        public void CheckInHouse()
        {
            RbInHouse.Checked = true;
            RbOutsourced.Checked = false;
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

        /* Cannot call Close() in this function since I am calling it on OnFormClosing */
        public void CloseWindow()
        {
            if (mainScreen != null)
            {
                mainScreen.RefreshDataSource();
            }
            ClearSelfRef();
            outsourcedForm = null;
        }

        private void ClearSelfRef()
        {
            if (mainScreen == null) return;
            if (mainScreen.modifyPartForm == null) return;

            mainScreen.modifyPartForm = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (mainScreen != null)
            {
                Inhouse part = new Inhouse();
                Part? moddedPart = selectedPart;
                Inhouse? moddedInHouse = moddedPart as Inhouse;
                if (CheckTextBoxes())
                {
                    part.partID = CheckStringNotEmpty(TbId.Text) ? Int32.Parse(TbId.Text) : moddedPart.partID;
                    part.name = CheckStringNotEmpty(TbName.Text) ? TbName.Text : moddedPart.name;
                    part.inStock = CheckStringNotEmpty(TbInventory.Text) ? Int32.Parse(TbInventory.Text) : moddedPart.inStock;
                    part.price = CheckStringNotEmpty(TbPriceCost.Text) ? Double.Parse(TbPriceCost.Text) : moddedPart.price;
                    part.min = CheckStringNotEmpty(TbMin.Text) ? Int32.Parse(TbMin.Text) : moddedPart.min;
                    part.max = CheckStringNotEmpty(TbMax.Text) ? Int32.Parse(TbMax.Text) : moddedPart.max;

                    if (moddedInHouse != null)
                    {
                        selectedPart.machineID = Int32.Parse(TbMachineId.Text);
                    }

                    if (part.min > part.max)
                    {
                        MessageBox.Show("Min must be less than or equal to max", "error");
                        return;
                    }
                    else if (part.min > part.inStock || part.max < part.inStock)
                    {
                        MessageBox.Show("Your inventory has to be between min and max values.", "error");
                        return;
                    }
                    else
                    {
                        ModifyInventoryPart(part);
                        CloseWindow();
                        Close();
                    }
                }
            }
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

            if (CheckStringNotEmpty(TbMachineId.Text))
            {
                if (!Int32.TryParse(TbMachineId.Text, out a))
                {
                    MessageBox.Show("Machine ID must be a number", "Error");
                    return false;
                }
            }

            return true;
        }

        private void ModifyInventoryPart(Inhouse toAdd)
        {
            if (mainScreen == null) return;

            if (mainScreen.inventory == null) return;

            mainScreen.inventory.updatePart(selectedPart.partID, toAdd);
        }

        public bool CheckStringNotEmpty(string check)
        {
            return !string.IsNullOrEmpty(check);
        }

        private void RbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            //             this.Visible = false;
            // 
            //             if (outsourcedForm == null)
            //             {
            //                 if (mainScreen == null) return;
            //                 outsourcedForm = new ModifyPartOutsource(mainScreen, selectedPart, this);
            //             }
            // 
            //             outsourcedForm.CheckOutsource();
            //             outsourcedForm.Show
            RbInHouse.Checked = true;
            MessageBox.Show("You cannot edit a In-House part as outsourced.");
        }
    }
}

﻿using Software_I___C____C968.src;
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
        int selctedPartId = -1;

        public ModifyPartOutsource(MainScreen mainForm, int id, ModifyPart? inHouse = null)
        {
            InitializeComponent();
            inHouseForm = inHouse;
            mainScreen = mainForm;
            selctedPartId = id;
            CheckOutsource();
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
            if (inHouseForm == null) return;

            if (inHouseForm.mainScreen != null)
            {
                Outsourced part = new Outsourced();
                Part? moddedPart = inHouseForm.mainScreen.inventory.lookupPart(selctedPartId);
                Outsourced? moddedOutsourced = moddedPart as Outsourced;

                if(CheckTextBoxes())
                {
                    if (moddedPart != null)
                    {
                        part.partID = inHouseForm.CheckStringNotEmpty(TbId.Text) ? Int32.Parse(TbId.Text) : moddedPart.partID;
                        part.name = inHouseForm.CheckStringNotEmpty(TbName.Text) ? TbName.Text : moddedPart.name;
                        part.inStock = inHouseForm.CheckStringNotEmpty(TbInventory.Text) ? Int32.Parse(TbInventory.Text) : moddedPart.inStock;
                        part.price = inHouseForm.CheckStringNotEmpty(TbPriceCost.Text) ? Double.Parse(TbPriceCost.Text) : moddedPart.price;
                        part.min = inHouseForm.CheckStringNotEmpty(TbMin.Text) ? Int32.Parse(TbMin.Text) : moddedPart.min;
                        part.max = inHouseForm.CheckStringNotEmpty(TbMax.Text) ? Int32.Parse(TbMax.Text) : moddedPart.max;
                    }

                    if (moddedOutsourced != null)
                    {
                        part.companyName = inHouseForm.CheckStringNotEmpty(TbCompanyName.Text) ? TbCompanyName.Text : moddedOutsourced.companyName;
                    }

                    if (part.min > part.max)
                    {
                        MessageBox.Show("Min must be less than or equal to max", "error");
                    }
                    else
                    {
                        if (part != null)
                        {
                            ModifyInventoryPart(part);
                            CloseWindow();
                            Close();
                        }
                    }
                }
            }
        }

        private bool CheckTextBoxes()
        {
            if (inHouseForm == null) return false;

            int a;
            if (inHouseForm.CheckStringNotEmpty(TbId.Text))
            {
                if (!Int32.TryParse(TbId.Text, out a))
                {
                    MessageBox.Show("ID must be a number", "Error");
                    return false;
                }
            }

            if (inHouseForm.CheckStringNotEmpty(TbInventory.Text))
            {
                if (!Int32.TryParse(TbInventory.Text, out a))
                {
                    MessageBox.Show("Inventory must be a number", "Error");
                    return false;
                }
            }

            if (inHouseForm.CheckStringNotEmpty(TbPriceCost.Text))
            {
                if (!double.TryParse(TbPriceCost.Text, out double b))
                {
                    MessageBox.Show("Price must be a number", "Error");
                    return false;
                }
            }

            if (inHouseForm.CheckStringNotEmpty(TbMin.Text))
            {
                if (!Int32.TryParse(TbMin.Text, out a))
                {
                    MessageBox.Show("Min must be a number", "Error");
                    return false;
                }
            }

            if (inHouseForm.CheckStringNotEmpty(TbMax.Text))
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

            inHouseForm.mainScreen.inventory.updatePart(selctedPartId, toAdd);
        }

        private void RbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;

            if (inHouseForm == null)
            {
                if (mainScreen == null) return;
                inHouseForm = new ModifyPart(mainScreen, selctedPartId, this);
            }

            inHouseForm.CheckInHouse();
            inHouseForm.Show();
        }
    }
}

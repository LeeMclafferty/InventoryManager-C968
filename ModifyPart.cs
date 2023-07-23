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
        public int selctedPartId = -1;

        public ModifyPart(MainScreen mainForm, int partId, ModifyPartOutsource? outForm = null)
        {
            InitializeComponent();
            mainScreen = mainForm;
            selctedPartId = partId;
            CheckInHouse();
        }

        public void CheckInHouse()
        {
            RbInHouse.Checked = true;
            RbOutsourced.Checked = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        public void CloseWindow()
        {
            if (mainScreen != null)
            {
                mainScreen.RefreshDataSource();
            }
            ClearSelfRef();
            outsourcedForm = null;
            selctedPartId = -1;
            this.Close();
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
                Part? moddedPart = mainScreen.inventory.lookupPart(selctedPartId);
                Inhouse? moddedInHouse = moddedPart as Inhouse;

                part.partID = CheckStringNotEmpty(TbId.Text) ? Int32.Parse(TbId.Text) : moddedPart.partID;
                part.name = CheckStringNotEmpty(TbName.Text) ? TbName.Text : moddedPart.name;
                part.inStock = CheckStringNotEmpty(TbInventory.Text) ? Int32.Parse(TbInventory.Text) : moddedPart.inStock;
                part.price = CheckStringNotEmpty(TbPriceCost.Text) ? Double.Parse(TbPriceCost.Text) : moddedPart.price;
                part.min = CheckStringNotEmpty(TbMin.Text) ? Int32.Parse(TbMin.Text) : moddedPart.min;
                part.max = CheckStringNotEmpty(TbMax.Text) ? Int32.Parse(TbMax.Text) : moddedPart.max;

                if(moddedInHouse != null)
                { 
                    part.machineID = CheckStringNotEmpty(TbMachineId.Text) ? Int32.Parse(TbMachineId.Text) : moddedInHouse.machineID;
                }

                ModifyInventoryPart(part);
                CloseWindow();
            }
        }

        private void ModifyInventoryPart(Inhouse toAdd)
        {
            if (mainScreen == null) return;

            if (mainScreen.inventory == null) return;

            mainScreen.inventory.updatePart(selctedPartId, toAdd);
        }

        public bool CheckStringNotEmpty(string check)
        {
            return !string.IsNullOrEmpty(check);
        }

        private bool CheckTextBoxes()
        {
            bool canContinue = true;

            if(string.IsNullOrEmpty(TbId.Text))
            { 
                TbId.BackColor = Color.Red;
                canContinue = false;
            }
            else
            {
                TbId.BackColor = Color.White;
            }
            
            return canContinue;
        }

        private void RbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;

            if (outsourcedForm == null)
            {
                if (mainScreen == null) return;
                outsourcedForm = new ModifyPartOutsource(mainScreen, selctedPartId, this);
            }

            outsourcedForm.CheckOutsource();
            outsourcedForm.Show();
        }
    }
}

using Software_I___C____C968.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_I___C____C968
{
    public partial class AddPart : Form
    {
        public MainScreen mainScreen;
        public AddPartsOutsource? outsourced = null;

        public AddPart(MainScreen parent)
        {
            InitializeComponent();
            mainScreen = parent;
            CheckInHouse();
        }

        public void CheckInHouse()
        {
            RbInHouse.Checked = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CleanupRefs();
        }

        public void CloseWindow()
        {
            mainScreen.RefreshDataSource();
            CleanupRefs();
            this.Close();
        }

        public void CleanupRefs()
        {
            outsourced = null;
            mainScreen.addPartForm = null;
        }

        private void RbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;

            if (outsourced == null)
            {
                outsourced = new AddPartsOutsource(this);
            }

            outsourced.CheckOutsource();
            outsourced.Show();
        }

        private void RbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourced != null)
            {
                outsourced.Visible = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                Inhouse part = new Inhouse();
                part.partID = Int32.Parse(TbId.Text);
                part.name = TbName.Text;
                part.price = Double.Parse(TbPriceCost.Text);
                part.inStock = Int32.Parse(TbInventory.Text);
                part.min = Int32.Parse(TbMin.Text);
                part.max = Int32.Parse(TbMax.Text);
                part.machineID = Int32.Parse(TbMachineId.Text);

                AddToInventory(part);
                CloseWindow();
            }
        }

        private void AddToInventory(Inhouse toAdd)
        {
            if (mainScreen == null) return;

            if (mainScreen.inventory == null) return;

            mainScreen.inventory.addPart(toAdd);
        }

        private bool CheckTextBoxes()
        {
            var textBoxes = new List<TextBox>();
            textBoxes.Add(TbId);
            textBoxes.Add(TbName);
            textBoxes.Add(TbPriceCost);
            textBoxes.Add(TbInventory); 
            textBoxes.Add(TbMin);
            textBoxes.Add(TbMax);
            textBoxes.Add(TbMachineId);

            bool canContinue = true;
            foreach(TextBox textBox in textBoxes)
            {
                if(string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.BackColor = Color.Red;
                    canContinue = false;
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }

            return canContinue;
        }
    }
}

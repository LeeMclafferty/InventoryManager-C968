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
            int a;
            bool canContinue = true;

            if(Int32.TryParse(TbId.Text, out a))
            {
                textBoxes.Add(TbId);
            }
            else
            {
                MessageBox.Show("ID must be a number", "Error");
                return false;
            }

            textBoxes.Add(TbName);

            if (double.TryParse(TbPriceCost.Text, out double result))
            {
                textBoxes.Add(TbPriceCost);
            }
            else
            {
                MessageBox.Show("Price must be a number", "Error");
                return false;
            }

            if (Int32.TryParse(TbInventory.Text, out a))
            {
                textBoxes.Add(TbInventory);
            }
            else
            {
                MessageBox.Show("Inventory must be a number", "Error");
                return false;
            }

            if (Int32.TryParse(TbMin.Text, out a))
            {
                textBoxes.Add(TbMin);
            }
            else
            {
                MessageBox.Show("Min must be a number", "Error");
                return false;
            }

            if (Int32.TryParse(TbMax.Text, out a))
            {
                textBoxes.Add(TbMax);
            }
            else
            {
                MessageBox.Show("Max must be a number", "Error");
                return false;
            }

            if (Int32.TryParse(TbMachineId.Text, out a))
            {
                textBoxes.Add(TbMachineId);
            }
            else
            {
                MessageBox.Show("Machine ID must be a number", "Error");
                return false;
            }
           
            if(Int32.Parse(TbMin.Text) > Int32.Parse(TbMax.Text))
            {
                MessageBox.Show("Min has to be less than or equal to Max", "Error");
                return false;
            }
            
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

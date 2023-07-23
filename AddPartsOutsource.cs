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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Software_I___C____C968
{
    public partial class AddPartsOutsource : Form
    {
        public AddPart? inHouse = null;

        public AddPartsOutsource(AddPart parent)
        {
            InitializeComponent();
            inHouse = parent;
            CheckOutsource();
        }

        public void CheckOutsource()
        {
            RbOutsourced.Checked = true;
        }

        private void RbInHouse_CheckedChanged(object sender, EventArgs e)
        {

            if (inHouse != null)
            {
                inHouse.Visible = true;
                inHouse.CheckInHouse();
            }

            Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (inHouse != null)
            {
                inHouse.CloseWindow();
                inHouse = null;
            }
        }

        private void CloseWindow()
        {
            if (inHouse != null)
            {
                inHouse.CloseWindow();
                inHouse = null;
            }
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                Outsourced part = new Outsourced();
                part.partID = Int32.Parse(TbId.Text);
                part.name = TbName.Text;
                part.price = Double.Parse(TbPriceCost.Text);
                part.inStock = Int32.Parse(TbInventory.Text);
                part.min = Int32.Parse(TbMin.Text);
                part.max = Int32.Parse(TbMax.Text);
                part.companyName = TbCompanyName.Text;

                if(inHouse != null)
                {
                    AddToInventory(part);
                    CloseWindow();
                }
            }
        }

        private void AddToInventory(Outsourced toAdd)
        {
            if (inHouse == null) return;

            if (inHouse.mainScreen.inventory == null) return;

            inHouse.mainScreen.inventory.addPart(toAdd);
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
            textBoxes.Add(TbCompanyName);

            bool canContiue = true;
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.BackColor = Color.Red;
                    canContiue = false;
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }

            return canContiue;
        }
    }
}

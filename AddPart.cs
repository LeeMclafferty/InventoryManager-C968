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

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblMin_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearSelfRef();
            outsourced = null;
            this.Close();
        }

        public void ClearSelfRef()
        {
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

        }
    }
}

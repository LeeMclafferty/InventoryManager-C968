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
            if (inHouse != null)
            {
                inHouse.ClearSelfRef();
                inHouse = null;
            }
            this.Close();
        }
    }
}

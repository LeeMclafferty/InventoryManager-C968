namespace Software_I___C____C968
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSearchParts_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddParts_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart();
            addPartForm.Show();
        }

        private void BtnAddProducts_Click(object sender, EventArgs e)
        {
            Product productForm = new Product();
            productForm.Show();
        }

        private void BtnModifyParts_Click(object sender, EventArgs e)
        {
            AddPartsMod modifyPartForm = new AddPartsMod();
            modifyPartForm.Show();
        }

        private void BtnModifyProducts_Click(object sender, EventArgs e)
        {
            ProductMod productModForm = new ProductMod();
            productModForm.Show();
        }
        private void InitializeDataViewGrid()
        {

        }
    }
}
using Software_I___C____C968.src;

namespace Software_I___C____C968
{
    public partial class Form1 : Form
    {

        List<Part> parts = new List<Part>();
        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            InitializeDataViewGrid();
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
            parts.Add(
                new Part()
                {
                    partID = 0,
                    name = "Wheel",
                    inStock = 15,
                    price = 12.11,
                    min = 5,
                    max = 25
                });
            parts.Add(
                new Part()
                {
                    partID = 1,
                    name = "Pedal",
                    inStock = 11,
                    price = 8.22,
                    min = 5,
                    max = 25
                });
            parts.Add(
                new Part()
                {
                    partID = 2,
                    name = "Chain",
                    inStock = 12,
                    price = 8.33,
                    min = 5,
                    max = 25
                });
            parts.Add(
                new Part()
                {
                    partID = 3,
                    name = "Seat",
                    inStock = 8,
                    price = 4.55,
                    min = 2,
                    max = 15
                });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgvParts.DataSource = parts;
            DgvProducts.DataSource = products;
        }
    }
}
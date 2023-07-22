using Software_I___C____C968.src;
using System.Diagnostics;
using System.Windows.Forms;

namespace Software_I___C____C968
{
    public partial class Form1 : Form
    {

        public List<Part> allParts { get; set; }
        public List<Product> allProducts { get; set; }

        public List<Part> boundPartsData { get; set; }
        public List<Product> boundProductData { get; set; }
        public Form1()
        {
            InitializeComponent();
            allParts = InitializeParts();
            allProducts = InitializeProducts();
            boundPartsData = new List<Part>(allParts);
            boundProductData = new List<Product>(allProducts);
        }

        private void BtnSearchParts_Click(object sender, EventArgs e)
        {
            string searchText = TbPartsSearch.Text.ToLower();
            boundPartsData.Clear();

            if (searchText == "")
            {
                foreach (Part part in allParts)
                {
                    boundPartsData.Add(part);
                }
            }
            else
            {
                foreach (Part part in allParts)
                {
                    if (part.name.ToLower().Contains(searchText))
                    {
                        boundPartsData.Add(part);
                    }
                }
            }

            DgvParts.DataSource = null;
            DgvParts.DataSource = boundPartsData;
        }

        private void BtnAddParts_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart();
            addPartForm.Show();
        }

        private void BtnAddProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
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

        private List<Part> InitializeParts()
        {
            List<Part> intialParts = new List<Part>();
            intialParts.Add(
                new Part()
                {
                    partID = 0,
                    name = "Wheel",
                    inStock = 15,
                    price = 12.11,
                    min = 5,
                    max = 25
                });
            intialParts.Add(
                new Part()
                {
                    partID = 1,
                    name = "Pedal",
                    inStock = 11,
                    price = 8.22,
                    min = 5,
                    max = 25
                });
            intialParts.Add(
                new Part()
                {
                    partID = 2,
                    name = "Chain",
                    inStock = 12,
                    price = 8.33,
                    min = 5,
                    max = 25
                });
            intialParts.Add(
                new Part()
                {
                    partID = 3,
                    name = "Seat",
                    inStock = 8,
                    price = 4.55,
                    min = 2,
                    max = 15
                });
            return intialParts;
        }

        private List<Product> InitializeProducts()
        {
            List<Product> intialProducts = new List<Product>();

            intialProducts.Add(
                new Product()
                {
                    productID = 0,
                    name = "Red Bicycle",
                    inStock = 15,
                    price = 11.44,
                    min = 1,
                    max = 25
                });
            intialProducts.Add(
                new Product()
                {
                    productID = 1,
                    name = "Yellow Bicycle",
                    inStock = 19,
                    price = 9.66,
                    min = 1,
                    max = 20
                });
            intialProducts.Add(
                new Product()
                {
                    productID = 2,
                    name = "Blue Bicycle",
                    inStock = 5,
                    price = 12.77,
                    min = 1,
                    max = 25
                });

            return intialProducts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgvParts.DataSource = boundPartsData;
            DgvProducts.DataSource = boundProductData;
            SetupHeaders();
        }

        private void SetupHeaders()
        {
            /* Parts Column Headers */
            DgvParts.Columns[0].HeaderText = "Part ID";
            DgvParts.Columns[1].HeaderText = "Name";
            DgvParts.Columns[2].HeaderText = "Inventory";
            DgvParts.Columns[3].HeaderText = "Price";
            DgvParts.Columns[4].HeaderText = "Min";
            DgvParts.Columns[5].HeaderText = "Max";

            /* Products Column Headers */
            DgvProducts.Columns[0].HeaderText = "Product ID";
            DgvProducts.Columns[1].HeaderText = "Name";
            DgvProducts.Columns[2].HeaderText = "Inventory";
            DgvProducts.Columns[3].HeaderText = "Price";
            DgvProducts.Columns[4].HeaderText = "Min";
            DgvProducts.Columns[5].HeaderText = "Max";
        }

        private void BtnDeleteParts_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvParts.SelectedRows.Count > 0) // Ensure a row is selected
                {
                    int selectedRowIndex = DgvParts.SelectedRows[0].Index;
                    boundPartsData.RemoveAt(selectedRowIndex);

                    /* Refresh Data */
                    DgvParts.DataSource = null;
                    DgvParts.DataSource = boundPartsData;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Part Deletion Error: " + ex.Message);
            }
        }

        private void BtnDeleteProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvProducts.SelectedRows.Count > 0) // Ensure a row is selected
                {
                    int selectedRowIndex = DgvProducts.SelectedRows[0].Index;
                    boundProductData.RemoveAt(selectedRowIndex);

                    /* Refresh Data */
                    DgvProducts.DataSource = null;
                    DgvProducts.DataSource = boundProductData;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Part Deletion Error: " + ex.Message);
            }
        }

        private void BtnSearchProducts_Click(object sender, EventArgs e)
        {
            string searchText = TbProductsSearch.Text.ToLower();
            boundProductData.Clear();

            if (searchText == "")
            {
                foreach (Product product in allProducts)
                {
                    boundProductData.Add(product);
                }
            }
            else
            {
                foreach (Product product in allProducts)
                {
                    if (product.name.ToLower().Contains(searchText))
                    {
                        boundProductData.Add(product);
                    }
                }
            }

            DgvProducts.DataSource = null;
            DgvProducts.DataSource = boundProductData;
        }
    }
}
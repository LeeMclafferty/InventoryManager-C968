using Software_I___C____C968.src;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Software_I___C____C968
{
    public partial class MainScreen : Form
    {
        public BindingList<Part> boundPartsData { get; set; }
        public BindingList<Product> boundProductData { get; set; }
        Inventory inventory { get; set; }

        public AddPart? addPartForm = null;
        public AddProduct? addProductForm = null;
        public ModifyProduct? modifyProductForm = null;
        public ModifyPart? ModifyPartForm = null;

        public MainScreen()
        {
            InitializeComponent();
            inventory = new Inventory();
            boundPartsData = new BindingList<Part>(inventory.allParts);
            boundProductData = new BindingList<Product>(inventory.products);
            DgvParts.AllowUserToAddRows = false;
            DgvProducts.AllowUserToAddRows = false;
        }

        private void BtnSearchParts_Click(object sender, EventArgs e)
        {
            string searchText = TbPartsSearch.Text.ToLower();

            List<Part> filteredParts = new List<Part>();

            if (searchText == "")
            {
                filteredParts.AddRange(inventory.allParts);
            }
            else
            {
                foreach (Part part in inventory.allParts)
                {
                    if (part.name.ToLower().Contains(searchText))
                    {
                        filteredParts.Add(inventory.lookupPart(part.partID));
                    }
                }
            }

            DgvParts.DataSource = null;
            DgvParts.DataSource = new BindingList<Part>(filteredParts);
        }

        private void BtnAddParts_Click(object sender, EventArgs e)
        {
            if (addPartForm == null)
            {
                addPartForm = new AddPart(this);
            }

            try
            {
                addPartForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to open AddPartForm: " + ex.Message);
            };
        }

        private void BtnAddProducts_Click(object sender, EventArgs e)
        {
            if (addProductForm == null)
            {
                addProductForm = new AddProduct();
            }

            try
            {
                addProductForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to open addProductForm: " + ex.Message);
            };
        }

        private void BtnModifyParts_Click(object sender, EventArgs e)
        {
            if (ModifyPartForm == null)
            {
                ModifyPartForm = new ModifyPart();
            }

            try
            {
                ModifyPartForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to open ModifyPartForm: " + ex.Message);
            };
        }

        private void BtnModifyProducts_Click(object sender, EventArgs e)
        {
            if (modifyProductForm == null)
            {
                modifyProductForm = new ModifyProduct();
            }

            try
            {
                modifyProductForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to open modifyProductForm: " + ex.Message);
            };
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
                if (DgvParts.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = DgvParts.SelectedRows[0].Index;
                    inventory.allParts.RemoveAt(selectedRowIndex);

                    /* Refresh Data */
                    boundPartsData = new BindingList<Part>(inventory.allParts);
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
                    inventory.products.RemoveAt(selectedRowIndex);

                    /* Refresh Data */
                    boundProductData = new BindingList<Product>(inventory.products);
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

            List<Product> filteredProducts = new List<Product>();

            if (searchText == "")
            {
                filteredProducts.AddRange(inventory.products);
            }
            else
            {
                foreach (Product product in inventory.products)
                {
                    if (product.name.ToLower().Contains(searchText))
                    {
                        filteredProducts.Add(inventory.lookupProduct(product.productID));
                    }
                }
            }

            DgvProducts.DataSource = null;
            DgvProducts.DataSource = new BindingList<Product>(filteredProducts);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
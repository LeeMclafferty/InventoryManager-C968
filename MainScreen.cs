using Software_I___C____C968.src;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Security.Policy;
using System.Windows.Forms;

namespace Software_I___C____C968
{
    public partial class MainScreen : Form
    {
        public BindingList<Part> boundPartsData { get; set; }
        public BindingList<Product> boundProductData { get; set; }
        public Inventory inventory { get; set; }

        public AddPart? addPartForm = null;
        public AddProduct? addProductForm = null;
        public ModifyProduct? modifyProductForm = null;

        public ModifyPart? modifyPartForm = null;
        public ModifyPartOutsource? modifyPartOutsourceForm = null;

        public MainScreen()
        {
            InitializeComponent();
            inventory = new Inventory();
            RefreshDataSource();
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

           RefreshDataSource(filteredParts);
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
                
            Part selectedPart = GetSelectedPart();
            modifyPartForm = null;
            modifyPartOutsourceForm = null;

            Outsourced? outsourcedPart = selectedPart as Outsourced;
            Inhouse? inhousePart = selectedPart as Inhouse;

            if (inhousePart != null) 
            {
                if (selectedPart.partID > -1)
                {
                   modifyPartForm = new ModifyPart(this, selectedPart.partID);
                }
            }
            if(modifyPartForm != null)
            {
                try
                {
                    modifyPartForm.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to open ModifyPartForm: " + ex.Message);
                };
            }

            if (outsourcedPart != null)
            {
                if (selectedPart.partID > -1)
                {
                    modifyPartOutsourceForm = new ModifyPartOutsource(this, selectedPart.partID);
                }
            }
            if (modifyPartOutsourceForm != null)
            {
                try
                {
                    modifyPartOutsourceForm.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to open ModifyPartForm: " + ex.Message);
                };
            }
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
                    RefreshDataSource(true, false);
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
                    RefreshDataSource(false, true);
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

            RefreshDataSource(filteredProducts);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Defaulted to refresh both list */
        public void RefreshDataSource(bool refreshParts = true, bool refreshProducts = true)
        {
            if(refreshParts)
            {
            boundPartsData = new BindingList<Part>(inventory.allParts);
            DgvParts.DataSource = null;
            DgvParts.DataSource = boundPartsData;
            }
            
            if(refreshProducts)
            {
            boundProductData = new BindingList<Product>(inventory.products);
            DgvProducts.DataSource = null;
            DgvProducts.DataSource = boundProductData;
            }

            SetupHeaders();
        }

        public void RefreshDataSource(List<Part> partsFilter)
        {
            boundPartsData = new BindingList<Part>(partsFilter);
            DgvParts.DataSource = null;
            DgvParts.DataSource = boundPartsData;

            SetupHeaders();
        }

        public void RefreshDataSource(List<Product> productFilter)
        {

            boundProductData = new BindingList<Product>(productFilter);
            DgvProducts.DataSource = null;
            DgvProducts.DataSource = boundProductData;

            SetupHeaders();
        }

        private Part GetSelectedPart()
        {
            if (DgvParts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvParts.SelectedRows[0];
                int partId = Convert.ToInt32(selectedRow.Cells["partID"].Value);
                return inventory.lookupPart(partId);
            }
            else
            {
                MessageBox.Show("No row selected.", "Error");
                return null;
            }
        }
    }
}
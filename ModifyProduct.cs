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

namespace Software_I___C____C968
{
    public partial class ModifyProduct : Form
    {

        MainScreen? mainScreen = null;
        public BindingList<Part> candidatePartsData { get; set; }
        public BindingList<Part> associatedPartsData { get; set; }

        private Product? selectedProduct = null;

        public ModifyProduct(MainScreen screen, Product? product)
        {
            InitializeComponent();
            mainScreen = screen;
            mainScreen.modifyProductForm = this;

            selectedProduct = product;

            candidatePartsData = new BindingList<Part>(mainScreen.inventory.allParts);

            if(selectedProduct != null)
            {
                associatedPartsData = new BindingList<Part>(selectedProduct.associatedParts);
            }

            DgvCandidateParts.DataSource = candidatePartsData;
            DgvPartsAssociated.DataSource = associatedPartsData;

            DgvCandidateParts.AllowUserToAddRows = false;
            DgvPartsAssociated.AllowUserToAddRows = false;
            SetupHeaders();
        }

        private void SetupHeaders()
        {
            /* Candidate Parts Column Headers */
            DgvCandidateParts.Columns[0].HeaderText = "Part ID";
            DgvCandidateParts.Columns[1].HeaderText = "Name";
            DgvCandidateParts.Columns[2].HeaderText = "Inventory";
            DgvCandidateParts.Columns[3].HeaderText = "Price";
            DgvCandidateParts.Columns[4].HeaderText = "Min";
            DgvCandidateParts.Columns[5].HeaderText = "Max";

            /* Candidate Parts Column Headers */
            DgvPartsAssociated.Columns[0].HeaderText = "Part ID";
            DgvPartsAssociated.Columns[1].HeaderText = "Name";
            DgvPartsAssociated.Columns[2].HeaderText = "Inventory";
            DgvPartsAssociated.Columns[3].HeaderText = "Price";
            DgvPartsAssociated.Columns[4].HeaderText = "Min";
            DgvPartsAssociated.Columns[5].HeaderText = "Max";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CleanUpRefs();
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CleanUpRefs();
        }

        private void CleanUpRefs()
        {
            if (mainScreen != null)
            {
                mainScreen.RefreshDataSource();
                mainScreen.addProductForm = null;
            }
            selectedProduct = null;
            mainScreen = null;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (mainScreen == null) return;

            string searchText = TbProductsSearch.Text.ToLower();
            List<Part> filteredParts = new List<Part>();

            if (searchText == "")
            {
                filteredParts.AddRange(mainScreen.inventory.allParts);
            }
            else
            {
                foreach (Part part in mainScreen.inventory.allParts)
                {
                    if (part.name.ToLower().Contains(searchText))
                    {
                        filteredParts.Add(mainScreen.inventory.lookupPart(part.partID));
                    }
                }
            }

            RefreshDataSource(filteredParts);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Part? partToAdd = GetSelectedCandidatePart();

            /* Only add if the part is not already associated*/
            if (partToAdd != null && !associatedPartsData.Contains(partToAdd))
            {
                associatedPartsData.Add(partToAdd);
                RefreshDataSource();
            }
            else
            {
                MessageBox.Show("That part is already associated.", "Error");
            }
        }

        public void RefreshDataSource(List<Part> partsFilter)
        {
            candidatePartsData = new BindingList<Part>(partsFilter);
            DgvCandidateParts.DataSource = null;
            DgvCandidateParts.DataSource = candidatePartsData;

            SetupHeaders();
        }

        public void RefreshDataSource()
        {
            if (mainScreen == null) return;

            candidatePartsData = new BindingList<Part>(mainScreen.inventory.allParts);
            DgvCandidateParts.DataSource = null;
            DgvCandidateParts.DataSource = candidatePartsData;

            DgvPartsAssociated.DataSource = null;
            DgvPartsAssociated.DataSource = associatedPartsData;

            SetupHeaders();
        }

        private Part GetSelectedCandidatePart()
        {
            if (mainScreen == null) return null;

            if (DgvCandidateParts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvCandidateParts.SelectedRows[0];
                int partId = Convert.ToInt32(selectedRow.Cells["partID"].Value);
                return mainScreen.inventory.lookupPart(partId);
            }
            else
            {
                MessageBox.Show("No row selected.", "Error");
                return null;
            }
        }

        private Part GetSelectedAssociatedPart()
        {
            if (mainScreen == null) return null;

            if (DgvPartsAssociated.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvPartsAssociated.SelectedRows[0];
                int partId = Convert.ToInt32(selectedRow.Cells["partID"].Value);
                return mainScreen.inventory.lookupPart(partId);
            }
            else
            {
                MessageBox.Show("No row selected.", "Error");
                return null;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Part partToDelete = GetSelectedAssociatedPart();

            if (partToDelete == null) return;

            associatedPartsData.Remove(partToDelete);
            RefreshDataSource();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (mainScreen != null)
            {
                if (selectedProduct == null) return;

                Product newProduct = new Product();

                newProduct.productID = CheckStringNotEmpty(TbId.Text) ? Int32.Parse(TbId.Text) : selectedProduct.productID;
                newProduct.name = CheckStringNotEmpty(TbName.Text) ? TbName.Text : selectedProduct.name;
                newProduct.inStock = CheckStringNotEmpty(TbInventory.Text) ? Int32.Parse(TbInventory.Text) : selectedProduct.inStock;
                newProduct.price = CheckStringNotEmpty(TbPriceCost.Text) ? Double.Parse(TbPriceCost.Text) : selectedProduct.price;
                newProduct.min = CheckStringNotEmpty(TbMin.Text) ? Int32.Parse(TbMin.Text) : selectedProduct.min;
                newProduct.max = CheckStringNotEmpty(TbMax.Text) ? Int32.Parse(TbMax.Text) : selectedProduct.max;

                ModifyInventoryProduct(newProduct);
                CleanUpRefs();
                Close();
            }
        }

        public bool CheckStringNotEmpty(string check)
        {
            return !string.IsNullOrEmpty(check);
        }

        private void ModifyInventoryProduct(Product toAdd)
        {
            if (mainScreen == null || selectedProduct == null) return;

            if (mainScreen.inventory == null) return;

            mainScreen.inventory.updateProduct(selectedProduct.productID, toAdd);
        }

    }
}

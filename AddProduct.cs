﻿using Software_I___C____C968.src;
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
    public partial class AddProduct : Form
    {
        MainScreen? mainScreen = null;
        public BindingList<Part> candidatePartsData { get; set; }
        public BindingList<Part> associatedPartsData { get; set; }

        public AddProduct(MainScreen screen)
        {
            InitializeComponent();
            mainScreen = screen;
            mainScreen.addProductForm = this;
            candidatePartsData = new BindingList<Part>(mainScreen.inventory.allParts);
            associatedPartsData = new BindingList<Part>();

            DgvCandidateParts.DataSource = candidatePartsData;
            DgvPartsAssociated.DataSource = associatedPartsData;

            DgvCandidateParts.AllowUserToAddRows = false;
            DgvPartsAssociated.AllowUserToAddRows = false;
            SetupHeaders();
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
            mainScreen = null;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (mainScreen == null) return;

            string searchText = TbPartsSearch.Text.ToLower();
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
            if (mainScreen == null) return;

            if (CheckTextBoxes())
            {
                Product newProduct = new Product();
                newProduct.associatedParts = new BindingList<Part>(associatedPartsData);
                newProduct.productID = Int32.Parse(TbId.Text);
                newProduct.name = TbName.Text;
                newProduct.inStock = Int32.Parse(TbInventory.Text);
                newProduct.price = double.Parse(TbPriceCost.Text);
                newProduct.min = Int32.Parse(TbMin.Text);
                newProduct.max = Int32.Parse(TbMax.Text);
                mainScreen.inventory.addProduct(newProduct);
                CleanUpRefs();
                Close();
            }

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
           
            if(Int32.Parse(TbMin.Text) > Int32.Parse(TbMax.Text))
            {
                MessageBox.Show("Min has to be less than or equal to Max", "Error");
                return false;
            }
            else if (Int32.Parse(TbMin.Text) > Int32.Parse(TbInventory.Text) || Int32.Parse(TbMax.Text) < Int32.Parse(TbInventory.Text))
            {
                MessageBox.Show("Your inventory has to be between min and max values.", "error");
                return false;
            }

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
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

        public bool CheckStringNotEmpty(string check)
        {
            return !string.IsNullOrEmpty(check);
        }
    }
}
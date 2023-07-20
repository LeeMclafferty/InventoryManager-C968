using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_I___C____C968.src
{
    internal class Inventory
    {

        public BindingList<Product> products;
        public BindingList<Part> part;

        public Inventory() { }
        public void addProduct(Product toAdd) { }
        public bool removeProduct(int toRemove) { return true; }
        public Product lookupProduct(int product) { return new Product(); }
        public void updateProduct(int n, Product product) { }
        public void addPart(Part toAdd) { }
        public bool deletePart(Part toRemove) { return true; }
        public Part lookupPart(int part) {  return new Part(); }
        public void updatePart(int n, Part part) { }
    }
}

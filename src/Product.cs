using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_I___C____C968.src
{
    internal class Product
    {
        public Product() { }
        public BindingList<Part> associatedParts;
        public int productID;
        public double price;
        public int inStock;
        public int min;
        public int max;

        public void addAssociatedPart(Part part) { }
        public bool removeAssociatedPart(int n) { return true; } 
        public Part lookupAssociatedPart(int n) { return new Part(); }
    }
}
